using System;

namespace TankMix_Share
{
	public class Fill
	{
		public double Remainder { set;get; }
		public string Remainder_Unit { set;get;}
		public double AreaTreated { set;get; }
		public string AreaTreated_Unit {set; get; }
		public double AreaRemaning { set;get; }
		public string AreaRemaning_Unit { set;get; }
		public double TankFill {  set;get; }
		public string TankFill_Unit {  set;get; }
		public double Net { set;get;}
		public string Net_Unit { set;get;}
		public double ThisTankArea { set;get; }
		public string ThisTankArea_Unit { set;get; }
		public double Product { set;get; }
		public string Product_Unit { set;get; }
		public double Adjuvant { set;get; }
		public string Adjuvant_Unit { set;get; }
		public bool isActive = false;
		public string Name { set; get;}

		public Fill ()
		{
		}
		// Constructor for first Fill
		public Fill (double r , double tf)
		{
			// Remainder
//			switch(HistoryManager.SharedInstance.GetCurrentTankData().tankremainder_value.unit)
//			{
//			case TankRemainderUnit.Imp_gal:
//				this.Remainder_Unit = "Imp gal";
//				this.Remainder = HistoryManager.SharedInstance.GetCurrentTankData ().tankremainder_value.Imp_gal;
//				break;
//			case TankRemainderUnit.L:
//				this.Remainder_Unit = "L";
//				this.Remainder = HistoryManager.SharedInstance.GetCurrentTankData ().tankremainder_value.L;
//				break;
//			case TankRemainderUnit.Us_gal:
//				this.Remainder_Unit = "Us_gal";
//				this.Remainder = HistoryManager.SharedInstance.GetCurrentTankData ().tankremainder_value.Us_gal;
//				break;
//			}
			this.Remainder = r;
			this.Remainder_Unit = "Us gal";
			// Area Treated 
			switch(HistoryManager.SharedInstance.GetCurrentTankData().totalarea_value.unit)
			{
			case TotalAreaUnit.Acres:
				this.AreaTreated_Unit = "Acres";
				this.AreaTreated = 0;
				break;
			case TotalAreaUnit.Ha:
				this.AreaTreated_Unit = "Ha";
				this.AreaTreated = 0;
				break;
			}

			// Area Remaining
			switch (HistoryManager.SharedInstance.GetCurrentTankData().totalarea_value.unit)
			{
			case TotalAreaUnit.Acres:
				this.AreaRemaning_Unit = "Acres";
				this.AreaRemaning =HistoryManager.SharedInstance.GetCurrentTankData().totalarea_value.Acres;
				break;
			case TotalAreaUnit.Ha:
				this.AreaRemaning_Unit = "Ha";
				this.AreaRemaning = HistoryManager.SharedInstance.GetCurrentTankData().totalarea_value.Ha;
				break;
			}

			//Tank Fill
//			switch(HistoryManager.SharedInstance.GetCurrentTankData().tankcapacity_value.unit)
//			{
//			case TankCapacityUnit.Imp_gal:
//				this.TankFill_Unit = "Imp gal";
//				this.TankFill = HistoryManager.SharedInstance.GetCurrentTankData ().tankcapacity_value.Imp_gal;
//				break;
//			case TankCapacityUnit.L:
//				this.TankFill_Unit = "L";
//				this.TankFill = HistoryManager.SharedInstance.GetCurrentTankData ().tankcapacity_value.L;
//				break;
//			case TankCapacityUnit.Us_gal:
//				this.TankFill_Unit = "Us gal";
//				this.TankFill = HistoryManager.SharedInstance.GetCurrentTankData ().tankcapacity_value.Us_gal;
//				break;
//			}
			this.TankFill = tf;
			this.TankFill_Unit = "Us gal";

			// Net
			switch(HistoryManager.SharedInstance.GetCurrentTankData().tankcapacity_value.unit)
			{
			case TankCapacityUnit.Imp_gal:
				this.Net = HistoryManager.SharedInstance.GetCurrentTankData ().tankcapacity_value.Imp_gal - HistoryManager.SharedInstance.GetCurrentTankData ().tankremainder_value.Imp_gal;
				this.Net_Unit = "Imp gal";
				break;
			case TankCapacityUnit.L:
				this.Net = HistoryManager.SharedInstance.GetCurrentTankData ().tankcapacity_value.L - HistoryManager.SharedInstance.GetCurrentTankData ().tankremainder_value.L;
				this.Net_Unit = "L";
				break;
			case TankCapacityUnit.Us_gal:
				this.Net = HistoryManager.SharedInstance.GetCurrentTankData ().tankcapacity_value.Us_gal - HistoryManager.SharedInstance.GetCurrentTankData ().tankremainder_value.Us_gal;
				this.Net_Unit = "Us gal";
				break;
			}

			// This Tank Area (Acres , Us gpa )
			switch(HistoryManager.SharedInstance.GetCurrentTankData().tankcapacity_value.unit)
			{
			case TankCapacityUnit.Imp_gal:
				var Net_Imp_gal = HistoryManager.SharedInstance.GetCurrentTankData ().tankcapacity_value.Imp_gal - HistoryManager.SharedInstance.GetCurrentTankData ().tankremainder_value.Imp_gal;
				this.ThisTankArea = CalculationManager.SharedInstance.Imp_galToUs_gal (Net_Imp_gal) / HistoryManager.SharedInstance.GetCurrentTankData ().applicationvolume_value.Us_gpa;
				break;
			case TankCapacityUnit.L:
				var Net_L = HistoryManager.SharedInstance.GetCurrentTankData ().tankcapacity_value.L - HistoryManager.SharedInstance.GetCurrentTankData ().tankremainder_value.L;
				this.ThisTankArea = CalculationManager.SharedInstance.LToUs_gal (Net_L) - HistoryManager.SharedInstance.GetCurrentTankData ().applicationvolume_value.Us_gpa;
				break;
			case TankCapacityUnit.Us_gal:
				var Net_Us_gal = HistoryManager.SharedInstance.GetCurrentTankData ().tankcapacity_value.Us_gal - HistoryManager.SharedInstance.GetCurrentTankData ().tankremainder_value.Us_gal;
				this.ThisTankArea = Net_Us_gal / HistoryManager.SharedInstance.GetCurrentTankData ().applicationvolume_value.Us_gpa;
				break;
			}
			this.ThisTankArea_Unit = "Acres";

			// Product
			this.Product = this.ThisTankArea * HistoryManager.SharedInstance.GetCurrentTankData ().productrate_value.L_acre;
			this.Product_Unit = "L";

			// Adjuvant
			this.Adjuvant = this.ThisTankArea * HistoryManager.SharedInstance.GetCurrentTankData ().adjuvantrate_value.Quart_acre;
			this.Adjuvant_Unit = "Quarts";

			isActive = true;
				
		}
		
			
		// Constructor for non-first Fill
		public Fill (Fill prev, double r, double tf)
		{
			//Remainder User input
			this.Remainder_Unit = prev.Remainder_Unit;
			this.Remainder = r;

			// Area Treated
			this.AreaTreated_Unit = prev.AreaTreated_Unit;
			this.AreaTreated = prev.AreaTreated + (prev.TankFill - this.Remainder) / HistoryManager.SharedInstance.GetCurrentTankData ().applicationvolume_value.Us_gpa;

			// Area Remaning
			this.AreaRemaning_Unit = prev.AreaRemaning_Unit;
			this.AreaRemaning = HistoryManager.SharedInstance.GetCurrentTankData ().totalarea_value.Acres - this.AreaTreated;

			// Tank Fill
			this.TankFill = tf;
			this.TankFill_Unit = "US gal";

			//Net
			this.Net_Unit = "US gal";
			this.Net = this.TankFill - this.Remainder;

			//This Tank Area
			this.ThisTankArea = this.Net / HistoryManager.SharedInstance.GetCurrentTankData ().applicationvolume_value.Us_gpa;
			this.ThisTankArea_Unit = prev.ThisTankArea_Unit;

			//Product
			this.Product_Unit = prev.Product_Unit;
			this.Product = ThisTankArea * HistoryManager.SharedInstance.GetCurrentTankData ().productrate_value.L_acre;

			//Adjuvant
			this.Adjuvant_Unit = prev.Adjuvant_Unit;
			this.Adjuvant = ThisTankArea * HistoryManager.SharedInstance.GetCurrentTankData ().adjuvantrate_value.Quart_acre;

		}	
				
	}
}

