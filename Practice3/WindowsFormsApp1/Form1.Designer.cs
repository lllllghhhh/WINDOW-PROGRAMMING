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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // input_data
            // 
            this.input_data.Font = new System.Drawing.Font("新細明體", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.input_data.Location = new System.Drawing.Point(340, 10);
            this.input_data.Name = "input_data";
            this.input_data.Size = new System.Drawing.Size(120, 27);
            this.input_data.TabIndex = 0;
            this.input_data.Text = "資料輸入";
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
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(250, 80);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(300, 29);
            this.textBox1.TabIndex = 6;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(250, 140);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(300, 29);
            this.textBox2.TabIndex = 7;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(250, 200);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(300, 29);
            this.textBox3.TabIndex = 8;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(250, 260);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(300, 29);
            this.textBox4.TabIndex = 9;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(250, 320);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(300, 29);
            this.textBox5.TabIndex = 10;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(120, 420);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(300, 30);
            this.button1.TabIndex = 11;
            this.button1.Text = "AI大神請告訴我答案吧";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(800, 500);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
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

        private System.Windows.Forms.Button button1;

        private System.Windows.Forms.Label input_data;
        private System.Windows.Forms.Label input_name;
        private System.Windows.Forms.Label input_gender;
        private System.Windows.Forms.Label input_birth;
        private System.Windows.Forms.Label input_today;
        private System.Windows.Forms.Label input_doc;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;

        #endregion
    }
}