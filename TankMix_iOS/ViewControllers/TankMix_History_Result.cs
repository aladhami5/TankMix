using System;
using System.Collections.Generic;
using System.Linq;
using MonoTouch.Foundation;
using MonoTouch.UIKit;
using MonoTouch.Dialog;
using TankMix_Share;

namespace TankMix_iOS
{
	public partial class TankMix_History_Result : DialogViewController
	{
		// application volume
		EntryElement ApplicationVolume;
		// product rate
		EntryElement ProductRate;
		// adjuvant rate
		EntryElement AdjuvantRate;
		// tank capacity
		EntryElement TankCapacity;
		// tank remainder at fill
		EntryElement TankRemainder;
		// sump capacity
		EntryElement SumpCapacity;
		// field area
		EntryElement FieldArea;
		// Boom width
		EntryElement BoomWidth;
		// field length
		EntryElement FieldLength;
		// total number of headland swaths
		EntryElement TotalNumberHeadland;
		// area treated by Tank
		EntryElement AreaTreatedByTank;
		// product amount
		EntryElement ProductAmount;
		// adjuvant amount
		EntryElement AdjuvantAmount;
		// total water
		EntryElement TotalWater;
		// numebr of tanks need
		EntryElement NumOfTanksNeed;
		// number of fills
		// area per round
		// rounds per tank
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
			Root = new RootElement ("Result Detail");

			ApplicationVolume = new EntryElement ("Application Value",string.Empty,R.TankInput.applicationvolume_value.value +" "+ R.TankInput.applicationvolume_value.unit);
			ProductRate = new EntryElement ("Product Rate",string.Empty,R.TankInput.productrate_value.value +" "+R.TankInput.productrate_value.unit);
			AdjuvantRate = new EntryElement ("Adjuvant Rate",string.Empty,R.TankInput.adjuvantrate_value.value + " "+ R.TankInput.adjuvantrate_value.unit);
			TankCapacity = new EntryElement ("Tank Capacity", string.Empty, R.TankInput.tankcapacity_value.value +" "+R.TankInput.tankcapacity_value.unit);
			TankRemainder = new EntryElement ("Tank Remainder at Fill",string.Empty,R.TankInput.tankremainder_value.value +" "+R.TankInput.tankremainder_value.unit);
			SumpCapacity = new EntryElement ("Sump Capacity",string.Empty,R.TankInput.sumpcapacity_value.value+" "+R.TankInput.sumpcapacity_value.unit);
			FieldArea = new EntryElement ("Field Area",string.Empty,R.TankInput.totalarea_value.value +" "+R.TankInput.totalarea_value.unit);
			BoomWidth = new EntryElement ("Boom Width",string.Empty,R.TankInput.boomwidth_value.value+" "+R.TankInput.boomwidth_value.unit);
			TotalNumberHeadland = new EntryElement ("Total Number of Headland Swaths",string.Empty,R.TankInput.number_headlands_swaths_value);
			AreaTreatedByTank = new EntryElement ("Area Treated by Tank",string.Empty,R.areatreatedbytank_value.value + " "+R.areatreatedbytank_value.unit);
			ProductAmount = new EntryElement ("Product Amount",string.Empty,R.productamount_value.value +" "+ R.productamount_value.unit);
			AdjuvantAmount = new EntryElement ("Adjuvant Amount",string.Empty,R.adjuvantamount_value.value +" "+R.adjuvantamount_value.unit);
			TotalWater = new EntryElement ("Total Water",string.Empty,R.totalwater_value.value +" "+R.totalwater_value.unit);
			NumOfTanksNeed = new EntryElement ("Number of Tanks Need",string.Empty, R.numberOfTanksNeeded);
		}
	}
}


















