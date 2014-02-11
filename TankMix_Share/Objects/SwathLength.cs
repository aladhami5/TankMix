using System;

namespace TankMix_Share
{
	public enum SwathLengthUnit
	{
		Mile,
		M,
	}
	public class SwathLength
	{
		public double Mile { set; get; }
		public double M { set; get; }
		public double value { set; get; }
		public SwathLengthUnit unit { set; get; }

		public SwathLength (){}

		public void SetValue (double input){
			this.value = input;
		}
		public void SetValueAndUnit(SwathLengthUnit u, double input)
		{
			this.value = input;
			switch (u){
			case SwathLengthUnit.Mile:
				this.unit = SwathLengthUnit.Mile;
				Mile = input;
				M = CalculationManager.SharedInstance.MileToM (input);
				break;
			case SwathLengthUnit.M:
				this.unit = SwathLengthUnit.M;
				M = input;
				Mile = CalculationManager.SharedInstance.MToMile (input);
				break;
			}
		}
	}
}

