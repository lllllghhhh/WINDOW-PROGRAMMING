using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Practice4_2
{
	enum state {
		empty, watered, fertilized
	}

	public partial class Form2 : Form
	{
		public Form2()
		{
			InitializeComponent();
			update();
		}

		private Dictionary<Button, state> states = new Dictionary<Button, state>();

		private void padlock_Click(object sender, EventArgs e) {
			var btn = (Button)sender;
			switch (btn.ImageIndex) {
				case 0:
					if (seed_button.Checked && seed_amount > 0) {
						btn.ImageIndex = 1;
						seed_amount--;
					}					
					break;
				case 1:
				case 2:
					if (!states.TryGetValue(btn, out var btn_state))
						btn_state = state.empty;
					switch (btn_state) {
						case state.empty:
							if (f_button.Checked && fertilizer_amount > 0) {
								states[btn] = state.fertilized;
								fertilizer_amount--;
							}
							if (kettle_button.Checked) 
								states[btn] = state.watered;
							
							break;
						case state.fertilized:
							if (kettle_button.Checked) {
								states[btn] = state.empty;
								++btn.ImageIndex;
							}
							break;
						case state.watered:
							if (f_button.Checked && fertilizer_amount > 0) {
								states[btn] = state.empty;
								++btn.ImageIndex;
								fertilizer_amount--;
							}
							break;
					}
					break;
				case 3:
					if (sickle_button.Checked) {
						btn.ImageIndex = 0;
						fruit_amount++;
					}
					break;
			}
		}

		private int seed_amount = 5;
		private int fertilizer_amount = 5;
		private int fruit_amount = 0;
		private int savings = 100;

		private void update() {
			seed.Text = seed_amount.ToString();
			fertilizer.Text = fertilizer_amount.ToString();
			fruit.Text = fruit_amount.ToString();
			label2.Text = savings.ToString();
		}
		
		private void button1_Click(object sender, EventArgs e) {
			if (savings >= 10 && seed_check.Checked) {
				seed_amount++;
				savings -= 10;
			}
			if (savings >= 10 && f_check.Checked) {
				fertilizer_amount++;
				savings -= 10;
			}
			if (fruit_check.Checked && fruit_amount > 0) {
				fruit_amount--;
				savings += 40;
			}
			update();
		}

		private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
		{
			update();
		}
	}
}