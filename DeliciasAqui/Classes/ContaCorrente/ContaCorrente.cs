using System;

namespace DeliciasAqui
{
	public class ContaCorrente
	{
		public double saldo { get; private set;}
		public Cliente titular { get; set; }
		public DetalhesDaConta detalhesDaConta { get; set; }

		public ContaCorrente ()
		{
			
		}

		public bool Saca(double valor)
		{
			this.saldo -= valor;
			return true;
		}

		public bool Deposita(double valor)
		{
			this.saldo += valor;
			return true;
		}
	}
}

