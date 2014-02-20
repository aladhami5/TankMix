using System;
using System.Collections.Generic;
using System.Linq;
using MonoTouch.Foundation;
using MonoTouch.UIKit;
using MonoTouch.Dialog;
using TankMix_Share;

namespace TankMix_iOS
{
	public partial class TankMix_CalculationCreateFill_2 : DialogViewController
	{
		public TankMix_CalculationCreateFill_2 (Fill fill, UINavigationController naiv) : base (UITableViewStyle.Grouped, null)
		{
			this.Pushing = true;
			Root = new RootElement ("TankMix_CalculationCreateFill_2");

			var section = new Section (){
				new StringElement("back ",()=>{
					naiv.PopViewControllerAnimated(true);
				}),
			};

		}
	}
}
