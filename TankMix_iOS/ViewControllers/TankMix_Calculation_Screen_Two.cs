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
	public partial class TankMix_Calculation_Screen_Two : DialogViewController
	{

		EntryElement tcEE;
		TankMixRadioGroupElement tcRG;
		EntryElement trEE;
		TankMixRadioGroupElement trRG;

		Section remainderS;

		UIView DismissKeyBoardView;
		public TankMix_Calculation_Screen_Two () : base (UITableViewStyle.Grouped, null)
		{
			this.Pushing = true;
			Root = new RootElement ("Tank Mix");
			InitializeUserInterface ();
			//SetDefaultDataAndUnit ();
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

		private void InitializeUserInterface ()
		{
			// add Next Button
			var NextBtn = new UIBarButtonItem ();
			NextBtn.Title = "Next";
			this.NavigationItem.RightBarButtonItem = NextBtn;
			NextBtn.Clicked += (object sender, EventArgs e) => {
				this.NavigationController.PushViewController ( new TankMix_Calculation_Screen_Three(),true);
			};


			// Tank Capacity

			var capacityS = new Section ();

			tcEE = new EntryElement ("Tank Capacity","Value","0");
			tcEE.TextAlignment = UITextAlignment.Right;
			tcEE.KeyboardType = UIKeyboardType.NumberPad;
			tcEE.Changed += (object sender, EventArgs e) => {
				HistoryManager.SharedInstance.GetCurrentTankData ().tankcapacity_value.SetValue(double.Parse(tcEE.Value));
			};
			tcRG = new TankMixRadioGroupElement (-1);
			var tcRGRoot = new RootElement ("Tank Capacity Unit",tcRG);
			var tcRGRootSection = new Section ("Unit Select"){
				new RadioElement ("US gal"),
				new RadioElement ("Imp gal"),
				new RadioElement ("L"),
			};
			tcRG.ValueSelectedEvent += (object sender, EventArgs e) => {
				switch(tcRG.Selected)
				{
				case 0:
					HistoryManager.SharedInstance.GetCurrentTankData ().tankcapacity_value.SetValueAndUnit(TankCapacityUnit.Us_gal,double.Parse(tcEE.Value));
					break;
				case 1:
					HistoryManager.SharedInstance.GetCurrentTankData ().tankcapacity_value.SetValueAndUnit(TankCapacityUnit.Imp_gal,double.Parse(tcEE.Value));
					break;
				case 2:
					HistoryManager.SharedInstance.GetCurrentTankData ().tankcapacity_value.SetValueAndUnit(TankCapacityUnit.L,double.Parse(tcEE.Value));
					break;
				}

				trRG.Selected = tcRG.SelectedValue;
				//Root.Reload(remainderS,UITableViewRowAnimation.Fade);
			};

			tcRGRoot.Add (tcRGRootSection);
			capacityS.Add (tcEE);
			capacityS.Add (tcRGRoot);

			// Tank Remainder 
			remainderS = new Section ();

			trEE = new EntryElement ("Tank Remainder at Fill", "Value","0");
			trEE.TextAlignment = UITextAlignment.Right;
			trEE.KeyboardType = UIKeyboardType.NumberPad;
			trEE.Changed += (object sender, EventArgs e) => {
				HistoryManager.SharedInstance.GetCurrentTankData ().tankremainder_value.SetValue(double.Parse(trEE.Value));
			};
			trRG = new TankMixRadioGroupElement (-1);
			var trRGRoot = new RootElement ("Tank Remainder Unit", trRG);
			var trRGRootSection = new Section ("Unit Select"){
				new RadioElement ("US gal"),
				new RadioElement("Imp gal"),
				new RadioElement ("L"),
			};
			trRG.ValueSelectedEvent += (object sender, EventArgs e) => {
				switch(trRG.Selected){
				case 0:
					HistoryManager.SharedInstance.GetCurrentTankData ().tankremainder_value.SetValueAndUnit(TankRemainderUnit.Us_gal,double.Parse(trEE.Value));
					break;
				case 1:
					HistoryManager.SharedInstance.GetCurrentTankData ().tankremainder_value.SetValueAndUnit(TankRemainderUnit.Imp_gal,double.Parse(trEE.Value));
					break;
				case 2:
					HistoryManager.SharedInstance.GetCurrentTankData ().tankremainder_value.SetValueAndUnit(TankRemainderUnit.L,double.Parse(trEE.Value));
					break;
				}
				//tcRG.SelectedValue = trRG.SelectedValue;
			};
			trRGRoot.Add (trRGRootSection);
			remainderS.Add (trEE);
			remainderS.Add (trRGRoot);


			Root.Add (capacityS);
			Root.Add (remainderS);
		}

		private void SetDefaultDataAndUnit()
		{
			tcEE.Value = HistoryManager.SharedInstance.GetCurrentTankData ().tankcapacity_value.value.ToString ();
			tcRG.Selected = (int)HistoryManager.SharedInstance.GetCurrentTankData ().tankcapacity_value.unit;

			trEE.Value = HistoryManager.SharedInstance.GetCurrentTankData ().tankremainder_value.value.ToString ();
			trRG.Selected = (int)HistoryManager.SharedInstance.GetCurrentTankData ().tankremainder_value.unit;
		}

		private void SaveValueToCurrentTankData()
		{
			//HistoryManager.SharedInstance.GetCurrentTankData ().tankcapacity_value.value = double.Parse(tcEE.Value);
			//HistoryManager.SharedInstance.GetCurrentTankData ().tankcapacity_value.unit = (TankCapacityUnit)tcRG.Selected;
			switch(tcRG.Selected)
			{
			case 0:
				HistoryManager.SharedInstance.GetCurrentTankData ().tankcapacity_value.SetValueAndUnit(TankCapacityUnit.Us_gal,double.Parse(tcEE.Value));
				break;
			case 1:
				HistoryManager.SharedInstance.GetCurrentTankData ().tankcapacity_value.SetValueAndUnit(TankCapacityUnit.Imp_gal,double.Parse(tcEE.Value));
				break;
			case 2:
				HistoryManager.SharedInstance.GetCurrentTankData ().tankcapacity_value.SetValueAndUnit(TankCapacityUnit.L,double.Parse(tcEE.Value));
				break;
			}

			//HistoryManager.SharedInstance.GetCurrentTankData ().tankremainder_value.value = double.Parse (trEE.Value);
			//HistoryManager.SharedInstance.GetCurrentTankData ().tankremainder_value.unit = (TankRemainderUnit)trRG.Selected;
			switch(trRG.Selected){
			case 0:
				HistoryManager.SharedInstance.GetCurrentTankData ().tankremainder_value.SetValueAndUnit(TankRemainderUnit.Us_gal,double.Parse(trEE.Value));
				break;
			case 1:
				HistoryManager.SharedInstance.GetCurrentTankData ().tankremainder_value.SetValueAndUnit(TankRemainderUnit.Imp_gal,double.Parse(trEE.Value));
				break;
			case 2:
				HistoryManager.SharedInstance.GetCurrentTankData ().tankremainder_value.SetValueAndUnit(TankRemainderUnit.L,double.Parse(trEE.Value));
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
}
