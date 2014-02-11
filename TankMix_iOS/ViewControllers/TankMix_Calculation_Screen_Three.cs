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
	public partial class TankMix_Calculation_Screen_Three : DialogViewController
	{

		EntryElement taEE;
		TankMixRadioGroupElement taRG;
		EntryElement bwEE;
		TankMixRadioGroupElement bwRG;
		EntryElement slEE;
		TankMixRadioGroupElement slRG;
		EntryElement nhsEE;

		UIView DismissKeyBoardView;

		public TankMix_Calculation_Screen_Three () : base (UITableViewStyle.Grouped, null)
		{
			this.Pushing = true;
			Root = new RootElement ("Optional Factors");
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

		}

		private void InitializeUserInterface ()
		{

			// add Result Button
			var NextBtn = new UIBarButtonItem ();
			NextBtn.Title = "Result";
			this.NavigationItem.RightBarButtonItem = NextBtn;
			NextBtn.Clicked += (object sender, EventArgs e) => {
				this.NavigationController.PushViewController ( new TankMix_Calculation_Screen_Four(),true);
			};


			// Total Area
			var areaS = new Section ();
			taEE = new EntryElement ("Total Area","Value","0");
			taEE.TextAlignment = UITextAlignment.Right;
			taEE.KeyboardType = UIKeyboardType.NumberPad;
			taEE.Changed += (object sender, EventArgs e) => {
				HistoryManager.SharedInstance.GetCurrentTankData ().totalarea_value.SetValue(double.Parse(taEE.Value));
			};
			taRG = new TankMixRadioGroupElement (-1);
			var taRGRoot = new RootElement ("Total Area Unit",taRG);
			var taRGRootSection = new Section ("Select Unit"){
				new RadioElement("Acres"),
				new RadioElement("ha"),
			};
			taRG.ValueSelectedEvent += (object sender, EventArgs e) => {
				switch(taRG.Selected)
				{
				case 0:
					HistoryManager.SharedInstance.GetCurrentTankData().totalarea_value.SetValueAndUnit(TotalAreaUnit.Acres,double.Parse(taEE.Value));
					break;
				case 1:
					HistoryManager.SharedInstance.GetCurrentTankData().totalarea_value.SetValueAndUnit(TotalAreaUnit.Ha,double.Parse(taEE.Value));
					break;
				}
			};
			areaS.Add (taEE);
			taRGRoot.Add (taRGRootSection);
			areaS.Add (taRGRoot);

			//Boom Width
			var widthS = new Section ();
			bwEE = new EntryElement ("Boom Width","Value","0");
			bwEE.TextAlignment = UITextAlignment.Right;
			bwEE.KeyboardType = UIKeyboardType.NumberPad;
			bwEE.Changed += (object sender, EventArgs e) => {
				HistoryManager.SharedInstance.GetCurrentTankData ().boomwidth_value.SetValue(double.Parse(bwEE.Value));
			};
			bwRG = new TankMixRadioGroupElement (-1);
			var bwRGRoot = new RootElement ("Boom Width Unit", bwRG);
			var bwRGRootSection = new Section ("Select Unit"){
				new RadioElement("m"),
				new RadioElement("f"),
			};
			taRG.ValueSelectedEvent += (object sender, EventArgs e) => {
				switch(taRG.Selected)
				{
				case 0:
					var c = bwEE.Value;
					HistoryManager.SharedInstance.GetCurrentTankData().boomwidth_value.SetValueAndUnit(BoomWidthUnit.M,double.Parse(bwEE.Value));
					break;
				
				case 1:
					HistoryManager.SharedInstance.GetCurrentTankData().boomwidth_value.SetValueAndUnit(BoomWidthUnit.Ft,double.Parse(bwEE.Value));
					break;
				}

			};
			widthS.Add (bwEE);
			bwRGRoot.Add (bwRGRootSection);
			widthS.Add (bwRGRoot);

			// Swath Length
			var lengthS = new Section ();
			slEE = new EntryElement ("Swath Length", "Value","0");
			slEE.TextAlignment = UITextAlignment.Right;
			slEE.KeyboardType = UIKeyboardType.NumberPad;
			slEE.Changed += (object sender, EventArgs e) => {
				HistoryManager.SharedInstance.GetCurrentTankData ().swathlength_value.SetValue(double.Parse(slEE.Value));
			};
			slRG = new TankMixRadioGroupElement (-1);
			var slRGRoot = new RootElement ("Swath Length Unit",slRG);
			var slRGRootSection = new Section ("Select Unit") {
				new RadioElement("Mile"),
				new RadioElement("M"),
			};
			slRG.ValueSelectedEvent += (object sender, EventArgs e) => {
				switch(slRG.Selected)
				{
				case 0:
					HistoryManager.SharedInstance.GetCurrentTankData().swathlength_value.SetValueAndUnit(SwathLengthUnit.Mile,double.Parse(slEE.Value));
					break;
				case 1:
					HistoryManager.SharedInstance.GetCurrentTankData().swathlength_value.SetValueAndUnit(SwathLengthUnit.M,double.Parse(slEE.Value));
					break;
				}
			};
			lengthS.Add (slEE);
			slRGRoot.Add (slRGRootSection);
			lengthS.Add (slRGRoot);

			// Number of Headland Swaths
			var numberS = new Section ();
			nhsEE = new EntryElement ("Number of Headland Swaths","Value","0");
			nhsEE.KeyboardType = UIKeyboardType.NumberPad;
			nhsEE.TextAlignment = UITextAlignment.Right;
			nhsEE.Changed += (object sender, EventArgs e) => {
				HistoryManager.SharedInstance.GetCurrentTankData().number_headlands_swaths_value = double.Parse(nhsEE.Value);
			};
			numberS.Add (nhsEE);


			Root.Add (areaS);
			Root.Add (widthS);
			Root.Add (lengthS);
			Root.Add (numberS);

		}

		private void SetDefaultDataAndUnit ()
		{
			taEE.Value = HistoryManager.SharedInstance.GetCurrentTankData().totalarea_value.value.ToString();
			taRG.Selected = (int) HistoryManager.SharedInstance.GetCurrentTankData().totalarea_value.unit;
			bwEE.Value = HistoryManager.SharedInstance.GetCurrentTankData().boomwidth_value.value.ToString();
			bwRG.Selected = (int)HistoryManager.SharedInstance.GetCurrentTankData().boomwidth_value.unit;
			slEE.Value = HistoryManager.SharedInstance.GetCurrentTankData().swathlength_value.value.ToString();
			slRG.Selected = (int)HistoryManager.SharedInstance.GetCurrentTankData().swathlength_value.unit;
			nhsEE.Value = HistoryManager.SharedInstance.GetCurrentTankData().number_headlands_swaths_value.ToString();
		}

		private void SaveValueToCurrentTankData()
		{
			//HistoryManager.SharedInstance.GetCurrentTankData ().totalarea_value.value = double.Parse (taEE.Value);
			//HistoryManager.SharedInstance.GetCurrentTankData ().totalarea_value.unit = (TotalAreaUnit)taRG.Selected;
			switch(taRG.Selected)
			{
			case 0:
				HistoryManager.SharedInstance.GetCurrentTankData().totalarea_value.SetValueAndUnit(TotalAreaUnit.Acres,double.Parse(taEE.Value));
				break;
			case 1:
				HistoryManager.SharedInstance.GetCurrentTankData().totalarea_value.SetValueAndUnit(TotalAreaUnit.Ha,double.Parse(taEE.Value));
				break;
			}
			//HistoryManager.SharedInstance.GetCurrentTankData ().boomwidth_value.value = double.Parse (bwEE.Value);
			//HistoryManager.SharedInstance.GetCurrentTankData().boomwidth_value.unit = (BoomWidthUnit)bwRG.Selected;
			switch(taRG.Selected)
			{
			case 0:
				var c = bwEE.Value;
				HistoryManager.SharedInstance.GetCurrentTankData().boomwidth_value.SetValueAndUnit(BoomWidthUnit.M,double.Parse(bwEE.Value));
				break;

			case 1:
				HistoryManager.SharedInstance.GetCurrentTankData().boomwidth_value.SetValueAndUnit(BoomWidthUnit.Ft,double.Parse(bwEE.Value));
				break;
			}

			//HistoryManager.SharedInstance.GetCurrentTankData ().swathlength_value.value = double.Parse (slEE.Value);
			//HistoryManager.SharedInstance.GetCurrentTankData ().swathlength_value.unit = (SwathLengthUnit)slRG.Selected;
			switch(slRG.Selected)
			{
			case 0:
				HistoryManager.SharedInstance.GetCurrentTankData().swathlength_value.SetValueAndUnit(SwathLengthUnit.Mile,double.Parse(slEE.Value));
				break;
			case 1:
				HistoryManager.SharedInstance.GetCurrentTankData().swathlength_value.SetValueAndUnit(SwathLengthUnit.M,double.Parse(slEE.Value));
				break;
			}
			//
			HistoryManager.SharedInstance.GetCurrentTankData ().number_headlands_swaths_value = double.Parse (nhsEE.Value);
		}

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
}
