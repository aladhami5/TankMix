using System;

namespace TankMix_Share
{
	public enum AreaTreatedByTankUnit
	{
		Acres,
		Ha,
	}
	public class AreaTreatedByTank
	{
		public double value { set; get;}
		public AreaTreatedByTankUnit unit { set; get;}
		public double Acres { set; get;}
		public double Ha { set; get;}

		public AreaTreatedByTank ()
		{
		}
	}
}

