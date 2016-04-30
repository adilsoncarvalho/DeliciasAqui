// WARNING
//
// This file has been generated automatically by Xamarin Studio Community to store outlets and
// actions made in the UI designer. If it is removed, they will be lost.
// Manual changes to this file may not be handled correctly.
//
using Foundation;
using System.CodeDom.Compiler;

namespace DeliciasAqui.iOS
{
	[Register ("ContaCorrenteViewController")]
	partial class ContaCorrenteViewController
	{
		[Outlet]
		UIKit.UILabel labelValorSaldo { get; set; }

		[Outlet]
		UIKit.UITableView tableView { get; set; }

		[Outlet]
		UIKit.UIView viewSaldo { get; set; }
		
		void ReleaseDesignerOutlets ()
		{
			if (labelValorSaldo != null) {
				labelValorSaldo.Dispose ();
				labelValorSaldo = null;
			}

			if (viewSaldo != null) {
				viewSaldo.Dispose ();
				viewSaldo = null;
			}

			if (tableView != null) {
				tableView.Dispose ();
				tableView = null;
			}
		}
	}
}
