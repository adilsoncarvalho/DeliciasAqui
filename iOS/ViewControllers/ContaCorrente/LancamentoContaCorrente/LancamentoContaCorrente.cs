using System;

using UIKit;
using System.Collections.Generic;

namespace DeliciasAqui.iOS
{
	public partial class LancamentoContaCorrente : UIViewController
	{
		private string selectedProduct;
		private readonly IList<string> products = new List<string>
		{
			"Empadinha Salgada",
			"Empadinha Doce",
			"Doguinho",
			"Pão de batata",
			"Bolo de pote",
			"Torta Alemã"
		};

		public LancamentoContaCorrente () : base ("LancamentoContaCorrente", null)
		{
		}

		public override void ViewDidLoad ()
		{
			base.ViewDidLoad ();

			btnConfirma.Layer.CornerRadius = 7f;
			btnCancela.Layer.CornerRadius = 7f;

			this.SetupPicker();
			this.SetupDatePicker();
		}

		private void SetupDatePicker()
		{
			var datePicker = new UIDatePicker () {
				Mode = UIDatePickerMode.Date,
			};

			UIToolbar toolbar = new UIToolbar();
			toolbar.BarStyle = UIBarStyle.Black;
			toolbar.Translucent = true;
			toolbar.SizeToFit();

			UIBarButtonItem doneButton = new UIBarButtonItem("Done", UIBarButtonItemStyle.Done,
				(s, e) => {
					this.tfData.Text = selectedProduct;
					this.tfData.ResignFirstResponder();
				});
			toolbar.SetItems(new UIBarButtonItem[]{doneButton}, true);

			tfData.InputView = datePicker;
			this.tfData.InputAccessoryView = toolbar;
		}

		private void SetupPicker()
		{
			ProductsModelPickerView model = new ProductsModelPickerView(this.products);
			model.PickerChanged += (sender, e) => {
				this.selectedProduct = e.SelectedValue;
			};

			UIPickerView picker = new UIPickerView();
			picker.ShowSelectionIndicator = true;
			picker.Model = model;

			UIToolbar toolbar = new UIToolbar();
			toolbar.BarStyle = UIBarStyle.Black;
			toolbar.Translucent = true;
			toolbar.SizeToFit();

			UIBarButtonItem doneButton = new UIBarButtonItem("Done", UIBarButtonItemStyle.Done,
				(s, e) => {
					this.tfProduto.Text = selectedProduct;
					this.tfProduto.ResignFirstResponder();
				});

			toolbar.SetItems(new UIBarButtonItem[]{doneButton}, true);
			this.tfProduto.InputView = picker;
			this.tfProduto.InputAccessoryView = toolbar;
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
//NSDate sourceDate = date;
//
//NSTimeZone sourceTimeZone = new NSTimeZone ("UTC");
//NSTimeZone destinationTimeZone = NSTimeZone.LocalTimeZone;
//
//int sourceGMTOffset = sourceTimeZone.SecondsFromGMT (sourceDate);
//int destinationGMTOffset = destinationTimeZone.SecondsFromGMT (sourceDate);
//int interval = destinationGMTOffset - sourceGMTOffset;
//
//var destinationDate = sourceDate.AddSeconds (interval);
//
//var dateTime = new DateTime(2001, 1, 1, 0, 0,0).AddSeconds(destinationDate.SecondsSinceReferenceDate);
//
//DescriptionLabel.Text = dateTime.ToString ("dd.MM.yyyy. HH:mm");
//this.date = destinationDate;
