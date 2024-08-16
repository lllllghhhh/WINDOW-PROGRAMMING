using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practice4_2
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			var seed_amount = int.Parse(seed.Text);
			var f_amount = int.Parse(fertilizer.Text);
			var fruit_amount = int.Parse(fruit.Text);
			var savings = int.Parse(label2.Text);
			if (seed_amount > 0 | f_amount > 0 | fruit_amount > 0) {
				if (seed_check.Checked && seed_amount > 0) {
					seed_amount++;
					savings -= 10;
				}
				if (f_check.Checked && f_amount > 0) {
					f_amount++;
					savings -= 10;
				}
				if (fruit_check.Checked && fruit_amount > 0) {
					seed_amount--;
					savings += 40;
				}

				seed.Text = seed_amount.ToString();
				fertilizer.Text = f_amount.ToString();
				fruit.Text = fruit_amount.ToString();
				label2.Text = savings.ToString();
			}
		}
	}
}