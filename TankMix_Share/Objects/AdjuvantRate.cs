using System;

namespace TankMix_Share
{
	public enum AdjuvantRateUnit
	{
		V_v,
		L_acre,
		Ml_acre,
		Us_fl_oz_acre,
		Quart_acre,
	}

	public class AdjuvantRate
	{
		public double V_v{ set; get; }
		public double L_acre { set; get; }
		public double Ml_acre { set; get; }
		public double Us_fl_oz_acre { set; get; }
		public double Quart_acre { set; get; }

		public double value;
		public AdjuvantRateUnit unit;

		public AdjuvantRate (){}

		public void SetValue(double input)
		{
			this.value = input;
		}

		public void SetValueAndUnit (AdjuvantRateUnit u, double input)
		{
			this.value = input;
			switch(u)
			{
			case AdjuvantRateUnit.V_v:
				this.unit = AdjuvantRateUnit.V_v;
				V_v = input;
				break;
			case AdjuvantRateUnit.L_acre:
				this.unit = AdjuvantRateUnit.L_acre;
				V_v = 0.0;
				L_acre = input;
				Ml_acre = CalculationManager.SharedInstance.L_acreToMl_acre (input);
				Us_fl_oz_acre = CalculationManager.SharedInstance.L_acreToUs_fl_oz_acre (input);
				Quart_acre = CalculationManager.SharedInstance.L_acreToUs_quart_acre (input);
				break;
			case AdjuvantRateUnit.Ml_acre:
				this.unit = AdjuvantRateUnit.Ml_acre;
				V_v = 0.0;
				Ml_acre = input;
				L_acre = CalculationManager.SharedInstance.Ml_acreToL_acre (input);
				Us_fl_oz_acre = CalculationManager.SharedInstance.Ml_acreToUs_fl_oz_acre (input);
				Quart_acre = CalculationManager.SharedInstance.Ml_acreToUs_quart_acre (input);
				break;
			case AdjuvantRateUnit.Us_fl_oz_acre:
				this.unit = AdjuvantRateUnit.Us_fl_oz_acre;
				V_v = 0.0;
				Us_fl_oz_acre = input;
				L_acre = CalculationManager.SharedInstance.Us_fl_oz_acreToL_acre (input);
				Ml_acre = CalculationManager.SharedInstance.Us_fl_oz_acreToMl_acre (input);
				Quart_acre = CalculationManager.SharedInstance.Us_fl_oz_acreToUs_quart_acre (input);
				break;
			case AdjuvantRateUnit.Quart_acre:
				this.unit = AdjuvantRateUnit.Quart_acre;
				Quart_acre = input;
				L_acre = CalculationManager.SharedInstance.Us_quart_acreToL_acre (input);
				Ml_acre = CalculationManager.SharedInstance.Us_quart_acreToMl_acre (input);
				Us_fl_oz_acre = CalculationManager.SharedInstance.Us_quart_acreToUs_fl_oz_acre (input);

				break;

			}
		}
	}
}

