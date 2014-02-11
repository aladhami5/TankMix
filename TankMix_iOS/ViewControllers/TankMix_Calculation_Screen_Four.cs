using System;
using System.Collections.Generic;
using System.Linq;
using MonoTouch.Foundation;
using MonoTouch.UIKit;
using MonoTouch.Dialog;
using TankMix_Share;

namespace TankMix_iOS
{
	public partial class TankMix_Calculation_Screen_Four : DialogViewController
	{
		TankMixRadioGroupElement NetTankVolume;

		public TankMix_Calculation_Screen_Four () : base (UITableViewStyle.Grouped, null)
		{
			this.Pushing = true;
			Root = new RootElement ("Results");
			InitializeUserInterface ();
		}

		private void InitializeUserInterface ()
		{
			var Section = new Section ();

			var NetTankVolume_index = HistoryManager.SharedInstance.GetCurrentTankData ().tankcapacity_value.unit;
			double r_NetTankVolume_index_Imp_gal = 0.0;
			double r_NetTankVolume_L = 0.0;
			double r_NetTankVolume_Us_gal = 0.0;

			switch(NetTankVolume_index)
			{
			case TankCapacityUnit.Imp_gal:
				r_NetTankVolume_index_Imp_gal = CalculationManager.SharedInstance.NetTankVolume ();
				r_NetTankVolume_L = CalculationManager.SharedInstance.Imp_gpaToL_ha (r_NetTankVolume_index_Imp_gal);
				r_NetTankVolume_Us_gal = CalculationManager.SharedInstance.Imp_galToUs_gal (r_NetTankVolume_index_Imp_gal);
				break;
			case TankCapacityUnit.L:
				r_NetTankVolume_L = CalculationManager.SharedInstance.NetTankVolume ();
				r_NetTankVolume_index_Imp_gal = CalculationManager.SharedInstance.LToImp_gal (r_NetTankVolume_L);
				r_NetTankVolume_Us_gal = CalculationManager.SharedInstance.LToUs_gal (r_NetTankVolume_L);
				break;
			case TankCapacityUnit.Us_gal:
				r_NetTankVolume_Us_gal = CalculationManager.SharedInstance.NetTankVolume ();
				r_NetTankVolume_L = CalculationManager.SharedInstance.Us_galToL (r_NetTankVolume_Us_gal);
				r_NetTankVolume_index_Imp_gal = CalculationManager.SharedInstance.Us_galToImp_gal (r_NetTankVolume_Us_gal);
				break;
			}

			NetTankVolume = new TankMixRadioGroupElement ((int)NetTankVolume_index);
			var NetTankVolumeRoot = new RootElement ("Net Tank Volume",NetTankVolume);
			var NetTankVolumeRootSection = new Section (" Net Tank Volume Results"){
			new RadioElement(string.Format ("{0:0.00}",Math.Round(r_NetTankVolume_Us_gal),MidpointRounding.ToEven)+ "  US gal"),
			new RadioElement(string.Format ("{0:0.00}",Math.Round(r_NetTankVolume_index_Imp_gal),MidpointRounding.ToEven)+ "  Imp gal"),
			new RadioElement( string.Format ("{0:0.00}",Math.Round(r_NetTankVolume_L),MidpointRounding.ToEven) + "  L"),
			};
			NetTankVolumeRoot.Add (NetTankVolumeRootSection);
			Section.Add (NetTankVolumeRoot);

			Root.Add (Section);


		}
	}
}
