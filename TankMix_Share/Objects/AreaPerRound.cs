using System;

namespace TankMix_Share
{
	public enum AreaPerRoundUnit 
	{
		Acres,
		Ha,
	}
	public class AreaPerRound
	{

		public double Acres { set; get; }
		public double Ha { set; get; }
		public double value { set; get; }
		public AreaPerRoundUnit unit { set; get; }


		public AreaPerRound ()
		{
		}

		public void SetValueAndUnit(AreaPerRoundUnit u, double input)
		{
			this.value = input;
			switch(u)
			{
			case AreaPerRoundUnit.Acres:

				this.unit = u;
				Acres = input;
				Ha = CalculationManager.SharedInstance.AcresToHa (input);
				break;
			case AreaPerRoundUnit.Ha:
				this.unit = u;
				Ha = input;
				Acres = CalculationManager.SharedInstance.HaToAcres (input);
				break;
			}
		}
	}
}

