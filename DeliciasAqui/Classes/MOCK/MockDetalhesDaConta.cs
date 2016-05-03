using System;

namespace DeliciasAqui
{
	public class MockDetalhesDaConta
	{
		public MockDetalhesDaConta ()
		{
		}

		public DetalhesDaConta MocaDetalhes(int codigo)
		{
			DetalhesDaConta detalhesDaConta;
			detalhesDaConta = new DetalhesDaConta ();

			if (codigo == 1) {
				detalhesDaConta.data = DateTime.Now;
				detalhesDaConta.produto = new Produto () {
					codigo = 1,
					descricao = "Empadinha"
				};

				detalhesDaConta.quantidade = 3;
				detalhesDaConta.valorUnitario = 5.0;
				detalhesDaConta.valorTotal = 15.0;
				detalhesDaConta.tipoLancamento = "D";
			}

			if (codigo == 2) {
				detalhesDaConta.data = DateTime.Now;
				detalhesDaConta.produto = new Produto () {
					codigo = 1,
					descricao = "Doguinho"
				};

				detalhesDaConta.quantidade = 10;
				detalhesDaConta.valorUnitario = 4.0;
				detalhesDaConta.valorTotal = 40.0;
				detalhesDaConta.tipoLancamento = "D";
			}

			if (codigo == 3) {
				detalhesDaConta.data = DateTime.Now;
				detalhesDaConta.produto = new Produto () {
					codigo = 0,
					descricao = "Pagamentos"
				};

				detalhesDaConta.quantidade = 1;
				detalhesDaConta.valorUnitario = 30.0;
				detalhesDaConta.valorTotal = 30.0;
				detalhesDaConta.tipoLancamento = "C";
			}


			return detalhesDaConta;
		}
	}
}

