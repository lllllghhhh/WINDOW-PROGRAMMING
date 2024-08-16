using System;
using System.Windows.Forms;

namespace Practice4_2
{
	public partial class Form2 : Form
	{
		public Form2()
		{
			InitializeComponent();
		}


		private void padlock_Click(object sender, EventArgs e)
		{
			bool ferted = false;
			bool watered = false;
			var btn = (Button)sender;
			if (seed_button.Checked && btn.ImageIndex == 0)
				btn.ImageIndex = 1;
			if (btn.ImageIndex == 3 && sickle_button.Checked)
				btn.ImageIndex = 0;
			if (kettle_button.Checked)
				watered = true;
			if (f_button.Checked)
				ferted = true;
			if (ferted && watered) {
				if (btn.ImageIndex == 1 || btn.ImageIndex == 2)
					btn.ImageIndex++;
				ferted = false;
				watered = false;
			}
				



		}
	}
}