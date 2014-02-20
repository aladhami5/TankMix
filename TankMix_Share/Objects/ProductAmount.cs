using System;

namespace TankMix_Share
{
	public enum ProductAmountUnit
	{
		Case,
		L,
		Ml,
		G,
		Us_fl_oz,
		Oz,
	}
	public class ProductAmount
	{

		public double Case { set; get;}
		public double L { set; get;}
		public double Ml { set; get;}
		public double G { set; get;}
		public double Us_fl_oz { set; get;}
		public double Oz { set; get;}

		public double value { set; get;}
		public ProductAmountUnit unit { set; get;}

		public ProductAmount (){}

		public void SetValue (double input) 
		{
			this.value = input;
		}

		public void SetValueAndUnit(ProductAmountUnit u, double input)
		{
			this.value = input;
			switch(u)
			{
			case ProductAmountUnit.Case:
				this.unit = u;
				Case = input;
				L = CalculationManager.SharedInstance.CasesToL (input);
				Ml = CalculationManager.SharedInstance.CasesToMl (input);
				G = CalculationManager.SharedInstance.CasesToG (input);
				Us_fl_oz = CalculationManager.SharedInstance.CasesToUs_fl_oz (input);
				Oz = CalculationManager.SharedInstance.CasesToOz (input);
				break;

			case ProductAmountUnit.G:
				this.unit = u;
				G = input;
				Case = CalculationManager.SharedInstance.GToCases (input);
				L = CalculationManager.SharedInstance.GToL (input);
				Ml = CalculationManager.SharedInstance.GToMl (input);
				Us_fl_oz = CalculationManager.SharedInstance.GToUs_fl_oz (input);
				Oz = CalculationManager.SharedInstance.GToOz (input);
				break;
			case ProductAmountUnit.L:
				this.unit = u;
				L = input;
				Case = CalculationManager.SharedInstance.LToCases (input);
				G = CalculationManager.SharedInstance.LToG (input);
				Ml = CalculationManager.SharedInstance.LToMl (input);
				Oz = CalculationManager.SharedInstance.LToOz (input);
				Us_fl_oz = CalculationManager.SharedInstance.LToUs_fl_oz (input);
				break;
			case ProductAmountUnit.Ml:
				this.unit = u;
				Ml = input;
				Case = CalculationManager.SharedInstance.MlToCases (input);
				G = CalculationManager.SharedInstance.MlToG (input);
				L = CalculationManager.SharedInstance.MlToL (input);
				Oz = CalculationManager.SharedInstance.MlToOz (input);
				Us_fl_oz = CalculationManager.SharedInstance.MlToUs_fl_oz (input);
				break;
			case ProductAmountUnit.Oz:
				this.unit = u;
				Oz = input;
				Case = CalculationManager.SharedInstance.OzToCases (input);
				G = CalculationManager.SharedInstance.OzToG (input);
				L = CalculationManager.SharedInstance.OzToL (input);
				Ml = CalculationManager.SharedInstance.OzToMl (input);
				Us_fl_oz = CalculationManager.SharedInstance.OzToUs_fl_oz (input);
				break;
			case ProductAmountUnit.Us_fl_oz:
				this.unit = u;
				Us_fl_oz = input;
				Case = CalculationManager.SharedInstance.Us_fl_ozToCases (input);
				G = CalculationManager.SharedInstance.Us_fl_ozToG (input);
				L = CalculationManager.SharedInstance.Us_fl_ozToL (input);
				Ml = CalculationManager.SharedInstance.Us_fl_ozToMl (input);
				Oz = CalculationManager.SharedInstance.Us_fl_ozToOz (input);
				break;
			}
		}
	}

}

