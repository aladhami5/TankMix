using System;

namespace TankMix_Share
{
	public enum TotalWaterUnit
	{
		Us_gal,
		Imp_gal,
		L,
	}
	public class TotalWater
	{
		public double Us_gal{ set; get; }
		public double Imp_gal{ set; get; }
		public double L { set; get; }
		public double value { set; get; }
		public TotalWaterUnit unit{ set; get; }

		public TotalWater ()
		{
		}

		public void SetValueAndUnit (TotalWaterUnit u, double input)
		{
			this.value = input;
			switch(u)
			{
			case TotalWaterUnit.Imp_gal:
				this.unit = u;
				Imp_gal = input;
				Us_gal = CalculationManager.SharedInstance.Imp_galToUs_gal (input);
				L = CalculationManager.SharedInstance.Imp_galToL (input);
				break;
			case TotalWaterUnit.L:
				this.unit = u;
				L = input;
				Us_gal = CalculationManager.SharedInstance.LToUs_gal (input);
				Imp_gal = CalculationManager.SharedInstance.LToImp_gal (input);
				break;
			case TotalWaterUnit.Us_gal:
				this.unit = u;
				Us_gal = input;
				L = CalculationManager.SharedInstance.Us_galToL (input);
				Imp_gal = CalculationManager.SharedInstance.Us_galToImp_gal (input);
				break;

			}
		}
	}
}

