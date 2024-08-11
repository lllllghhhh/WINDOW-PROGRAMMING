using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practice4_1
{
	public partial class Form1 : Form
	{

		private int answer = new Random().Next(0, 9999);
		
		public Form1()
		{
			InitializeComponent();
		}

		private void padlock_click(object sender, EventArgs e)
		{
			var btn = (Button)sender;
			if (btn.ImageIndex >= 9)
				btn.ImageIndex = 0;
			else
				++btn.ImageIndex;
		}

		private void button5_Click(object sender, EventArgs e)
		{
			var input = button1.ImageIndex * 1000 + button2.ImageIndex * 100 + button3.ImageIndex * 10 +
			            button4.ImageIndex;
			if (answer == input) {
				MessageBox.Show("恭喜答對","成功",MessageBoxButtons.OK,MessageBoxIcon.Asterisk);
				Close();
				return;
			}

			var btn1_c = button1.ImageIndex == answer / 1000 % 10;
			var btn2_c = button2.ImageIndex == answer / 100 % 10;
			var btn3_c = button3.ImageIndex == answer / 10 % 10;
			var btn4_c = button4.ImageIndex == answer % 10;
			label1.Text = btn1_c ? "對" : "錯";
			label2.Text = btn2_c ? "對" : "錯";
			label3.Text = btn3_c ? "對" : "錯";
			label4.Text = btn4_c ? "對" : "錯";
			var msg = $"共答對{(btn1_c ? 1 : 0) + (btn2_c ? 1 : 0) + (btn3_c ? 1 : 0) + (btn4_c ? 1 : 0)}個";
			var rst = MessageBox.Show(msg, "答錯", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
			if (rst == DialogResult.Cancel) {
				MessageBox.Show($"答案是{answer}");
				Close();
			}
		}
	}
}