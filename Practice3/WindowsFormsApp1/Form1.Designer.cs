namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.input_data = new System.Windows.Forms.Label();
            this.input_name = new System.Windows.Forms.Label();
            this.input_gender = new System.Windows.Forms.Label();
            this.input_birth = new System.Windows.Forms.Label();
            this.input_today = new System.Windows.Forms.Label();
            this.input_doc = new System.Windows.Forms.Label();
            this.Name_text = new System.Windows.Forms.TextBox();
            this.gender_text = new System.Windows.Forms.TextBox();
            this.birth_text = new System.Windows.Forms.TextBox();
            this.today_text = new System.Windows.Forms.TextBox();
            this.doc_text = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.Name_check = new System.Windows.Forms.Label();
            this.gender_check = new System.Windows.Forms.Label();
            this.birth_check = new System.Windows.Forms.Label();
            this.today_check = new System.Windows.Forms.Label();
            this.doc_check = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // input_data
            // 
            this.input_data.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.input_data.Location = new System.Drawing.Point(340, 10);
            this.input_data.Name = "input_data";
            this.input_data.Size = new System.Drawing.Size(120, 27);
            this.input_data.TabIndex = 0;
            this.input_data.Text = "資料輸入";
            this.input_data.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // input_name
            // 
            this.input_name.Location = new System.Drawing.Point(120, 80);
            this.input_name.Name = "input_name";
            this.input_name.Size = new System.Drawing.Size(120, 30);
            this.input_name.TabIndex = 1;
            this.input_name.Text = "姓名";
            this.input_name.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // input_gender
            // 
            this.input_gender.Location = new System.Drawing.Point(120, 140);
            this.input_gender.Name = "input_gender";
            this.input_gender.Size = new System.Drawing.Size(120, 30);
            this.input_gender.TabIndex = 2;
            this.input_gender.Text = "性別";
            this.input_gender.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // input_birth
            // 
            this.input_birth.Location = new System.Drawing.Point(120, 200);
            this.input_birth.Name = "input_birth";
            this.input_birth.Size = new System.Drawing.Size(120, 30);
            this.input_birth.TabIndex = 3;
            this.input_birth.Text = "出生年月日";
            this.input_birth.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // input_today
            // 
            this.input_today.Location = new System.Drawing.Point(120, 260);
            this.input_today.Name = "input_today";
            this.input_today.Size = new System.Drawing.Size(120, 30);
            this.input_today.TabIndex = 4;
            this.input_today.Text = "今日日期";
            this.input_today.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // input_doc
            // 
            this.input_doc.Location = new System.Drawing.Point(120, 320);
            this.input_doc.Name = "input_doc";
            this.input_doc.Size = new System.Drawing.Size(120, 30);
            this.input_doc.TabIndex = 5;
            this.input_doc.Text = "狗派or貓派";
            this.input_doc.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Name_text
            // 
            this.Name_text.Location = new System.Drawing.Point(250, 80);
            this.Name_text.Name = "Name_text";
            this.Name_text.Size = new System.Drawing.Size(300, 29);
            this.Name_text.TabIndex = 6;
            // 
            // gender_text
            // 
            this.gender_text.Location = new System.Drawing.Point(250, 140);
            this.gender_text.Name = "gender_text";
            this.gender_text.Size = new System.Drawing.Size(300, 29);
            this.gender_text.TabIndex = 7;
            // 
            // birth_text
            // 
            this.birth_text.Location = new System.Drawing.Point(250, 200);
            this.birth_text.Name = "birth_text";
            this.birth_text.Size = new System.Drawing.Size(300, 29);
            this.birth_text.TabIndex = 8;
            // 
            // today_text
            // 
            this.today_text.Location = new System.Drawing.Point(250, 260);
            this.today_text.Name = "today_text";
            this.today_text.Size = new System.Drawing.Size(300, 29);
            this.today_text.TabIndex = 9;
            // 
            // doc_text
            // 
            this.doc_text.Location = new System.Drawing.Point(250, 320);
            this.doc_text.Name = "doc_text";
            this.doc_text.Size = new System.Drawing.Size(300, 29);
            this.doc_text.TabIndex = 10;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(250, 420);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(300, 30);
            this.button1.TabIndex = 11;
            this.button1.Text = "AI大神請告訴我答案吧";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Name_check
            // 
            this.Name_check.Location = new System.Drawing.Point(577, 83);
            this.Name_check.Name = "Name_check";
            this.Name_check.Size = new System.Drawing.Size(142, 26);
            this.Name_check.TabIndex = 12;
            this.Name_check.Text = "此欄未填寫";
            this.Name_check.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gender_check
            // 
            this.gender_check.Location = new System.Drawing.Point(577, 140);
            this.gender_check.Name = "gender_check";
            this.gender_check.Size = new System.Drawing.Size(142, 26);
            this.gender_check.TabIndex = 13;
            this.gender_check.Text = "此欄未填寫";
            this.gender_check.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // birth_check
            // 
            this.birth_check.Location = new System.Drawing.Point(577, 200);
            this.birth_check.Name = "birth_check";
            this.birth_check.Size = new System.Drawing.Size(142, 26);
            this.birth_check.TabIndex = 14;
            this.birth_check.Text = "此欄未填寫";
            this.birth_check.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // today_check
            // 
            this.today_check.Location = new System.Drawing.Point(577, 260);
            this.today_check.Name = "today_check";
            this.today_check.Size = new System.Drawing.Size(142, 26);
            this.today_check.TabIndex = 15;
            this.today_check.Text = "此欄未填寫";
            this.today_check.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // doc_check
            // 
            this.doc_check.Location = new System.Drawing.Point(577, 320);
            this.doc_check.Name = "doc_check";
            this.doc_check.Size = new System.Drawing.Size(142, 26);
            this.doc_check.TabIndex = 16;
            this.doc_check.Text = "此欄未填寫";
            this.doc_check.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(800, 500);
            this.Controls.Add(this.doc_check);
            this.Controls.Add(this.today_check);
            this.Controls.Add(this.birth_check);
            this.Controls.Add(this.gender_check);
            this.Controls.Add(this.Name_check);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.doc_text);
            this.Controls.Add(this.today_text);
            this.Controls.Add(this.birth_text);
            this.Controls.Add(this.gender_text);
            this.Controls.Add(this.Name_text);
            this.Controls.Add(this.input_doc);
            this.Controls.Add(this.input_today);
            this.Controls.Add(this.input_birth);
            this.Controls.Add(this.input_gender);
            this.Controls.Add(this.input_name);
            this.Controls.Add(this.input_data);
            this.Location = new System.Drawing.Point(15, 15);
            this.Name = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Label Name_check;
        private System.Windows.Forms.Label gender_check;
        private System.Windows.Forms.Label birth_check;
        private System.Windows.Forms.Label today_check;
        private System.Windows.Forms.Label doc_check;

        private System.Windows.Forms.Button button1;

        private System.Windows.Forms.Label input_data;
        private System.Windows.Forms.Label input_name;
        private System.Windows.Forms.Label input_gender;
        private System.Windows.Forms.Label input_birth;
        private System.Windows.Forms.Label input_today;
        private System.Windows.Forms.Label input_doc;
        private System.Windows.Forms.TextBox Name_text;
        private System.Windows.Forms.TextBox gender_text;
        private System.Windows.Forms.TextBox birth_text;
        private System.Windows.Forms.TextBox today_text;
        private System.Windows.Forms.TextBox doc_text;

        #endregion
    }
}