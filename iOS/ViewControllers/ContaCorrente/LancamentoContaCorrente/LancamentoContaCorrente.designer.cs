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
	[Register ("LancamentoContaCorrente")]
	partial class LancamentoContaCorrente
	{
		[Outlet]
		UIKit.UIButton btnCancela { get; set; }

		[Outlet]
		UIKit.UIButton btnConfirma { get; set; }

		[Outlet]
		UIKit.UISlider slQuantidade { get; set; }

		[Outlet]
		UIKit.UITextField tfData { get; set; }

		[Outlet]
		UIKit.UITextField tfProduto { get; set; }

		[Action ("Cancelar:")]
		partial void Cancelar (Foundation.NSObject sender);

		[Action ("Confirmar:")]
		partial void Confirmar (Foundation.NSObject sender);
		
		void ReleaseDesignerOutlets ()
		{
			if (tfProduto != null) {
				tfProduto.Dispose ();
				tfProduto = null;
			}

			if (btnConfirma != null) {
				btnConfirma.Dispose ();
				btnConfirma = null;
			}

			if (btnCancela != null) {
				btnCancela.Dispose ();
				btnCancela = null;
			}

			if (slQuantidade != null) {
				slQuantidade.Dispose ();
				slQuantidade = null;
			}

			if (tfData != null) {
				tfData.Dispose ();
				tfData = null;
			}
		}
	}
}
