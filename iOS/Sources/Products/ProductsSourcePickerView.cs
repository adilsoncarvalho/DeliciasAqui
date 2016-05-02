﻿using System;
using System.Collections.Generic;
using UIKit;

namespace DeliciasAqui.iOS
{
	public class ProductsSourcePickerView: UIPickerViewModel
	{
		private readonly IList<string> values;

		public event EventHandler<ProductsPickerChangedEventArgs> PickerChanged;

		public ProductsSourcePickerView(IList<string> values)
		{
			this.values = values;
		}

//		public override int GetComponentCount (UIPickerView picker)
//		{
//			return 1;
//		}
//
//		public override int GetRowsInComponent (UIPickerView picker, int component)
//		{
//			return values.Count;
//		}
//
//		public override string GetTitle (UIPickerView picker, int row, int component)
//		{
//			return values[row];
//		}
//
//		public override float GetRowHeight (UIPickerView picker, int component)
//		{
//			return 40f;
//		}
//
//		public override void Selected (UIPickerView picker, int row, int component)
//		{
//			if (this.PickerChanged != null)
//			{
//				this.PickerChanged(this, new ProductsPickerChangedEventArgs{SelectedValue = values[row]});
//			}
//		}
	}
}

