using System;
using System.Collections.Generic;
using System.Linq;
using MonoTouch.Foundation;
using MonoTouch.UIKit;
using MonoTouch.Dialog;
using TankMix_Share;
using System.Drawing;

namespace TankMix_iOS
{
	public partial class TankMix_Calculation_Screen_One : DialogViewController
	{
		// Properties Object


		// Dialog Elements
		EntryElement avEE;
		TankMixRadioGroupElement avRG;
		EntryElement prEE;
		TankMixRadioGroupElement prRG;
		EntryElement arEE;
		TankMixRadioGroupElement arRG;


		UIView DismissKeyBoardView;

		public TankMix_Calculation_Screen_One () : base (UITableViewStyle.Grouped, null)
		{
			//this.Pushing = true;
			Root = new RootElement ("TankMix");



			InitializeUserInterface ();


		}

		public override void ViewWillAppear (bool animated)
		{
			base.ViewWillAppear (animated);
			SetDefaultDataAndUnit ();
		}

		public override void ViewWillDisappear (bool animated)
		{
			base.ViewWillDisappear (animated);
			SaveValueToCurrentTankData ();
		}

		// Create Default User Interface for Screen One
		private void InitializeUserInterface ()
		{
			// add Next Button
			var NextBtn = new UIBarButtonItem ();
			NextBtn.Title = "Next";
			this.NavigationItem.RightBarButtonItem = NextBtn;
			NextBtn.Clicked += (object sender, EventArgs e) => {
				this.NavigationController.PushViewController ( new TankMix_Calculation_Screen_Two(),true);
			};


			var volumeS = new Section ();

			// Application Volume
			avEE = new EntryElement ("Application Volume", "Value", "0");
			avEE.TextAlignment = UITextAlignment.Right;
			avEE.KeyboardType = UIKeyboardType.NumberPad;
			avEE.Changed += (object sender, EventArgs e) => {
				HistoryManager.SharedInstance.GetCurrentTankData ().applicationvolume_value.SetValue(double.Parse(avEE.Value));
			};

			avRG = new TankMixRadioGroupElement (-1);
			var avRGRoot = new RootElement ("Application Volume Unit", avRG);
			var avRGRootSection = new Section ("Select Unit"){
				new RadioElement("US gpa"),
				new RadioElement("Imp gpa"),
				new RadioElement("L/ha"),
			};
			/*			var unitNames = Enum.GetValues(typeof(ApplicationVolumeUnit));
			foreach (var name in unitNames)
			{
				avRGRootSection.Add ( new RadioElement(name.ToString()));
			}
			*/
			avRG.ValueSelectedEvent +=  (object sender, EventArgs e) => 
			{

				switch(avRG.Selected)
				{
				case 0:
					HistoryManager.SharedInstance.GetCurrentTankData ().applicationvolume_value.SetValueAndUnit(ApplicationVolumeUnit.Us_gpa,double.Parse(avEE.Value));
					break;
				case 1:
					HistoryManager.SharedInstance.GetCurrentTankData ().applicationvolume_value.SetValueAndUnit(ApplicationVolumeUnit.Imp_gpa,double.Parse(avEE.Value));
					break;
				case 2:
					HistoryManager.SharedInstance.GetCurrentTankData ().applicationvolume_value.SetValueAndUnit(ApplicationVolumeUnit.L_ha,double.Parse(avEE.Value));
					break;
				}
			};
			avRGRoot.Add (avRGRootSection);
			// add elements to section
			volumeS.Add (avEE);
			volumeS.Add (avRGRoot);

			// Producate Rate
			var rateS = new Section ();
			prEE = new EntryElement ("Product Rate", "Value", "0");
			prEE.TextAlignment = UITextAlignment.Right;
			prEE.KeyboardType = UIKeyboardType.NumberPad;
			prEE.Changed += (object sender, EventArgs e) => 
			{
				HistoryManager.SharedInstance.GetCurrentTankData ().productrate_value.SetValue(double.Parse(prEE.Value));
			};

			prRG = new TankMixRadioGroupElement (-1);
			var prRGRoot = new RootElement ("Product Rate Unit",prRG);
			var prRGRootSection = new Section ("Select Unit"){
				new RadioElement("acres/case"),
				new RadioElement("L/acre"),
				new RadioElement("g/acre"),
				new RadioElement("ml/acre"),
				new RadioElement("US fl oz/acre"),
				new RadioElement("US pint/acre"),
				new RadioElement("US quart/acre"),
				new RadioElement("oz/acre"),
				new RadioElement("L/ha"),
				new RadioElement("g/ha"),
				new RadioElement("mL/ha"),
				 
			};
			prRG.ValueSelectedEvent += (object sender, EventArgs e) => 
			{
				switch(prRG.Selected)
				{
				case 0:
					HistoryManager.SharedInstance.GetCurrentTankData ().productrate_value.SetValueAndUnit(ProductRateUnit.Acres_case,double.Parse(prEE.Value));
					break;
				case 1:
					HistoryManager.SharedInstance.GetCurrentTankData ().productrate_value.SetValueAndUnit(ProductRateUnit.L_acre,double.Parse(prEE.Value));
					break;
				case 2:
					HistoryManager.SharedInstance.GetCurrentTankData ().productrate_value.SetValueAndUnit(ProductRateUnit.G_acre,double.Parse(prEE.Value));
					break;
				case 3:
					HistoryManager.SharedInstance.GetCurrentTankData ().productrate_value.SetValueAndUnit(ProductRateUnit.Ml_acre,double.Parse(prEE.Value));
					break;
				case 4:
					HistoryManager.SharedInstance.GetCurrentTankData ().productrate_value.SetValueAndUnit(ProductRateUnit.Us_fl_oz_acre,double.Parse(prEE.Value));
					break;
				case 5:
					HistoryManager.SharedInstance.GetCurrentTankData ().productrate_value.SetValueAndUnit(ProductRateUnit.Us_pint_acre,double.Parse(prEE.Value));
					break;
				case 6:
					HistoryManager.SharedInstance.GetCurrentTankData ().productrate_value.SetValueAndUnit(ProductRateUnit.Us_quart_acre,double.Parse(prEE.Value));
					break;
				case 7:
					HistoryManager.SharedInstance.GetCurrentTankData ().productrate_value.SetValueAndUnit(ProductRateUnit.Oz_acre,double.Parse(prEE.Value));
					break;
				case 8:
					HistoryManager.SharedInstance.GetCurrentTankData ().productrate_value.SetValueAndUnit(ProductRateUnit.L_ha,double.Parse(prEE.Value));
					break;
				case 9:
					HistoryManager.SharedInstance.GetCurrentTankData ().productrate_value.SetValueAndUnit(ProductRateUnit.G_ha,double.Parse(prEE.Value));
					break;
				case 10:
					HistoryManager.SharedInstance.GetCurrentTankData ().productrate_value.SetValueAndUnit(ProductRateUnit.Ml_ha,double.Parse(prEE.Value));
					break;
				}
			};         
			prRGRoot.Add (prRGRootSection);
			rateS.Add (prEE);
			rateS.Add (prRGRoot);

			// Adjuvant Rate
			var adjuvantS = new Section ();
			arEE = new EntryElement ("Adjuvant Rate","Value","0");
			arEE.TextAlignment = UITextAlignment.Right;
			arEE.KeyboardType = UIKeyboardType.NumberPad;
			arEE.Changed += (object sender, EventArgs e) => {
				HistoryManager.SharedInstance.GetCurrentTankData ().adjuvantrate_value.SetValue(double.Parse(arEE.Value));
			};

			arRG = new TankMixRadioGroupElement (-1);
			var arRGRoot = new RootElement ("Adjuvant Rate Unit",arRG);
			var arRGSection = new Section ("Select Unit")
			{
				new RadioElement("%v/v"),
				new RadioElement("L/acre"),
				new RadioElement("mL/acre"),
				new RadioElement("Us fl oz/acre"),
				new RadioElement("quart/acre"),
			};
			arRG.ValueSelectedEvent += (object o, EventArgs e)=>{

				switch (arRG.Selected)
				{
				case 0 :
					HistoryManager.SharedInstance.GetCurrentTankData ().adjuvantrate_value.SetValueAndUnit(AdjuvantRateUnit.V_v,double.Parse(arEE.Value));
					break;
				case 1:
					HistoryManager.SharedInstance.GetCurrentTankData ().adjuvantrate_value.SetValueAndUnit(AdjuvantRateUnit.L_acre,double.Parse(arEE.Value));
					break;
				case 2:
					HistoryManager.SharedInstance.GetCurrentTankData ().adjuvantrate_value.SetValueAndUnit(AdjuvantRateUnit.Ml_acre, double.Parse(arEE.Value));
					break;
				case 3:
					HistoryManager.SharedInstance.GetCurrentTankData ().adjuvantrate_value.SetValueAndUnit(AdjuvantRateUnit.Us_fl_oz_acre,double.Parse(arEE.Value));
					break;
				case 4:
					HistoryManager.SharedInstance.GetCurrentTankData ().adjuvantrate_value.SetValueAndUnit(AdjuvantRateUnit.Quart_acre,double.Parse(arEE.Value));
					break;
				}
			};
			arRGRoot.Add (arRGSection);
			adjuvantS.Add (arEE);
			adjuvantS.Add (arRGRoot);


			Root.Add (volumeS);
			Root.Add (rateS);
			Root.Add (adjuvantS);
		}

