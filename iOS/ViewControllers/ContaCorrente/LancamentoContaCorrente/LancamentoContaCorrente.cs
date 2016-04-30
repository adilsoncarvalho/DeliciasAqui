using System;

using UIKit;

namespace DeliciasAqui.iOS
{
	public partial class LancamentoContaCorrente : UIViewController
	{
		public LancamentoContaCorrente () : base ("LancamentoContaCorrente", null)
		{
		}

		public override void ViewDidLoad ()
		{
			base.ViewDidLoad ();
			this.View.Opaque = false;
			this.View.BackgroundColor = UIColor.FromRGBA (0, 0, 0, 0.3f);

			btnConfirma.Layer.CornerRadius = 7f;
			btnCancela.Layer.CornerRadius = 7f;
		
		}

		public override void DidReceiveMemoryWarning ()
		{
			base.DidReceiveMemoryWarning ();
			// Release any cached data, images, etc that aren't in use.
		}

		partial void Cancelar (Foundation.NSObject sender) {
			DismissViewController(true, null);
		}
	}
}


