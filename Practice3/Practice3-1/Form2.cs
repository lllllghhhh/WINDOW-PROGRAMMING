using System;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form2 : Form
    {
        public Form2(string name, string gender, string birth, string today, string doc)
        {
            InitializeComponent();
            name_1.Text = name;
            gender_1.Text = gender;
            birth_1.Text = birth;
            today_1.Text = today;
            doc_1.Text = doc;
        }
        
        
    }
}