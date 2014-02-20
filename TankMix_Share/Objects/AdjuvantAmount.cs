using System;

namespace TankMix_Share
{
	public enum AdjuvantAmountUnit
	{
		L,
		Ml,
		Us_fl_oz,
		Us_quart,
	}

	public class AdjuvantAmount
	{
		public double L { set; get;}
		public double Ml { set; get;}
		public double Us_fl_oz { set; get;}
		public double Us_quart { set; get;}

		public double value{ set; get;}
		public AdjuvantAmountUnit unit;
			
		public AdjuvantAmount ()
		{
		}

		public void SetValueAndUnit (AdjuvantAmountUnit u, double input)
		{
			this.value = input;
			switch(u)
			{
			case AdjuvantAmountUnit.L:
				this.unit = u;
				L = input;
				Ml = CalculationManager.SharedInstance.LToMl (input);
				Us_fl_oz = CalculationManager.SharedInstance.LToUs_fl_oz (input);
				Us_quart = CalculationManager.SharedInstance.L_acreToUs_quart_acre(input);
				break;
			case AdjuvantAmountUnit.Ml:
				Ml = input;
				this.unit = u;
				L = CalculationManager.SharedInstance.MlToL (input);
				Us_fl_oz = CalculationManager.SharedInstance.MlToUs_fl_oz (input);
				Us_quart = CalculationManager.SharedInstance.Ml_acreToUs_fl_oz_acre (input);
				break;
			case AdjuvantAmountUnit.Us_fl_oz:
				this.unit = u;
				Us_fl_oz = input;
				L = CalculationManager.SharedInstance.Us_fl_ozToL (input);
				Ml = CalculationManager.SharedInstance.Us_fl_ozToMl (input);
				Us_quart = CalculationManager.SharedInstance.Us_fl_oz_acreToUs_quart_acre (input);
				break;
			case AdjuvantAmountUnit.Us_quart:
				this.unit = u;
				Us_quart = input;
				L = CalculationManager.SharedInstance.Us_quarttToL (input);
				Ml = CalculationManager.SharedInstance.Us_quart_acreToMl_acre (input);
				Us_fl_oz = CalculationManager.SharedInstance.Us_quart_acreToUs_fl_oz_acre (input);
				break;
			}
		}

	}
}

