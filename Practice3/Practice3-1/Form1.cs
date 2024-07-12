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
            this.AutoValidate = AutoValidate.EnableAllowFocusChange;
            Name_check.Validating += Name_text_Validating;
        }

        private void Name_text_Validating(object sender, CancelEventArgs e)
        {
            e.Cancel = true;
            Name_check.Text = "don't leave me empty!!";
            Name_check.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Name_text.Text.Length == 0)  /// .Text is always not null
            {
                Name_check.Show();
            }
            if (gender_text.Text.Length == 0)
            {
                gender_check.Show();
            }
            else if (gender_text.Text != "男" || gender_text.Text != "女")
            {
                gender_check.Text = "輸入應為男or女";
                gender_check.Show();
            }
            if (birth_text.Text.Length == 0)
            {
                birth_check.Show();
            }
            if (today_text.Text.Length == 0)
                today_check.Show();
            if (doc_text.Text.Length == 0)
                doc_check.Show();
            else if (doc_text.Text != "貓" || doc_text.Text != "狗")
            {
                doc_check.Text = "輸入應為貓or狗";
                doc_check.Show();
            }
        }
    }
}