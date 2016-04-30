// WARNING
//
// This file has been generated automatically by Xamarin Studio from the outlets and
// actions declared in your storyboard file.
// Manual changes to this file will not be maintained.
//
using Foundation;
using System;
using System.CodeDom.Compiler;
using UIKit;

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
			if (tableView != null) {
				tableView.Dispose ();
				tableView = null;
			}
			if (viewSaldo != null) {
				viewSaldo.Dispose ();
				viewSaldo = null;
			}
		}
	}
}
