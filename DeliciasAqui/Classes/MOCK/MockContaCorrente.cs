using System;

namespace DeliciasAqui
{
	public class MockContaCorrente
	{
		public MockContaCorrente ()
		{
		}

		public ContaCorrente MocaConta(int codigo)
		{

			ContaCorrente contaCorrente;
			contaCorrente = new ContaCorrente ();

			if (codigo == 1) {
				Cliente cliente = new Cliente ();
				cliente.name = "Moacir";
				cliente.phoneNumber = "4796342929";

				contaCorrente.titular = cliente;
				contaCorrente.Deposita (900.0);
				contaCorrente.Saca (150);
				contaCorrente.Saca (50);
				contaCorrente.Saca (50);
			}
			if (codigo == 2) {
				Cliente cliente = new Cliente ();
				cliente.name = "Zézinho";
				cliente.phoneNumber = "1234567890";

				contaCorrente.titular = cliente;
				contaCorrente.Deposita (30.0);
				contaCorrente.Saca (150);
				contaCorrente.Saca (50);
				contaCorrente.Saca (50);
			}

			if (codigo == 3) {
				Cliente cliente = new Cliente ();
				cliente.name = "Mariazinha";
				cliente.phoneNumber = "0123456789";

				contaCorrente.titular = cliente;
				contaCorrente.Deposita (30.0);
				contaCorrente.Saca (50);
				contaCorrente.Saca (50);
			}

			return contaCorrente;
		}
	}
}

