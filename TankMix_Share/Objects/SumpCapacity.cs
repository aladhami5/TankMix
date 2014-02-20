using System;

namespace TankMix_Share
{
	public enum SunpCapacityUnit
	{
		Us_gal,
		Imp_gal,
		L,
	}
	public class SumpCapacity
	{
		public double Us_gal{ set; get;}
		public double Imp_gal { set; get; }
		public double L { set; get; }

		public double value { set; get; }
		public SunpCapacityUnit unit { set; get; }

		public SumpCapacity (){}

		public void SetValue(double input)
		{
			this.value = input;
		}

		public void SetValueAndUnit (SunpCapacityUnit u, double input)
		{
			this.value = input;
			switch(u)
			{
			case SunpCapacityUnit.Us_gal:
				this.unit = u;
				Us_gal = input;
				Imp_gal = CalculationManager.SharedInstance.Us_galToImp_gal (input);
				L = CalculationManager.SharedInstance.Us_galToL (input);
				break;
			case SunpCapacityUnit.Imp_gal:
				this.unit = u;
				Imp_gal = input;
				L = CalculationManager.SharedInstance.Imp_galToL (input);
				Us_gal = CalculationManager.SharedInstance.Imp_galToUs_gal (input);
				break;
			case SunpCapacityUnit.L:
				this.unit = u;
				L = input;
				Us_gal = CalculationManager.SharedInstance.LToUs_gal (input);
				Imp_gal = CalculationManager.SharedInstance.LToImp_gal (input);
				break;
			}
		}
	}
}

