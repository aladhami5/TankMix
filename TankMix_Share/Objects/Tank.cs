using System;

namespace TankMix_Share
{
	public class Tank
	{
		public ApplicationVolume applicationvolume_value = new ApplicationVolume ();
		public ProductRate productrate_value = new ProductRate();
		public AdjuvantRate adjuvantrate_value = new AdjuvantRate ();
		public TankCapacity tankcapacity_value = new TankCapacity ();
		public TankRemainder tankremainder_value = new TankRemainder ();
		public TotalArea totalarea_value = new TotalArea ();
		public BoomWidth boomwidth_value = new BoomWidth ();
		public SwathLength swathlength_value = new SwathLength ();
		public SumpCapacity sumpcapacity_value = new SumpCapacity ();

		public double number_headlands_swaths_value;
		public Tank ()
		{
		}
	}
}

