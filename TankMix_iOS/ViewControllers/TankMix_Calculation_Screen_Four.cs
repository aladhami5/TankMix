using System;
using System.Collections.Generic;
using System.Linq;
using MonoTouch.Foundation;
using MonoTouch.UIKit;
using MonoTouch.Dialog;
using TankMix_Share;

namespace TankMix_iOS
{
	public partial class TankMix_Calculation_Screen_Four : DialogViewController
	{

		CalculationResult Result;
		TankMixRadioGroupElement atbtRG;
		TankMixRadioGroupElement paRG;
		TankMixRadioGroupElement aaRG;
		TankMixRadioGroupElement ttRG;
		TankMixRadioGroupElement notnRG;

		public TankMix_Calculation_Screen_Four () : base (UITableViewStyle.Grouped, null)
		{
			this.Pushing = true;
			Root = new RootElement ("Results");
			Result = new CalculationResult ();
			InitializeUserInterface ();
		}

		private void InitializeUserInterface ()
		{
			var Section = new Section ();
			// Tank Input
			var CurTank = HistoryManager.SharedInstance.GetCurrentTankData ();

			Result.TankInput.applicationvolume_value.SetValueAndUnit (CurTank.applicationvolume_value.unit,CurTank.applicationvolume_value.value);
			Result.TankInput.productrate_value.SetValueAndUnit (CurTank.productrate_value.unit,CurTank.productrate_value.value);
			Result.TankInput.adjuvantrate_value.SetValueAndUnit (CurTank.adjuvantrate_value.unit,CurTank.adjuvantrate_value.value);
			Result.TankInput.tankcapacity_value.SetValueAndUnit (CurTank.tankcapacity_value.unit,CurTank.tankcapacity_value.value);
			Result.TankInput.tankremainder_value.SetValueAndUnit (CurTank.tankremainder_value.unit,CurTank.tankremainder_value.value);
			Result.TankInput.sumpcapacity_value.SetValueAndUnit (CurTank.sumpcapacity_value.unit,CurTank.sumpcapacity_value.value);
			Result.TankInput.totalarea_value.SetValueAndUnit (CurTank.totalarea_value.unit,CurTank.totalarea_value.value);
			Result.TankInput.boomwidth_value.SetValueAndUnit (CurTank.boomwidth_value.unit,CurTank.boomwidth_value.value);
			Result.TankInput.swathlength_value.SetValueAndUnit (CurTank.swathlength_value.unit,CurTank.swathlength_value.value);
			Result.TankInput.number_headlands_swaths_value = CurTank.number_headlands_swaths_value;

			// Area Treated By Tank
			var r_AreaTreatedByTank = 0.0;
			r_AreaTreatedByTank = CalculationManager.SharedInstance.AreaTreatedByTank ();
			Result.areatreatedbytank_value.value = r_AreaTreatedByTank;
			if (HistoryManager.SharedInstance.GetCurrentTankData ().tankcapacity_value.unit == TankCapacityUnit.L) {
				Result.areatreatedbytank_value.unit = AreaTreatedByTankUnit.Ha;
				Result.areatreatedbytank_value.Ha = r_AreaTreatedByTank;
				Result.areatreatedbytank_value.Acres = CalculationManager.SharedInstance.HaToAcres (Result.areatreatedbytank_value.Ha);

			} else {
				Result.areatreatedbytank_value.unit = AreaTreatedByTankUnit.Acres;
				Result.areatreatedbytank_value.Acres = r_AreaTreatedByTank;
				Result.areatreatedbytank_value.Ha = CalculationManager.SharedInstance.AcresToHa (Result.areatreatedbytank_value.Acres);
			}
			atbtRG = new TankMixRadioGroupElement (0);
			var atbtRGRoot = new RootElement ("Area Treated By Tank",atbtRG);
			var atbtRGRootSection = new Section ();
			switch (Result.areatreatedbytank_value.unit)
			{
			case AreaTreatedByTankUnit.Acres:
				atbtRGRootSection.Add (new RadioElement (string.Format("{0:00.00}",Result.areatreatedbytank_value.Acres)+ " Acres"));
				atbtRGRootSection.Add (new RadioElement(string.Format("{0:00.00}",Result.areatreatedbytank_value.Ha) + " Ha"));
				break;
			case AreaTreatedByTankUnit.Ha:
				atbtRGRootSection.Add (new RadioElement(string.Format("{0:00.00}",Result.areatreatedbytank_value.Ha) + " Ha"));
				atbtRGRootSection.Add (new RadioElement (string.Format("{0:00.00}",Result.areatreatedbytank_value.Acres)+ " Acres"));
				break;
			}

			atbtRGRoot.Add (atbtRGRootSection);
			Section.Add (atbtRGRoot);

			// Product Amount
			var r_ProductAmount = 0.0;
			r_ProductAmount = CalculationManager.SharedInstance.ProductAmount (Result.areatreatedbytank_value);
			switch(HistoryManager.SharedInstance.GetCurrentTankData().productrate_value.unit)
			{
			case ProductRateUnit.Acres_case:
				Result.productamount_value.SetValueAndUnit (ProductAmountUnit.Case, r_ProductAmount);
				break;
			case ProductRateUnit.G_acre:
				Result.productamount_value.SetValueAndUnit (ProductAmountUnit.G, r_ProductAmount);
				break;
			case ProductRateUnit.G_ha:
				Result.productamount_value.SetValueAndUnit (ProductAmountUnit.G, r_ProductAmount);
				break;
			case ProductRateUnit.L_acre:
				Result.productamount_value.SetValueAndUnit (ProductAmountUnit.L, r_ProductAmount);
				break;
			case ProductRateUnit.L_ha:
				Result.productamount_value.SetValueAndUnit (ProductAmountUnit.L, r_ProductAmount);
				break;
			case ProductRateUnit.Ml_acre:
				Result.productamount_value.SetValueAndUnit (ProductAmountUnit.Ml, r_ProductAmount);
				break;
			case ProductRateUnit.Ml_ha:
				Result.productamount_value.SetValueAndUnit (ProductAmountUnit.Ml, r_ProductAmount);
				break;
			case ProductRateUnit.Oz_acre:
				Result.productamount_value.SetValueAndUnit (ProductAmountUnit.Oz, r_ProductAmount);
				break;
			case ProductRateUnit.Us_fl_oz_acre:
				Result.productamount_value.SetValueAndUnit (ProductAmountUnit.Us_fl_oz, r_ProductAmount);
				break;
			case ProductRateUnit.Us_pint_acre:
				Result.productamount_value.SetValueAndUnit(ProductAmountUnit.L,CalculationManager.SharedInstance.Us_pintToL(r_ProductAmount));
				break;
			case ProductRateUnit.Us_quart_acre:
				Result.productamount_value.SetValueAndUnit(ProductAmountUnit.L,CalculationManager.SharedInstance.Us_quarttToL(r_ProductAmount));
				break;
			}

			paRG = new TankMixRadioGroupElement ((int)(Result.productamount_value.unit));
			var paRGRoot = new RootElement ("Product Amount",paRG);
			var paRGRootSection = new Section (){
			new RadioElement(string.Format("{0:00.00}",Result.productamount_value.Case) + "   Cases"),
			new RadioElement(string.Format("{0:00.00}",Result.productamount_value.L) + "  L"),
			new RadioElement(string.Format("{0:00.00}",Result.productamount_value.Ml)+ "  mL"),
			new RadioElement(string.Format("{0:00.00}",Result.productamount_value.G) + "  g"),
			new RadioElement(string.Format("{0:00.00}",Result.productamount_value.Us_fl_oz)+ "  US fl oz"),
			new RadioElement(string.Format("{0:00.00}",Result.productamount_value.Oz )+ "  oz"),
			};
			paRGRoot.Add (paRGRootSection);
			Section.Add (paRGRoot);

			// Adjuvant Amount
			var r_AdjuvantAmount = CalculationManager.SharedInstance.AdjuvantAmount (Result.areatreatedbytank_value);
			switch(HistoryManager.SharedInstance.GetCurrentTankData().adjuvantrate_value.unit)
			{
			case AdjuvantRateUnit.L_acre:
				Result.adjuvantamount_value.SetValueAndUnit (AdjuvantAmountUnit.L, r_AdjuvantAmount);
				break;
			case AdjuvantRateUnit.Ml_acre:
				Result.adjuvantamount_value.SetValueAndUnit (AdjuvantAmountUnit.Ml, r_AdjuvantAmount);
				break;
			case AdjuvantRateUnit.Quart_acre:
				Result.adjuvantamount_value.SetValueAndUnit (AdjuvantAmountUnit.Us_quart, r_AdjuvantAmount);
				break;
			case AdjuvantRateUnit.Us_fl_oz_acre:
				Result.adjuvantamount_value.SetValueAndUnit (AdjuvantAmountUnit.Us_fl_oz, r_AdjuvantAmount);
				break;
			case AdjuvantRateUnit.V_v:
				Result.adjuvantamount_value.SetValueAndUnit (AdjuvantAmountUnit.L, r_AdjuvantAmount);
				break;
			}
			aaRG = new TankMixRadioGroupElement ((int)Result.adjuvantamount_value.unit);
			var aaRGRoot = new RootElement ("Adjuvant Amount", aaRG);
			var aaRGRootSection = new Section (){
			new RadioElement(string.Format("{0:00.00}",Result.adjuvantamount_value.L)+"  L"),
			new RadioElement(string.Format("{0:00.00}",Result.adjuvantamount_value.Ml)+"  mL"),
			new RadioElement(string.Format("{0:00.00}",Result.adjuvantamount_value.Us_fl_oz)+"  US fl oz"),
			new RadioElement(string.Format("{0:00.00}",Result.adjuvantamount_value.Us_quart)+"  US quart"),

			};
			aaRGRoot.Add (aaRGRootSection);
			Section.Add (aaRGRoot);

			//Total Water
			var r_totalWater = CalculationManager.SharedInstance.TotalWater();
			ttRG = new TankMixRadioGroupElement ((int)HistoryManager.SharedInstance.GetCurrentTankData().applicationvolume_value.unit);
			switch (HistoryManager.SharedInstance.GetCurrentTankData().applicationvolume_value.unit)
			{
			case ApplicationVolumeUnit.Imp_gpa:
				Result.totalwater_value.SetValueAndUnit (TotalWaterUnit.Imp_gal,r_totalWater);
				break;
			case ApplicationVolumeUnit.L_ha:
				Result.totalwater_value.SetValueAndUnit (TotalWaterUnit.L,r_totalWater);
				break;
			case ApplicationVolumeUnit.Us_gpa:
				Result.totalwater_value.SetValueAndUnit (TotalWaterUnit.Us_gal,r_totalWater);
				break;
			}
			var ttRGRoot = new RootElement ("Total Water",ttRG);
			var ttRGRootSection = new Section ("Unit Select"){
			new RadioElement(string.Format("{0:00.00}",Result.totalwater_value.value) + " Us gal"),
			new RadioElement(string.Format("{0:00.00}",Result.totalwater_value.value) + " Imp gal"),
			new RadioElement(string.Format("{0:00.00}",Result.totalwater_value.value) + " L"),
			};
			ttRGRoot.Add (ttRGRootSection);
			Section.Add (ttRGRoot);


			// number of tanks needed
			Result.numberOfTanksNeeded = CalculationManager.SharedInstance.NumberOfTankNeeded (Result.totalwater_value);
			notnRG = new TankMixRadioGroupElement (0);
			var notnRGRoot = new RootElement ("Number of Tanks Needed",notnRG);
			var temp = Result.numberOfTanksNeeded;
			var counter = 0;
			while (temp > 0) {
				temp = temp - 1;
				counter++;
			}
			Result.numberOfFills = counter;
			switch(HistoryManager.SharedInstance.GetCurrentTankData().boomwidth_value.unit)
			{
			case BoomWidthUnit.Ft:
				Result.areaperround_value.SetValueAndUnit (AreaPerRoundUnit.Acres, CalculationManager.SharedInstance.HaToAcres (CalculationManager.SharedInstance.AreaPerRound()));
				break;
			case BoomWidthUnit.M:
				Result.areaperround_value.SetValueAndUnit (AreaPerRoundUnit.Ha,CalculationManager.SharedInstance.AreaPerRound());
				break;

			}
			var notRGAreaRound = new TankMixRadioGroupElement ((int)HistoryManager.SharedInstance.GetCurrentTankData().boomwidth_value.unit);
			var notRGAreaRoundSection = new Section ()
			{
			new RadioElement(string.Format("{0:0.00}",Result.areaperround_value.Ha)+" Ha"),
			new RadioElement(string.Format("{0:0.00}",Result.areaperround_value.Acres)+" Acres"),
			};
			var notRGAreaRoundRoot = new RootElement("Area Per Round",notRGAreaRound);
			notRGAreaRoundRoot.Add (notRGAreaRoundSection);
			var nonRGRootSection = new Section ();
			nonRGRootSection.Add (new RadioElement(string.Format("{0:0.00}",Result.numberOfTanksNeeded)));
			nonRGRootSection.Add (new StringElement("Number of Fills",Result.numberOfFills.ToString()));
			nonRGRootSection.Add (notRGAreaRoundRoot);

			Result.roundpertank = CalculationManager.SharedInstance.RoundsPerTank (Result.areaperround_value);
			nonRGRootSection.Add (new StringElement("Rounds per Tank", string.Format("{0:0.00}",Result.roundpertank)));
			notnRGRoot.Add (nonRGRootSection);
			Section.Add (notnRGRoot);


			var FillSection = new Section ("Fills");

			for(int i=1; i<=Result.numberOfFills; i++)
			{
				var btn = new StringElement ("Fill "+i, string.Empty);
				btn.Tapped += () => {
				//Console.Out.WriteLine(btn.Caption);
				this.NavigationController.PushViewController(new TankMix_CalculationCreateFill (Convert.ToInt32(btn.Caption.Split(' ')[1]),Result.fills),true);
				};
				FillSection.Add (btn);
			}
	
			Root.Add (Section);
			notnRGRoot.Add (FillSection);

			// Save Btn
			var SaveBtn = new UIBarButtonItem ();
			SaveBtn.Title = "Save";
			SaveBtn.Clicked += (object sender, EventArgs e) => {
				//Result.TankInput = HistoryManager.SharedInstance.GetCurrentTankData ();


				var a = HistoryManager.SharedInstance.GetResultList();
				a.Add(Result);
				//var Alert = new UIAlertView ("", "Successfully Save", null, "Continue").Show (); 
				var Alert = new UIAlertView ();
				Alert.Message = "Successfully saved";
				Alert.AddButton ("Continue");
				Alert.Clicked += (object s, UIButtonEventArgs ee) => {
					if(ee.ButtonIndex == 0)
					{
						this.NavigationController.PopToRootViewController(true);
					}
				};
				Alert.Show();
			};
			this.NavigationItem.RightBarButtonItem = SaveBtn;

		}
	}
}
