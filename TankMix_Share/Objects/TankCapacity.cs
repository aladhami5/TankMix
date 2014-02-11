using System;

namespace TankMix_Share
{
	public enum TankCapacityUnit
	{
		Us_gal,
		Imp_gal,
		L,
	}
	public class TankCapacity
	{

		public double Us_gal{ set; get;}
		public double Imp_gal { set; get; }
		public double L { set; get; }

		public double value { set; get; }
		public TankCapacityUnit unit { set; get; }

		public TankCapacity (){}

		public void SetValueAndUnit (TankCapacityUnit u, double input)
		{
			this.value = input;
			switch(u)
			{
			case TankCapacityUnit.Us_gal:
				this.unit = TankCapacityUnit.Us_gal;
				Us_gal = input;
				Imp_gal = CalculationManager.SharedInstance.Us_galToImp_gal (input);
				L = CalculationManager.SharedInstance.Us_galToL (input);
				break;
			case TankCapacityUnit.Imp_gal:
				this.unit = TankCapacityUnit.Imp_gal;
				Imp_gal = input;
				L = CalculationManager.SharedInstance.Imp_galToL (input);
				Us_gal = CalculationManager.SharedInstance.Imp_galToUs_gal (input);
				break;
			case TankCapacityUnit.L:
				this.unit = TankCapacityUnit.L;
				L = input;
				Us_gal = CalculationManager.SharedInstance.LToUs_gal (input);
				Imp_gal = CalculationManager.SharedInstance.LToImp_gal (input);
				break;
			}
		}
		public void SetValue(double input)
		{
			this.value = input;
		}
	}
}

