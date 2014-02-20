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
		EntryElement AreaRemaining;
		StringElement TankFill;
		StringElement Net;
		StringElement TankArea;
		StringElement Product;
		StringElement Adjuvant;

		Fill localFill;

		public TankMix_CalculationCreateNewFill (Fill fill, UINavigationController navi) : base (UITableViewStyle.Grouped, null)
		{
			Root = new RootElement ("");
			localFill = new Fill ();
			localFill = fill;

			this.Title = "Fill " + fill.Name + " Result";
			var Section = new Section ();

			Remainder = new StringElement ("Remainder",string.Empty);
			AreaTreated = new StringElement ("Area  Treated so far", string.Empty);
			AreaRemaining = new EntryElement ("Area Remaining", string.Empty, string.Empty);
			AreaRemaining.KeyboardType = UIKeyboardType.NumbersAndPunctuation;
			AreaRemaining.TextAlignment = UITextAlignment.Right;
			TankFill = new StringElement ("Tank Fill", string.Empty);

			Net = new StringElement ("Net",string.Empty);
			TankArea = new StringElement ("Tank Area",string.Empty);
			Product = new StringElement ("Product",string.Empty);
			Adjuvant = new StringElement ("Adjuvant",string.Empty);

			Section.Add (Remainder);
			Section.Add (AreaTreated);
			Section.Add (AreaRemaining);
			Section.Add (TankFill);
			Section.Add (Net);
			Section.Add (TankArea);
			Section.Add (Product);
			Section.Add (Adjuvant);

			Root.Add (Section);

			var backBtn = new UIBarButtonItem ();
			backBtn.Title = "Back";
			backBtn.Clicked += (object sender, EventArgs e) => {
				navi.PopViewControllerAnimated(true);
			};
			this.NavigationItem.LeftBarButtonItem = backBtn;

			update (localFill);
		}
		public void update (Fill f)
		{
			Remainder.Value = f.Remainder.ToString () + " " + f.Remainder_Unit;
			AreaTreated.Value = f.AreaTreated.ToString () + " " + f.AreaTreated_Unit;
			AreaRemaining.Value = f.AreaRemaning.ToString () + " " + f.AreaRemaning_Unit;
			TankFill.Value = f.TankFill.ToString () + " " + f.TankFill_Unit;
			Net.Value = f.Net.ToString () + " " + f.Net_Unit;
			TankArea.Value = string.Format("{0:00.00}",f.ThisTankArea) + " " + f.ThisTankArea_Unit;
			Product.Value = string.Format("{0:00.00}",f.Product) + " " + f.Product_Unit;
			Adjuvant.Value = string.Format("{0:00.00}",f.Adjuvant) + " " + f.Adjuvant_Unit;
		}

	}
}
