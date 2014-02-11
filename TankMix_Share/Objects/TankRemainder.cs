using System;

namespace TankMix_Share
{
	public enum TankRemainderUnit
	{
		Us_gal,
		Imp_gal,
		L,
	}
	public class TankRemainder
	{
		public double Us_gal{ set; get;}
		public double Imp_gal { set; get; }
		public double L { set; get; }

		public double value { set; get; }
		public TankRemainderUnit unit { set; get;}

		public TankRemainder (){}

		public void SetValueAndUnit (TankRemainderUnit u, double input)
		{
			this.value = input;
			switch(u)
			{
			case TankRemainderUnit.Us_gal:
				this.unit = TankRemainderUnit.Us_gal;
				Us_gal = input;
				Imp_gal = CalculationManager.SharedInstance.Us_galToImp_gal (input);
				L = CalculationManager.SharedInstance.Us_galToL (input);
				break;
			case TankRemainderUnit.Imp_gal:
				this.unit = TankRemainderUnit.Imp_gal;
				Imp_gal = input;
				L = CalculationManager.SharedInstance.Imp_galToL (input);
				Us_gal = CalculationManager.SharedInstance.Imp_galToUs_gal (input);
				break;
			case TankRemainderUnit.L:
				this.unit = TankRemainderUnit.L;
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

