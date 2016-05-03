using System;

namespace DeliciasAqui
{
	public class DetalhesDaConta
	{
		public Produto produto { get; set; }
		public int quantidade { get; set; }
		public double valorUnitario { get; set; }
		public double valorTotal { get; set; }
		public DateTime data { get; set; }
		public string tipoLancamento { get; set; }

		public DetalhesDaConta ()
		{
		}
	}
}

