using System;
using System.Collections.Generic;
using System.Linq;
using MonoTouch.Foundation;
using MonoTouch.UIKit;
using MonoTouch.Dialog;
using TankMix_Share;
using MonoTouch.MessageUI;


namespace TankMix_iOS
{
	public partial class TankMix_History_Table : DialogViewController
	{
		Section Section;
		public TankMix_History_Table () : base (UITableViewStyle.Grouped, null)
		{
			Root = new RootElement ("Result");
			Section = new Section ();
		}

		public override void ViewWillAppear (bool animated)
		{
			base.ViewWillAppear (animated);
			var elements = HistoryManager.SharedInstance.GetResultList();

			Root.Remove(Section);
			Section = new Section ();


			for (int i=1; i<=elements.Count;i++)
			{
				var temp = i;
				Section.Add (new StringElement("Result "+temp,()=>{
					Console.Out.WriteLine(temp);
					var ActionSheet = new UIActionSheet ("Options");

					ActionSheet.AddButton("Detail");
					ActionSheet.AddButton("Send by Email");
					ActionSheet.AddButton("Delete");
					ActionSheet.AddButton("Cancel");

					ActionSheet.DestructiveButtonIndex = 2;
					ActionSheet.CancelButtonIndex = 3;

					ActionSheet.Clicked += (object sender, UIButtonEventArgs e) => {
						if(e.ButtonIndex == 0)
						{
							// Detail
							Console.Out.WriteLine("Detail");
							var t = new CalculationResult ();
							t = HistoryManager.SharedInstance.GetResultList()[temp-1];
							this.NavigationController.PushViewController(new TankMix_History_Result(t),true);
						}else if (e.ButtonIndex == 1){
							// Share
							Console.Out.WriteLine("Send by Email");
							var Email = new MFMailComposeViewController();
							Email.Finished += (object s, MFComposeResultEventArgs ea) => {
								ea.Controller.DismissViewController(true,null);
							};
							var msg = "";
							Email.SetMessageBody(msg,false);
							this.NavigationController.PresentViewController(Email,true,null);

							this.NavigationController.PopToRootViewController(true);
						}else if (e.ButtonIndex == 2){
							//Delete
							Console.Out.WriteLine("Delete");
							HistoryManager.SharedInstance.GetResultList().RemoveAt(i-2);
							ViewWillAppear(true);
						}else{
							// Cancel
							Console.Out.WriteLine("Cancel");
						}

					};
					ActionSheet.ShowInView(View);

				}));
			}
			Root.Add (Section);
		}

		public void DeletePreviousHistory()
		{
			while(Section.Elements.Count >=1)
			{
				Section.Remove (1);

			}
		}
	}
}