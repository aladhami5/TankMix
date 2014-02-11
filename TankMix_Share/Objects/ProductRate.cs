using System;

namespace TankMix_Share
{
	public enum ProductRateUnit
	{
		Acres_case,
		L_acre,
		G_acre,
		Ml_acre,
		Us_fl_oz_acre,
		Us_pint_acre,
		Us_quart_acre,
		Oz_acre,
		L_ha,
		G_ha,
		Ml_ha,
	}

	public class ProductRate
	{
		public double Acres_case{ set; get; }
		public double L_acre{ set; get; }
		public double G_acre{ set; get; }
		public double Ml_acre{ set; get; }
		public double Us_fl_oz_acre { set; get; }
		public double Us_pint_acre { set; get; }
		public double Us_quart_acre{ set; get; }
		public double Oz_acre { set; get; }
		public double L_ha { set; get; }
		public double G_ha { set; get; }
		public double Ml_ha { set; get; }


		public double value { get; set;}
		public ProductRateUnit unit{ get; set;}

		public ProductRate ()
		{

		}

		public void SetValue(double input)
		{
			this.value = input;
		}

		public void SetValueAndUnit (ProductRateUnit unit, double input)
		{
			value = input;
			switch (unit) {
			case ProductRateUnit.Acres_case: 
				this.unit = ProductRateUnit.Acres_case;
				Acres_case = input;
				//CalculationManager.SharedInstance.Acres_ca
				break;
			case ProductRateUnit.G_acre:
				this.unit = ProductRateUnit.G_acre;
				Acres_case = 0.0;
				G_acre = input;
				L_acre = CalculationManager.SharedInstance.G_acreToL_acre (input);
				Ml_acre = CalculationManager.SharedInstance.G_acreToMl_acre (input);
				Us_fl_oz_acre = CalculationManager.SharedInstance.G_acreToUs_fl_oz_acre (input);
				Us_pint_acre = CalculationManager.SharedInstance.G_acreToUs_pint_acre (input);
				Us_quart_acre = CalculationManager.SharedInstance.G_acreToUs_quart_acre (input);
				Oz_acre = CalculationManager.SharedInstance.G_acreToOz_acre (input);
				L_ha = CalculationManager.SharedInstance.G_acreToL_ha (input);
				G_ha = CalculationManager.SharedInstance.G_acreToG_ha (input);
				Ml_ha = CalculationManager.SharedInstance.G_acreToMl_ha (input);
				break;
			case ProductRateUnit.G_ha:
				this.unit = ProductRateUnit.G_ha;
				Acres_case = 0.0;
				G_ha = input;
				L_acre = CalculationManager.SharedInstance.G_haToL_acre (input);
				Ml_acre = CalculationManager.SharedInstance.G_haToMl_acre (input);
				Us_fl_oz_acre = CalculationManager.SharedInstance.G_haToUs_fl_oz_acre (input);
				Us_pint_acre = CalculationManager.SharedInstance.G_haToUs_pint_acre (input);
				Us_quart_acre = CalculationManager.SharedInstance.G_haToUs_quart_acre (input);
				Oz_acre = CalculationManager.SharedInstance.G_haToOz_acre (input);
				L_ha = CalculationManager.SharedInstance.G_haToL_ha (input);
				Ml_ha = CalculationManager.SharedInstance.G_haToMl_ha (input);
				G_acre = CalculationManager.SharedInstance.G_haToG_acre (input);
				break;
			case ProductRateUnit.L_acre:
				this.unit = ProductRateUnit.L_acre;
				Acres_case = 0.0;
				L_acre = input;
				Ml_acre = CalculationManager.SharedInstance.L_acreToMl_acre (input);
				Us_fl_oz_acre = CalculationManager.SharedInstance.L_acreToUs_fl_oz_acre (input);
				Us_pint_acre = CalculationManager.SharedInstance.L_acreToUs_pint_acre (input);
				Us_quart_acre = CalculationManager.SharedInstance.L_acreToUs_quart_acre (input);
				Oz_acre = CalculationManager.SharedInstance.L_acreToOz_acre (input);
				L_ha = CalculationManager.SharedInstance.L_acreToL_ha (input);
				G_ha = CalculationManager.SharedInstance.L_acreToG_ha (input);
				Ml_ha = CalculationManager.SharedInstance.L_acreToMl_ha (input);
				G_acre = CalculationManager.SharedInstance.L_acreToG_acre (input);
				break;
			case ProductRateUnit.L_ha:
				this.unit = ProductRateUnit.L_ha;
				Acres_case = 0.0;
				L_ha = input;
				Ml_acre = CalculationManager.SharedInstance.L_haToMl_acre (input);
				Us_fl_oz_acre = CalculationManager.SharedInstance.L_haToUs_fl_oz_acre (input);
				Us_pint_acre = CalculationManager.SharedInstance.L_haToUs_pint_acre (input);
				Us_quart_acre = CalculationManager.SharedInstance.L_haToUs_quart_acre (input);
				Oz_acre = CalculationManager.SharedInstance.L_haToOz_acre (input);
				G_ha = CalculationManager.SharedInstance.L_haToG_ha (input);
				Ml_ha = CalculationManager.SharedInstance.L_haToMl_ha (input);
				G_acre = CalculationManager.SharedInstance.L_haToG_acre (input);
				L_acre = CalculationManager.SharedInstance.L_haToL_acre (input);
				break;
			case ProductRateUnit.Ml_acre:
				this.unit = ProductRateUnit.Ml_acre;
				Acres_case = 0.0;
				Ml_acre = input;
				Us_fl_oz_acre = CalculationManager.SharedInstance.Ml_acreToUs_fl_oz_acre (input);
				Us_pint_acre = CalculationManager.SharedInstance.Ml_acreToUs_pint_acre (input);
				Us_quart_acre = CalculationManager.SharedInstance.Ml_acreToUs_pint_acre (input);
				Oz_acre = CalculationManager.SharedInstance.Ml_acreToOz_acre (input);
				G_ha = CalculationManager.SharedInstance.Ml_acreToG_ha (input);
				Ml_ha = CalculationManager.SharedInstance.Ml_acreToMl_ha (input);
				G_acre = CalculationManager.SharedInstance.Ml_acreToG_acre (input);
				L_acre = CalculationManager.SharedInstance.Ml_acreToL_acre (input);
				L_ha = CalculationManager.SharedInstance.Ml_acreToL_ha (input);
				break;
			case ProductRateUnit.Ml_ha:
				this.unit = ProductRateUnit.Ml_ha;
				Acres_case = 0.0;
				Ml_ha = input;
				Us_fl_oz_acre = CalculationManager.SharedInstance.Ml_haToUs_fl_oz_acre (input);
				Us_pint_acre = CalculationManager.SharedInstance.Ml_haToUs_pint_acre (input);
				Us_quart_acre = CalculationManager.SharedInstance.Ml_haToUs_quart_acre (input);
				Oz_acre = CalculationManager.SharedInstance.Ml_haToOz_acre (input);
				G_ha = CalculationManager.SharedInstance.Ml_haToG_ha (input);
				G_acre = CalculationManager.SharedInstance.Ml_haToG_acre (input);
				L_acre = CalculationManager.SharedInstance.Ml_haToL_acre (input);
				L_ha = CalculationManager.SharedInstance.Ml_haToL_ha (input);
				Ml_acre = CalculationManager.SharedInstance.Ml_haToMl_acre (input);
				break;
			case ProductRateUnit.Oz_acre:
				this.unit = ProductRateUnit.Oz_acre;
				Acres_case = 0.0;
				Oz_acre = input;
				Us_fl_oz_acre = CalculationManager.SharedInstance.Oz_acreToUs_fl_oz_acre (input);
				Us_pint_acre = CalculationManager.SharedInstance.Oz_acreToUs_pint_acre (input);
				Us_quart_acre = CalculationManager.SharedInstance.Oz_acreToUs_quart_acre (input);
				G_ha = CalculationManager.SharedInstance.Oz_acreToG_ha (input);
				G_acre = CalculationManager.SharedInstance.Oz_acreToG_acre (input);
				L_acre = CalculationManager.SharedInstance.Oz_acreToL_acre (input);
				L_ha = CalculationManager.SharedInstance.Oz_acreToL_ha (input);
				Ml_acre = CalculationManager.SharedInstance.Oz_acreToMl_acre (input);
				Ml_ha = CalculationManager.SharedInstance.Oz_acreToMl_ha (input);
				break;
			case ProductRateUnit.Us_fl_oz_acre:
				this.unit = ProductRateUnit.Us_fl_oz_acre;
				Acres_case = 0.0;
				Us_fl_oz_acre = input;
				Us_pint_acre = CalculationManager.SharedInstance.Us_fl_oz_acreToUs_pint_acre (input);
				Us_quart_acre = CalculationManager.SharedInstance.Us_fl_oz_acreToUs_quart_acre (input);
				G_ha = CalculationManager.SharedInstance.Us_fl_oz_acreToG_ha (input);
				G_acre = CalculationManager.SharedInstance.Us_fl_oz_acreToG_acre (input);
				L_acre = CalculationManager.SharedInstance.Us_fl_oz_acreToL_acre (input);
				L_ha = CalculationManager.SharedInstance.Us_fl_oz_acreToL_ha (input);
				Ml_acre = CalculationManager.SharedInstance.Us_fl_oz_acreToMl_acre (input);
				Ml_ha = CalculationManager.SharedInstance.Us_fl_oz_acreToMl_ha (input);
				Oz_acre = CalculationManager.SharedInstance.Us_fl_oz_acreToOz_acre (input);
				break;
			case ProductRateUnit.Us_pint_acre:
				this.unit = ProductRateUnit.Us_pint_acre;
				Acres_case = 0.0;
				Us_pint_acre = input;
				Us_quart_acre = CalculationManager.SharedInstance.Us_pint_acreToUs_quart_acre (input);
				G_ha = CalculationManager.SharedInstance.Us_pint_acreToG_ha (input);
				G_acre = CalculationManager.SharedInstance.Us_pint_acreToG_acre (input);
				L_acre = CalculationManager.SharedInstance.Us_pint_acreToL_acre (input);
				L_ha = CalculationManager.SharedInstance.Us_pint_acreToL_ha (input);
				Ml_acre = CalculationManager.SharedInstance.Us_pint_acreToMl_acre (input);
				Ml_ha = CalculationManager.SharedInstance.Us_pint_acreToMl_ha (input);
				Oz_acre = CalculationManager.SharedInstance.Us_pint_acreToOz_acre (input);
				Us_fl_oz_acre = CalculationManager.SharedInstance.Us_pint_acreToUs_fl_oz_acre (input);
				break;
			case ProductRateUnit.Us_quart_acre:
				this.unit = ProductRateUnit.Us_quart_acre;
				Acres_case = 0.0;
				Us_quart_acre = input;
				G_ha = CalculationManager.SharedInstance.Us_quart_acreToG_ha (input);
				G_acre = CalculationManager.SharedInstance.Us_quart_acreToG_acre (input);
				L_acre = CalculationManager.SharedInstance.Us_quart_acreToL_acre (input);
				L_ha = CalculationManager.SharedInstance.Us_quart_acreToL_ha (input);
				Ml_acre = CalculationManager.SharedInstance.Us_quart_acreToMl_acre (input);
				Ml_ha = CalculationManager.SharedInstance.Us_quart_acreToMl_ha (input);
				Oz_acre = CalculationManager.SharedInstance.Us_quart_acreToOz_acre (input);
				Us_fl_oz_acre = CalculationManager.SharedInstance.Us_quart_acreToUs_fl_oz_acre (input);
				Us_pint_acre = CalculationManager.SharedInstance.Us_quart_acreToUs_pint_acre (input);
				break;

			}

		}

	}
}

