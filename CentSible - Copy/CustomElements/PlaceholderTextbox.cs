using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace PlaceholderText
{
	[ToolboxBitmap(typeof(TextBox))]
	public class PlaceholderTextBox : TextBox
	{
		private string _placeholder = "Enter text...";
		private Color _placeholderColor = Color.Gray;
		private Color _textColor = SystemColors.WindowText;
		private bool _isPlaceholder = true;

		[Category("Behavior")]
		[Description("Text shown when the control is empty.")]
		public string Placeholder
		{
			get => _placeholder;
			set
			{
				_placeholder = value;
				UpdatePlaceholder();
			}
		}

		[Category("Appearance")]
		public Color PlaceholderColor
		{
			get => _placeholderColor;
			set
			{
				_placeholderColor = value;
				if (_isPlaceholder)
					ForeColor = _placeholderColor;
			}
		}

		[Browsable(false)]
		public bool IsPlaceholderActive => _isPlaceholder;

		public PlaceholderTextBox()
		{
			SetStyle(ControlStyles.UserPaint, false);

			GotFocus += (_, __) => RemovePlaceholder();
			LostFocus += (_, __) => UpdatePlaceholder();
		}

		protected override void OnHandleCreated(EventArgs e)
		{
			base.OnHandleCreated(e);
			UpdatePlaceholder();
		}

		private void UpdatePlaceholder()
		{
			if (!Focused && string.IsNullOrEmpty(base.Text))
			{
				_isPlaceholder = true;
				base.Text = _placeholder;
				ForeColor = _placeholderColor;
			}
		}

		private void RemovePlaceholder()
		{
			if (_isPlaceholder)
			{
				_isPlaceholder = false;
				base.Text = string.Empty;
				ForeColor = _textColor;
			}
		}

		public override string Text
		{
			get => _isPlaceholder ? string.Empty : base.Text;
			set
			{
				_isPlaceholder = false;
				base.Text = value;
				ForeColor = _textColor;
			}
		}

		protected override void OnTextChanged(EventArgs e)
		{
			base.OnTextChanged(e);

			if (!Focused && string.IsNullOrEmpty(base.Text))
				UpdatePlaceholder();
		}
	}
}