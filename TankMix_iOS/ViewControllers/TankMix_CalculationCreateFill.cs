using System;
using System.Collections.Generic;
using System.Linq;
using MonoTouch.Foundation;
using MonoTouch.UIKit;
using MonoTouch.Dialog;
using TankMix_Share;

namespace TankMix_iOS
{
	public partial class TankMix_CalculationCreateFill : DialogViewController
	{
		public TankMix_CalculationCreateFill (int Index, List<Fill> Fills) : base (UITableViewStyle.Grouped, null)
		{
			this.Pushing = true;
			Root = new RootElement ("Add Input to Fill");
			var Remainder = new EntryElement ("Remainder","Value",string.Empty);
			Remainder.TextAlignment = UITextAlignment.Right;
			Remainder.KeyboardType = UIKeyboardType.NumberPad;

			var TankFill = new EntryElement ("Tank Fill","Value",string.Empty);
			TankFill.TextAlignment = UITextAlignment.Right;
			TankFill.KeyboardType = UIKeyboardType.NumberPad;


			var Result = new StringElement ("Result", () => {

				if(Index == 1 && Fills.Count == 0){
					// first time
					Console.Out.WriteLine("Created,first");
					var newFill = new Fill (double.Parse(Remainder.Value),double.Parse(TankFill.Value));
					newFill.Name =(Index+1).ToString();
					Fills.Add(newFill);
					this.NavigationController.PushViewController( new TankMix_CalculationCreateNewFill(newFill),true);
				}else{
					if (Index <= Fills.Count){
						// contain
						Console.Out.WriteLine("Contained");
						NavigationController.PushViewController(new TankMix_CalculationCreateNewFill(Fills[Index-1]),true);

					}else {
						if (Index - Fills.Count == 1){
							// last , create
							var lastFill = new Fill (Fills[Fills.Count-1],double.Parse(Remainder.Value),double.Parse(TankFill.Value));
							Fills.Add(lastFill);
							NavigationController.PushViewController( new TankMix_CalculationCreateNewFill(lastFill),true);

							Console.Out.WriteLine("Created,new");

						}else{
							// no data
							Console.Out.WriteLine("No Data");
							new UIAlertView ("Error", "Please, give the previous input", null, "OK").Show (); 
						}
					}
				}
			});

			var Section = new Section ();
			Section.Add (Remainder);
			Section.Add (TankFill);
			Section.Add (Result);

			Root.Add (Section);

		}
	}
}
