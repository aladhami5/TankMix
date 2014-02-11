using System;

namespace TankMix_Share
{
	public enum BoomWidthUnit
	{
		M,
		Ft,
	}
	public class BoomWidth
	{

		public double M { set; get; }
		public double Ft { set; get; }
		public double value{ set; get;}
		public BoomWidthUnit unit { set; get; }

		public BoomWidth (){}

		public void SetValue (double input)
		{
			this.value = input;
		}
		public void SetValueAndUnit(BoomWidthUnit u, double input)
		{
			this.value = input;
			switch(u)
			{
			case BoomWidthUnit.M:
				this.unit = BoomWidthUnit.M;
				M = input;
				Ft = CalculationManager.SharedInstance.MToFt (input);
				break;
			case BoomWidthUnit.Ft:
				this.unit = BoomWidthUnit.Ft;
				Ft = input;
				M = CalculationManager.SharedInstance.FtToM (input);
				break;
			}
		}
	}
}

