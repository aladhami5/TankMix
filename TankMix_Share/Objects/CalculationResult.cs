using System;
using System.Collections.Generic;

namespace TankMix_Share
{
	public class CalculationResult
	{
		public AreaTreatedByTank areatreatedbytank_value = new AreaTreatedByTank ();
		public ProductAmount productamount_value = new ProductAmount();
		public AdjuvantAmount adjuvantamount_value = new AdjuvantAmount();
		public TotalWater totalwater_value = new TotalWater ();
		public double numberOfTanksNeeded { set; get;}
		public double numberOfFills { set; get;}
		public AreaPerRound areaperround_value = new AreaPerRound();
		public double roundpertank { set; get;}
		public List<Fill> fills = new List<Fill>();
		public Tank TankInput;

		public CalculationResult ()
		{
		}
	}
}

