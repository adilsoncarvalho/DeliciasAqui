using System;

using UIKit;
using System.Collections.Generic;

namespace DeliciasAqui.iOS
{
	public partial class ContaCorrenteViewController : UIViewController
	{
		private MockContaCorrente conta;

		public ContaCorrenteViewController () : base ("ContaCorrenteViewController", null)
		{
		}

		public override void ViewDidLoad ()
		{
			base.ViewDidLoad ();

			conta = new MockContaCorrente ();

			List<ContaCorrente> data = new List<ContaCorrente>{conta.MocaConta(1),conta.MocaConta(2),conta.MocaConta(3)};

			tableView.Source = new ContaCorrenteTableSource (data);
		}

		public override void DidReceiveMemoryWarning ()
		{
			base.DidReceiveMemoryWarning ();
			// Release any cached data, images, etc that aren't in use.
		}
	}
}


