using System;
using UIKit;
using System.Collections.Generic;

namespace DeliciasAqui
{
	public class ContaCorrenteTableSource : UITableViewSource
	{
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
			new UIAlertView("Alert","Selected Cell", null, "OK" ,null).Show ();
			tableView.DeselectRow (indexPath, true);
		}
	}
}

