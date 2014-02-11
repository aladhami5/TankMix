using System;

namespace TankMix_Share
{
	public enum TotalAreaUnit
	{
		Acres,
		Ha,
	}
	public class TotalArea
	{
		public double Acres { set; get; }
		public double Ha { set; get; }
		public double value { set; get; }
		public TotalAreaUnit unit{ set; get; }

		public TotalArea (){}

		public void SetValue (double input)
		{
			this.value = input;
		}

		public void SetValueAndUnit(TotalAreaUnit u, double input)
		{
			this.value = input;
			switch(u)
			{
			case TotalAreaUnit.Acres:
				this.unit = TotalAreaUnit.Acres;
				Acres = input;
				Ha = CalculationManager.SharedInstance.AcresToHa (input);
				break;
			case TotalAreaUnit.Ha:
				this.unit = TotalAreaUnit.Ha;
				Ha = input;
				Acres = CalculationManager.SharedInstance.HaToAcres (input);
				break;
			}
		}
	}
}

