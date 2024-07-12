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
            this.AutoValidate = AutoValidate.EnableAllowFocusChange;
            Name_check.Validating += Name_text_Validating;
            Name_check.Text = gender_check.Text = birth_check.Text = today_check.Text = doc_check.Text = "";
        }

        private void Name_text_Validating(object sender, CancelEventArgs e)
        {
            e.Cancel = true;
            Name_check.Text = "don't leave me empty!!";
            Name_check.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool is_validated = true;
            if (name_text.Text.Length == 0) /// .Text is always not null
            {
                Name_check.Text = "此欄位未填寫";
                is_validated = false;
            }
            else
                Name_check.Text = "";
            if (gender_text.Text.Length == 0)
            {
                gender_check.Text = "此欄位未填寫";
                is_validated = false;
            }
            else if (gender_text.Text != "男" && gender_text.Text != "女") {
                gender_check.Text = "輸入應為男or女";
                is_validated = false;
            }
            else
                gender_check.Text = "";

            if (birth_text.Text.Length == 0) {
                birth_check.Text = "此欄位未填寫";
                is_validated = false;
            }
            else
                birth_check.Text = "";

            if (today_text.Text.Length == 0) {
                today_check.Text = "此欄位未填寫";
                is_validated = false;
            }
            else
                today_check.Text = "";
            
            if (doc_text.Text.Length == 0) {
                doc_check.Text = "此欄位未填寫";
                is_validated = false;
            }
            else if (doc_text.Text != "貓" && doc_text.Text != "狗") {
                doc_check.Text = "輸入應為貓or狗";
                doc_check.Show();
                is_validated = false;
            }
            else
                doc_check.Text = "";

            if (is_validated) {
                this.Hide();
                var f = new Form2(name_text.Text, gender_text.Text, birth_text.Text, today_text.Text, doc_text.Text, this);
                f.Show();
                name_text.Text = "";
                gender_text.Text = "";
                birth_text.Text = "";
                today_text.Text = "";
                doc_text.Text = "";
            }
        }
    }
}