		private void SetDefaultDataAndUnit()
		{
			avEE.Value = HistoryManager.SharedInstance.GetCurrentTankData ().applicationvolume_value.value.ToString();
			avRG.Selected = (int)HistoryManager.SharedInstance.GetCurrentTankData ().applicationvolume_value.unit;

			prEE.Value = HistoryManager.SharedInstance.GetCurrentTankData ().productrate_value.value.ToString ();
			prRG.Selected = (int)HistoryManager.SharedInstance.GetCurrentTankData ().productrate_value.unit;

			arEE.Value = HistoryManager.SharedInstance.GetCurrentTankData ().adjuvantrate_value.value.ToString ();
			arRG.Selected = (int)HistoryManager.SharedInstance.GetCurrentTankData ().adjuvantrate_value.unit;
		}

		private void SaveValueToCurrentTankData ()
		{
			//HistoryManager.SharedInstance.GetCurrentTankData ().applicationvolume_value.value = double.Parse(avEE.Value);
			//HistoryManager.SharedInstance.GetCurrentTankData ().applicationvolume_value.unit = (ApplicationVolumeUnit)avRG.Selected;
			switch(avRG.Selected)
			{
			case 0:
				HistoryManager.SharedInstance.GetCurrentTankData ().applicationvolume_value.SetValueAndUnit(ApplicationVolumeUnit.Us_gpa,double.Parse(avEE.Value));
				break;
			case 1:
				HistoryManager.SharedInstance.GetCurrentTankData ().applicationvolume_value.SetValueAndUnit(ApplicationVolumeUnit.Imp_gpa,double.Parse(avEE.Value));
				break;
			case 2:
				HistoryManager.SharedInstance.GetCurrentTankData ().applicationvolume_value.SetValueAndUnit(ApplicationVolumeUnit.L_ha,double.Parse(avEE.Value));
				break;
			}
			//HistoryManager.SharedInstance.GetCurrentTankData ().productrate_value.value = double.Parse (prEE.Value);
			//HistoryManager.SharedInstance.GetCurrentTankData ().productrate_value.unit = (ProductRateUnit)prRG.Selected;
			switch(prRG.Selected)
			{
			case 0:
				HistoryManager.SharedInstance.GetCurrentTankData ().productrate_value.SetValueAndUnit(ProductRateUnit.Acres_case,double.Parse(prEE.Value));
				break;
			case 1:
				HistoryManager.SharedInstance.GetCurrentTankData ().productrate_value.SetValueAndUnit(ProductRateUnit.L_acre,double.Parse(prEE.Value));
				break;
			case 2:
				HistoryManager.SharedInstance.GetCurrentTankData ().productrate_value.SetValueAndUnit(ProductRateUnit.G_acre,double.Parse(prEE.Value));
				break;
			case 3:
				HistoryManager.SharedInstance.GetCurrentTankData ().productrate_value.SetValueAndUnit(ProductRateUnit.Ml_acre,double.Parse(prEE.Value));
				break;
			case 4:
				HistoryManager.SharedInstance.GetCurrentTankData ().productrate_value.SetValueAndUnit(ProductRateUnit.Us_fl_oz_acre,double.Parse(prEE.Value));
				break;
			case 5:
				HistoryManager.SharedInstance.GetCurrentTankData ().productrate_value.SetValueAndUnit(ProductRateUnit.Us_pint_acre,double.Parse(prEE.Value));
				break;
			case 6:
				HistoryManager.SharedInstance.GetCurrentTankData ().productrate_value.SetValueAndUnit(ProductRateUnit.Us_quart_acre,double.Parse(prEE.Value));
				break;
			case 7:
				HistoryManager.SharedInstance.GetCurrentTankData ().productrate_value.SetValueAndUnit(ProductRateUnit.Oz_acre,double.Parse(prEE.Value));
				break;
			case 8:
				HistoryManager.SharedInstance.GetCurrentTankData ().productrate_value.SetValueAndUnit(ProductRateUnit.L_ha,double.Parse(prEE.Value));
				break;
			case 9:
				HistoryManager.SharedInstance.GetCurrentTankData ().productrate_value.SetValueAndUnit(ProductRateUnit.G_ha,double.Parse(prEE.Value));
				break;
			case 10:
				HistoryManager.SharedInstance.GetCurrentTankData ().productrate_value.SetValueAndUnit(ProductRateUnit.Ml_ha,double.Parse(prEE.Value));
				break;
			}
			//HistoryManager.SharedInstance.GetCurrentTankData ().adjuvantrate_value.value = double.Parse (arEE.Value);
			//HistoryManager.SharedInstance.GetCurrentTankData ().adjuvantrate_value.unit = (AdjuvantRateUnit)arRG.Selected;
			switch (arRG.Selected)
			{
			case 0 :
				HistoryManager.SharedInstance.GetCurrentTankData ().adjuvantrate_value.SetValueAndUnit(AdjuvantRateUnit.V_v,double.Parse(arEE.Value));
				break;
			case 1:
				HistoryManager.SharedInstance.GetCurrentTankData ().adjuvantrate_value.SetValueAndUnit(AdjuvantRateUnit.L_acre,double.Parse(arEE.Value));
				break;
			case 2:
				HistoryManager.SharedInstance.GetCurrentTankData ().adjuvantrate_value.SetValueAndUnit(AdjuvantRateUnit.Ml_acre, double.Parse(arEE.Value));
				break;
			case 3:
				HistoryManager.SharedInstance.GetCurrentTankData ().adjuvantrate_value.SetValueAndUnit(AdjuvantRateUnit.Us_fl_oz_acre,double.Parse(arEE.Value));
				break;
			case 4:
				HistoryManager.SharedInstance.GetCurrentTankData ().adjuvantrate_value.SetValueAndUnit(AdjuvantRateUnit.Quart_acre,double.Parse(arEE.Value));
				break;
			}
		}
		// Customized Keyboard view and "Done" button for ending input
		public override UIView InputAccessoryView
		{
			get
			{
				if (DismissKeyBoardView == null)
				{

					UIToolbar toolbar = new UIToolbar(new RectangleF(0, 0, 320, 30));
					toolbar.Translucent = true;
					toolbar.BarStyle = UIBarStyle.Black;

					DismissKeyBoardView = new UIView(new RectangleF(-20, -120, 320, 30));
					var dismissBtn = new UIButton(new RectangleF(268, 1, 50, 29));
					dismissBtn.SetTitle ("Done", UIControlState.Normal);

					dismissBtn.AllEvents += delegate
					{
						View.EndEditing (true);
					};

					toolbar.AddSubview(dismissBtn);
					DismissKeyBoardView.AddSubview(toolbar);
					DismissKeyBoardView.BringSubviewToFront(dismissBtn);
					DismissKeyBoardView.BringSubviewToFront(toolbar);

				}
				return DismissKeyBoardView;
			}
		}
	}


	public class TankMixRadioGroupElement : RadioGroup
	{
	
		public event EventHandler ValueSelectedEvent;
		public int SelectedValue;

		public TankMixRadioGroupElement (int i) : base (i){}

		public override int Selected {
			get {
				return base.Selected;
			}
			set {
				base.Selected = value;
				SelectedValue = value;
				if (ValueSelectedEvent != null) {
					ValueSelectedEvent (this, EventArgs.Empty);
				}
			}
		}
	}
}



















