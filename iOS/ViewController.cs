using System;
using UIKit;
using System.Collections.Generic;

namespace DeliciasAqui.iOS
{
	public partial class ViewController : UIViewController
	{
		private MockContaCorrente conta;


		public ViewController (IntPtr handle) : base (handle)
		{		
		}

		public override void ViewDidLoad ()
		{
			base.ViewDidLoad ();

			// Remover o Mock e pegar do servico
			conta = new MockContaCorrente ();

			List<ContaCorrente> data = new List<ContaCorrente>{conta.MocaConta(1),conta.MocaConta(2),conta.MocaConta(3)};

			UITableView tableView;

			tableView = new UITableView {
				Frame = new CoreGraphics.CGRect (0, 30, View.Bounds.Width, View.Bounds.Height-30),
				Source = new ContaCorrenteTableSource(data)
			};

			View.AddSubview (tableView);

		}

		public override void DidReceiveMemoryWarning ()
		{		
			base.DidReceiveMemoryWarning ();		
		}
	}
}
