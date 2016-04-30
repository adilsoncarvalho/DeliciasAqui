using System;
using UIKit;
using System.Collections.Generic;

namespace DeliciasAqui.iOS
{
	public partial class ContaCorrenteViewController : UIViewController
	{
		private MockContaCorrente conta;
		private List<ContaCorrente> data;

		public ContaCorrenteViewController () : base ("ContaCorrenteViewController", null)
		{
		}

		public override void ViewDidLoad ()
		{
			base.ViewDidLoad ();

			PopulaData ();

			tableView.Source = new ContaCorrenteTableSource (data);
		}

		public override void DidReceiveMemoryWarning ()
		{
			base.DidReceiveMemoryWarning ();
			// Release any cached data, images, etc that aren't in use.
		}

		private void PopulaData() {
			conta = new MockContaCorrente ();
			data = new List<ContaCorrente>{conta.MocaConta(1),conta.MocaConta(2),conta.MocaConta(3)};

			double saldo = 0;

			foreach (ContaCorrente conta in data) {
				saldo += conta.saldo;
			}

			if (saldo >= 0) {
				viewSaldo.BackgroundColor = UIColorExtensions.FromHex(0xFFBBAE);
			} else {
				viewSaldo.BackgroundColor = UIColorExtensions.FromHex(0x7FFF91);
			}


			labelValorSaldo.Text = saldo.ToString ("0.00", System.Globalization.CultureInfo.InvariantCulture);
		}

	}
}


