using System;
using System.Collections.Generic;
using System.Linq;
using MonoTouch.Foundation;
using MonoTouch.UIKit;
using MonoTouch.Dialog;
using TankMix_Share;

namespace TankMix_iOS
{
	public partial class TankMix_History_Fill : DialogViewController
	{

		public TankMix_History_Fill (List<Fill> Fills,int F) : base (UITableViewStyle.Grouped, null)
		{
			this.Pushing = true;
			Root = new RootElement ("Fills");
			var Section = new Section ();

			for(int i=1; i<=F; i++)
			{
				var btn = new StringElement ("Fill "+i, string.Empty);
				btn.Tapped += () => {
					this.NavigationController.PushViewController(new TankMix_CalculationCreateFill (Convert.ToInt32(btn.Caption.Split(' ')[1]),Fills),true);
				};
				Section.Add (btn);
			}

			Root.Add (Section);
		}
	}
}
