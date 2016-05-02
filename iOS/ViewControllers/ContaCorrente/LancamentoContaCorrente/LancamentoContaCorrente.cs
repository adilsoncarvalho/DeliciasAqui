using System;

using UIKit;
using System.Collections.Generic;

namespace DeliciasAqui.iOS
{
	public partial class LancamentoContaCorrente : UIViewController
	{
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

			var datePicker = new UIDatePicker () {
				Mode = UIDatePickerMode.Date,
			};

			tfData.InputView = datePicker;
			this.SetupPicker();
		}

		private void SetupPicker()
		{
//			// Setup the picker and model
//			PickerModel model = new PickerModel(this.colors);
//			model.PickerChanged += (sender, e) => {
//				this.selectedColor = e.SelectedValue;
//			};


			UIPickerView picker = new UIPickerView();
			picker.ShowSelectionIndicator = true;
//			picker.Model = model;

			// Setup the toolbar
			UIToolbar toolbar = new UIToolbar();
			toolbar.BarStyle = UIBarStyle.Black;
			toolbar.Translucent = true;
			toolbar.SizeToFit();

			// Create a 'done' button for the toolbar and add it to the toolbar
			UIBarButtonItem doneButton = new UIBarButtonItem("Done", UIBarButtonItemStyle.Done,
				(s, e) => {
//					this.ColorTextField.Text = selectedColor;
//					this.ColorTextField.ResignFirstResponder();
				});
			toolbar.SetItems(new UIBarButtonItem[]{doneButton}, true);

			// Tell the textbox to use the picker for input
//			this.ColorTextField.InputView = picker;

			// Display the toolbar over the pickers
//			this.ColorTextField.InputAccessoryView = toolbar;
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
