using System;
using System.Collections.Generic;
using UIKit;

namespace DeliciasAqui.iOS
{
	public class ProductsModelPickerView: UIPickerViewModel
	{
		private readonly IList<string> values;

		public event EventHandler<ProductsPickerChangedEventArgs> PickerChanged;

		public ProductsModelPickerView(IList<string> values)
		{
			this.values = values;
		}

		public override nint GetComponentCount (UIPickerView picker)
		{
			return 1;
		}

		public override nint GetRowsInComponent (UIPickerView picker, nint component)
		{
			return values.Count;
		}

		public override string GetTitle (UIPickerView picker, nint row, nint component)
		{
			return values[(int)row];
		}

		public override nfloat GetRowHeight (UIPickerView picker, nint component)
		{
			return 40f;
		}

		public override void Selected (UIPickerView picker, nint row, nint component)
		{
			if (this.PickerChanged != null)
			{
				this.PickerChanged(this, new ProductsPickerChangedEventArgs{SelectedValue = values[(int)row]});
			}
		}
	}
}

