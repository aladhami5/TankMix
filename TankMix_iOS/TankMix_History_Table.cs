using System;
using System.Collections.Generic;
using System.Linq;
using MonoTouch.Foundation;
using MonoTouch.UIKit;
using MonoTouch.Dialog;
using TankMix_Share;

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
				Section.Add (new StringElement("Result "+i,()=>{
					Console.Out.WriteLine(i);
					var ActionSheet = new UIActionSheet ("Options");

					ActionSheet.AddButton("Detail");
					ActionSheet.AddButton("Edit");
					ActionSheet.AddButton("Delete");
					ActionSheet.AddButton("Cancel");

					ActionSheet.DestructiveButtonIndex = 2;
					ActionSheet.CancelButtonIndex = 3;

					ActionSheet.Clicked += (object sender, UIButtonEventArgs e) => {
						if(e.ButtonIndex == 0)
						{
							// Detail
							Console.Out.WriteLine("Detail");
							this.NavigationController.PushViewController(new TankMix_History_Result(HistoryManager.SharedInstance.GetResultList()[i-2]),true);
						}else if (e.ButtonIndex == 1){
							// Share
							Console.Out.WriteLine("Send by Email");
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