using System;
using System.Collections.Generic;
using System.Linq;
using MonoTouch.Foundation;
using MonoTouch.UIKit;
using MonoTouch.Dialog;

namespace TankMix_iOS
{
	public partial class TankMox_History_Table : DialogViewController
	{
		public TankMox_History_Table () : base (UITableViewStyle.Grouped, null)
		{
			Root = new RootElement ("TankMox_History_Table") {
				new Section ("First Section") {
					new StringElement ("Hello", () => {
						new UIAlertView ("Hola", "Thanks for tapping!", null, "Continue").Show (); 
					}),
					new EntryElement ("Name", "Enter your name", String.Empty)
				},
				new Section ("Second Section") {
				},
			};
		}
	}
}
