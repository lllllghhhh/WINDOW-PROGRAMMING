using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form2 : Form {
        
        private static List<string> analysis = new List<string>
        {
            "貴人相助，好消息和機會降臨。",
            "財運亨通，意外之財進帳，心情愉快。",
            "感情順利，關係緊密，互相支持。",
            "工作順利，努力獲認可，升職加薪有望。",
            "健康上升，精神飽滿，適合活動和挑戰。"
        };

        private static List<string> suggest = new List<string>
        {
            "不斷學習，提升自我價值。",
            "維持健康，增強生活品質。",
            "建立良好人際關係。",
            "設定目標，努力實現。",
            "管理時間，減少壓力。"
        };

        private static Random rng = new Random();

        public Form2(string name, string gender, string birth, string today, string doc, Form parent_form)
        {
            InitializeComponent();
            name_1.Text = name;
            gender_1.Text = gender;
            birth_1.Text = birth;
            today_1.Text = today;
            doc_1.Text = doc;
            FormClosed += delegate { parent_form.Show(); };  // delegate replace function
            fortune.Text = "運勢：" + analysis[rng.Next() % 5];
            suggestion.Text = "建議：" + suggest[rng.Next() % 5];
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}