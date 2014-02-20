using System;
using MonoTouch.UIKit;
using MonoTouch.Foundation;


namespace TankMix_iOS
{
	public class TankMix_TapViewController : UITabBarController
	{
		UIViewController CalculationVC;
		UIViewController HistoryVC;

		public TankMix_TapViewController ()
		{
		}

		public override void ViewDidLoad ()
		{
			base.ViewDidLoad ();
			if (CalculationVC == null) 
			{
				CalculationVC = new UINavigationController (new TankMix_Calculation_Screen_One ());
				CalculationVC.Title = "Calculation";
			}

			if (HistoryVC == null) 
			{
				HistoryVC = new UINavigationController (new TankMix_History_Table ());
				HistoryVC.Title = "History";
			}

			var tabs = new UIViewController[]{
				CalculationVC,
				HistoryVC,
			};

			ViewControllers = tabs;
			SelectedViewController = CalculationVC;
		}
	}
}

