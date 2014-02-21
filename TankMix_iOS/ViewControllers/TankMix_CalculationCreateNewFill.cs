using System;
using System.Collections.Generic;
using System.Linq;
using MonoTouch.Foundation;
using MonoTouch.UIKit;
using MonoTouch.Dialog;
using TankMix_Share;

namespace TankMix_iOS
{
	public partial class TankMix_CalculationCreateNewFill : DialogViewController
	{
		StringElement Remainder;
		StringElement AreaTreated;
		EntryElement AreaRemaining_E;
		StringElement AreaRemaining_S;
		StringElement TankFill;
		StringElement Net;
		StringElement TankArea;
		StringElement Product;
		StringElement Adjuvant;

		Fill localFill;
		Boolean _isLast;

		public TankMix_CalculationCreateNewFill (Fill fill) : base (UITableViewStyle.Grouped, null)
		{
			Root = new RootElement ("");
			localFill = new Fill ();
			localFill = fill;

			this.Title = "Fill " + fill.Name + " Result";
			var Section = new Section ();

			Remainder = new StringElement ("Remainder",string.Empty);
			AreaTreated = new StringElement ("Area  Treated so far", string.Empty);
		
			AreaRemaining_S = new StringElement ("Area Remaining",string.Empty);

			TankFill = new StringElement ("Tank Fill", string.Empty);

			Net = new StringElement ("Net",string.Empty);
			TankArea = new StringElement ("Tank Area",string.Empty);
			Product = new StringElement ("Product",string.Empty);
			Adjuvant = new StringElement ("Adjuvant",string.Empty);

			Section.Add (Remainder);
			Section.Add (AreaTreated);
		
			Section.Add (AreaRemaining_S);
			

			Section.Add (TankFill);
			Section.Add (Net);
			Section.Add (TankArea);
			Section.Add (Product);
			Section.Add (Adjuvant);

			Root.Add (Section);

			var backBtn = new UIBarButtonItem ();
			backBtn.Title = "Back";
			backBtn.Clicked += (object sender, EventArgs e) => {
				this.NavigationController.PopViewControllerAnimated(true);
			};
			this.NavigationItem.LeftBarButtonItem = backBtn;

			update (localFill);
		}
		public void update (Fill f)
		{
			Remainder.Value = string.Format("{0:00.00}",f.Remainder) + " " + f.Remainder_Unit;
			AreaTreated.Value = string.Format("{0:00.00}",f.AreaTreated) + " " + f.AreaTreated_Unit;

			AreaRemaining_S.Value = string.Format("{0:00.00}",f.AreaRemaning) + " " + f.AreaRemaning_Unit;

			TankFill.Value = string.Format("{0:00.00}",f.TankFill) + " " + f.TankFill_Unit;
				Net.Value = string.Format("{0:00.00}",f.Net) + " " + f.Net_Unit;
			TankArea.Value = string.Format("{0:00.00}",f.ThisTankArea) + " " + f.ThisTankArea_Unit;
			Product.Value = string.Format("{0:00.00}",f.Product) + " " + f.Product_Unit;
			Adjuvant.Value = string.Format("{0:00.00}",f.Adjuvant) + " " + f.Adjuvant_Unit;
		}

	}
}
