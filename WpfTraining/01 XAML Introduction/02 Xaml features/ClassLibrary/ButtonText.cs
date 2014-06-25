using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Markup;

namespace CustomClasses.Button
{
	public class ButtonText
	{
		private int repeat = 1;
		private string text = "";

		public int Repeat
		{
			get
			{
				return repeat;
			}
			set
			{
				repeat = value;
			}
		}

		public string Text
		{
			get
			{
				return text;
			}
			set
			{
				text = value;
			}
		}

		public override string ToString()
		{
			StringBuilder buttonText = new StringBuilder();
			for (int i = 0; i < this.Repeat; i++)
			{
				if (i > 0)
				{
					buttonText.Append(", ");
				}
				buttonText.Append(this.Text);
			}
			return "BUTTON\n" + buttonText.ToString();
		}
	}
}
