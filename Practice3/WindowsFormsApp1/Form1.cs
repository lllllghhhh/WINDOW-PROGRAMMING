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
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Name_text.Text != null)
            {
                Name_check.Hide();
            }
            if (gender_text.Text != null)
            {
                gender_check.Hide();
            }
            if (birth_text.Text != null)
            {
                birth_check.Hide();
            }
            if (today_text.Text != null)
            {
                today_check.Hide();
            }
            if (doc_text.Text != null)
            {
                doc_check.Hide();
            }
        }
    }
}