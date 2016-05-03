using System;
using UIKit;
using System.Collections.Generic;
using Foundation;


namespace DeliciasAqui.iOS
{
	public class DetalhesDaContaTableSource: UITableViewSource
	{
		List<DetalhesDaConta> tableItems;
		string cellIdentifier = "DetalhesDaContaTableCell";

		public DetalhesDaContaTableSource (List<DetalhesDaConta> items)
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

			cell.TextLabel.Text = tableItems [indexPath.Row].produto.descricao;
			string qtd = tableItems [indexPath.Row].quantidade.ToString ();
			string vlrUnitario = tableItems [indexPath.Row].valorUnitario.ToString();
			string vlrTotal = tableItems [indexPath.Row].valorTotal.ToString();

			string sub = String.Concat ("Qtd: ", qtd, " X ", vlrUnitario, " = ", vlrTotal);

			cell.DetailTextLabel.Text = sub;

			cell.Accessory = UITableViewCellAccessory.DisclosureIndicator;
			return cell;
		}

		public override void RowSelected (UITableView tableView, Foundation.NSIndexPath indexPath)
		{
			UIWindow window = UIApplication.SharedApplication.KeyWindow;
			UIViewController viewController = window.RootViewController;

			var lancamentoContaCorrenteViewController = new LancamentoContaCorrente () {
				ModalPresentationStyle = UIModalPresentationStyle.OverCurrentContext,
				ModalTransitionStyle = UIModalTransitionStyle.CoverVertical
			};

			viewController.PresentViewController (lancamentoContaCorrenteViewController, true, null);
		}

		public override void CommitEditingStyle (UITableView tableView, UITableViewCellEditingStyle editingStyle, Foundation.NSIndexPath indexPath)
		{
			switch (editingStyle) {
			case UITableViewCellEditingStyle.Delete:
				// ToDo Apagar Item
				break;
			case UITableViewCellEditingStyle.None:
				Console.WriteLine ("CommitEditingStyle:None called");
				break;
			}
		}
		public override bool CanEditRow (UITableView tableView, NSIndexPath indexPath)
		{
			return true; // return false if you wish to disable editing for a specific indexPath or for all rows
		}
		public override string TitleForDeleteConfirmation (UITableView tableView, NSIndexPath indexPath)
		{   // Optional - default text is 'Delete'
			return "Apagar Lançamento";
		}
	}
}

