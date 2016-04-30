using System;
using UIKit;
using System.Collections.Generic;
using Foundation;

namespace DeliciasAqui.iOS
{
	public class ContaCorrenteTableSource : UITableViewSource
	{
		private UIViewController viewController;
		List<ContaCorrente> tableItems;
		string cellIdentifier = "ContaCorrenteTableCell";

		public ContaCorrenteTableSource (List<ContaCorrente> items)
		{
			tableItems = items;
		}

		public override nint RowsInSection (UITableView tableview, nint section)
		{
			return tableItems.Count; 
		}

		public override UITableViewCell GetCell (UITableView tableView, Foundation.NSIndexPath indexPath)
		{
			UITableViewCell cell = tableView.DequeueReusableCell(cellIdentifier);

			if (cell == null)
				cell = new UITableViewCell (UITableViewCellStyle.Subtitle, cellIdentifier);

			cell.TextLabel.Text = tableItems [indexPath.Row].titular.name;
			cell.DetailTextLabel.Text = tableItems [indexPath.Row].saldo.ToString();

			cell.Accessory = UITableViewCellAccessory.DisclosureIndicator;
			return cell;
		}

		public override void RowSelected (UITableView tableView, Foundation.NSIndexPath indexPath)
		{
			UIWindow window = UIApplication.SharedApplication.KeyWindow;
			UIViewController viewController = window.RootViewController;
//			viewController.View.BackgroundColor = UIColor.FromRGBA (0, 0, 0, 0.3f);
//			viewController.View.Opaque = true;
			viewController.ModalPresentationStyle = UIModalPresentationStyle.CurrentContext;
			viewController.PresentViewController (new LancamentoContaCorrente(), true, null);
		}
	}
}

