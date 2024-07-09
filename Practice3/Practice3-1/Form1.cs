using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Name_check.Hide();
            gender_check.Hide();
            birth_check.Hide();
            today_check.Hide();
            doc_check.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Name_text.Text is null)
            {
                Name_check.Show();
            }
            if (gender_text.Text is null)
            {
                gender_check.Show();
            }
            else if (gender_text.Text != "男" || gender_text.Text != "女")
            {
                gender_check.Text = "輸入應為男or女";
                gender_text.Show();
            }
            if (birth_text.Text is null)
            {
                birth_check.Show();
            }
            if (today_text.Text is null)
            {
                today_check.Show();
            }
            if (doc_text.Text is null)
            {
                doc_check.Show();
            }
            else if (doc_text.Text != "貓" || doc_text.Text != "狗")
            {
                doc_check.Text = "輸入應為貓or狗";
                doc_check.Show();
            }
        }
    }
}