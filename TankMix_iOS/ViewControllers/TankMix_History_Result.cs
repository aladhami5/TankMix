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
	public partial class TankMix_History_Result : DialogViewController
	{
		UIView DismissKeyBoardView;
		// application volume
		StringElement ApplicationVolume;
		// product rate
		StringElement ProductRate;
		// adjuvant rate
		StringElement AdjuvantRate;
		// tank capacity
		StringElement TankCapacity;
		// tank remainder at fill
		StringElement TankRemainder;
		// sump capacity
		StringElement SumpCapacity;
		// field area
		StringElement FieldArea;
		// Boom width
		StringElement BoomWidth;
		// field length
		StringElement FieldLength;
		// total number of headland swaths
		StringElement TotalNumberHeadland;
		// area treated by Tank
		StringElement AreaTreatedByTank;
		// product amount
		StringElement ProductAmount;
		// adjuvant amount
		StringElement AdjuvantAmount;
		// total water
		StringElement TotalWater;
		// numebr of tanks need
		StringElement NumOfTanksNeed;
		// number of fills
		StringElement NumOfFills;
		// area per round
		StringElement AreaPerRound;
		// rounds per tank
		StringElement RoundsPerTank;
		//
		// FILL
		// Remainder
		// Area treated so far
		// area remaining
		// tank fill
		// net 
		// this tank area
		// product
		// adjuvant
		public TankMix_History_Result (CalculationResult R) : base (UITableViewStyle.Grouped, null)
		{
			this.Pushing = true;
			Root = new RootElement ("Result Detail");

			ApplicationVolume = new StringElement ("Application Value",R.TankInput.applicationvolume_value.value +" "+ R.TankInput.applicationvolume_value.unit);
			ProductRate = new StringElement ("Product Rate",R.TankInput.productrate_value.value +" "+R.TankInput.productrate_value.unit);
			AdjuvantRate = new StringElement ("Adjuvant Rate",R.TankInput.adjuvantrate_value.value + " "+ R.TankInput.adjuvantrate_value.unit);
			TankCapacity = new StringElement ("Tank Capacity",R.TankInput.tankcapacity_value.value +" "+R.TankInput.tankcapacity_value.unit);
			TankRemainder = new StringElement ("Tank Remainder at Fill",R.TankInput.tankremainder_value.value +" "+R.TankInput.tankremainder_value.unit);
			SumpCapacity = new StringElement ("Sump Capacity",R.TankInput.sumpcapacity_value.value+" "+R.TankInput.sumpcapacity_value.unit);
			FieldArea = new StringElement ("Field Area",R.TankInput.totalarea_value.value +" "+R.TankInput.totalarea_value.unit);
			BoomWidth = new StringElement ("Boom Width",R.TankInput.boomwidth_value.value+" "+R.TankInput.boomwidth_value.unit);
			FieldLength = new StringElement ("Field Length",R.TankInput.swathlength_value.value+" "+R.TankInput.swathlength_value.unit);
			TotalNumberHeadland = new StringElement ("Total Number of Headland Swaths",R.TankInput.number_headlands_swaths_value.ToString());
			AreaTreatedByTank = new StringElement ("Area Treated by Tank", string.Format("{0:00.00}",R.areatreatedbytank_value.value) + " " + R.areatreatedbytank_value.unit);
			ProductAmount = new StringElement ("Product Amount",string.Format("{0:00.00}",R.productamount_value.value) +" "+ R.productamount_value.unit);
			AdjuvantAmount = new StringElement ("Adjuvant Amount",string.Format("{0:00.00}",R.adjuvantamount_value.value) +" "+R.adjuvantamount_value.unit);
			TotalWater = new StringElement ("Total Water",R.totalwater_value.value +" "+R.totalwater_value.unit);
			NumOfTanksNeed = new StringElement ("Number of Tanks Need", string.Format("{0:00.00}",R.numberOfTanksNeeded));
			NumOfFills = new StringElement ("Number of Fills",Convert.ToInt32(R.numberOfFills).ToString());
			AreaPerRound = new StringElement ("Area per Round",string.Format("{0:00.00}",R.areaperround_value.value)+" "+R.areaperround_value.unit);
			RoundsPerTank = new StringElement ("Rounds Per Tank",string.Format("{0:00.00}",R.roundpertank));

			var Section = new Section ();
			Section.Add (ApplicationVolume);
			Section.Add (ProductRate);
			Section.Add (AdjuvantRate);
			Section.Add (TankCapacity);
			Section.Add (TankRemainder);
			Section.Add (SumpCapacity);
			Section.Add (FieldArea);
			Section.Add (BoomWidth);
			Section.Add (FieldLength);
			Section.Add (FieldLength);
			Section.Add (TotalNumberHeadland);
			Section.Add (AreaTreatedByTank);
			Section.Add (ProductAmount);
			Section.Add (AdjuvantAmount);
			Section.Add (TotalWater);
			Section.Add (NumOfTanksNeed);
			Section.Add (NumOfFills);
			Section.Add (AreaPerRound);
			Section.Add (RoundsPerTank);

			Root.Add (Section);

			var FillBtn = new UIBarButtonItem ();
			FillBtn.Title = "Fills";
			FillBtn.Clicked += (object sender, EventArgs e) => {

				if(R.numberOfFills == 0){

				}else{
					this.NavigationController.PushViewController(new TankMix_History_Fill(R.fills,int.Parse(R.numberOfFills.ToString())),true);
				}
			};
			this.NavigationItem.RightBarButtonItem = FillBtn;
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


















