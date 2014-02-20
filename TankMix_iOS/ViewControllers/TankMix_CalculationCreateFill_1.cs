using System;
using System.Collections.Generic;
using System.Linq;
using MonoTouch.Foundation;
using MonoTouch.UIKit;
using MonoTouch.Dialog;
using TankMix_Share;

namespace TankMix_iOS
{
	public partial class TankMix_CalculationCreateFill_1 : DialogViewController
	{
		EntryElement Remainder;
		EntryElement TankFill;

		public TankMix_CalculationCreateFill_1 (int i, List<Fill> fills) : base (UITableViewStyle.Grouped, null)
		{
			this.Pushing = true;
			Root = new RootElement ("Add Fill Information");
			Remainder = new EntryElement ("Remainder","Value",string.Empty);
			TankFill = new EntryElement ("Tank Fill", "Value",string.Empty);
			var index = i - 1;
			var Result = new StringElement ("Result",()=>{

				if (index < fills.Count){
					// look
					Console.Out.WriteLine("Look");
				}else if (index == 0 && fills.Count == 0) {
					// first time
					var first = new Fill(double.Parse(Remainder.Value),double.Parse(TankFill.Value));
					fills.Add(first);
				}else{
					if (index - fills.Count > 1){
						// no data
						Console.Out.WriteLine("No data");
					}else{
						// create 
						var second = new Fill (fills[i-1],double.Parse(Remainder.Value),double.Parse(TankFill.Value));
						fills.Add(second);
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
