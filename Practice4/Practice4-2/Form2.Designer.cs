using System.ComponentModel;

namespace Practice4_2
{
	partial class Form2
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null)) {
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
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
			this.imageList1 = new System.Windows.Forms.ImageList(this.components);
			this.button1 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.button3 = new System.Windows.Forms.Button();
			this.button4 = new System.Windows.Forms.Button();
			this.button5 = new System.Windows.Forms.Button();
			this.button6 = new System.Windows.Forms.Button();
			this.button7 = new System.Windows.Forms.Button();
			this.button8 = new System.Windows.Forms.Button();
			this.button9 = new System.Windows.Forms.Button();
			this.kettle_button = new System.Windows.Forms.RadioButton();
			this.sickle_button = new System.Windows.Forms.RadioButton();
			this.f_button = new System.Windows.Forms.RadioButton();
			this.seed_button = new System.Windows.Forms.RadioButton();
			this.button10 = new System.Windows.Forms.Button();
			this.button11 = new System.Windows.Forms.Button();
			this.button12 = new System.Windows.Forms.Button();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.tabControl1 = new System.Windows.Forms.TabControl();
			this.tabPage1 = new System.Windows.Forms.TabPage();
			this.buttton = new System.Windows.Forms.Button();
			this.fruit = new System.Windows.Forms.Label();
			this.fertilizer = new System.Windows.Forms.Label();
			this.seed = new System.Windows.Forms.Label();
			this.fruit_check = new System.Windows.Forms.CheckBox();
			this.f_check = new System.Windows.Forms.CheckBox();
			this.seed_check = new System.Windows.Forms.CheckBox();
			this.label8 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.tabPage2 = new System.Windows.Forms.TabPage();
			this.button13 = new System.Windows.Forms.Button();
			this.groupBox1.SuspendLayout();
			this.tabControl1.SuspendLayout();
			this.tabPage1.SuspendLayout();
			this.tabPage2.SuspendLayout();
			this.SuspendLayout();
			// 
			// imageList1
			// 
			this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
			this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
			this.imageList1.Images.SetKeyName(0, "dirt.jpeg");
			this.imageList1.Images.SetKeyName(1, "seed.jpg");
			this.imageList1.Images.SetKeyName(2, "crop.jpg");
			this.imageList1.Images.SetKeyName(3, "watermelon.jpg");
			// 
			// button1
			// 
			this.button1.BackColor = System.Drawing.SystemColors.ButtonFace;
			this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.button1.ImageIndex = 0;
			this.button1.ImageList = this.imageList1;
			this.button1.Location = new System.Drawing.Point(0, 6);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(128, 128);
			this.button1.TabIndex = 1;
			this.button1.Tag = "0";
			this.button1.Text = "button1";
			this.button1.UseVisualStyleBackColor = false;
			this.button1.Click += new System.EventHandler(this.padlock_Click);
			// 
			// button2
			// 
			this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.button2.ImageIndex = 0;
			this.button2.ImageList = this.imageList1;
			this.button2.Location = new System.Drawing.Point(134, 6);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(128, 128);
			this.button2.TabIndex = 2;
			this.button2.Tag = "1";
			this.button2.Text = "button2";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.padlock_Click);
			// 
			// button3
			// 
			this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.button3.ImageIndex = 0;
			this.button3.ImageList = this.imageList1;
			this.button3.Location = new System.Drawing.Point(268, 6);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(128, 128);
			this.button3.TabIndex = 3;
			this.button3.Tag = "2";
			this.button3.Text = "button3";
			this.button3.UseVisualStyleBackColor = true;
			this.button3.Click += new System.EventHandler(this.padlock_Click);
			// 
			// button4
			// 
			this.button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.button4.ImageIndex = 0;
			this.button4.ImageList = this.imageList1;
			this.button4.Location = new System.Drawing.Point(0, 129);
			this.button4.Name = "button4";
			this.button4.Size = new System.Drawing.Size(128, 128);
			this.button4.TabIndex = 4;
			this.button4.Tag = "3";
			this.button4.Text = "button4";
			this.button4.UseVisualStyleBackColor = true;
			this.button4.Click += new System.EventHandler(this.padlock_Click);
			// 
			// button5
			// 
			this.button5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.button5.ImageIndex = 0;
			this.button5.ImageList = this.imageList1;
			this.button5.Location = new System.Drawing.Point(134, 129);
			this.button5.Name = "button5";
			this.button5.Size = new System.Drawing.Size(128, 128);
			this.button5.TabIndex = 5;
			this.button5.Tag = "5";
			this.button5.Text = "button5";
			this.button5.UseVisualStyleBackColor = true;
			this.button5.Click += new System.EventHandler(this.padlock_Click);
			// 
			// button6
			// 
			this.button6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.button6.ImageIndex = 0;
			this.button6.ImageList = this.imageList1;
			this.button6.Location = new System.Drawing.Point(268, 129);
			this.button6.Name = "button6";
			this.button6.Size = new System.Drawing.Size(128, 128);
			this.button6.TabIndex = 6;
			this.button6.Text = "button6";
			this.button6.UseVisualStyleBackColor = true;
			this.button6.Click += new System.EventHandler(this.padlock_Click);
			// 
			// button7
			// 
			this.button7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.button7.ImageIndex = 0;
			this.button7.ImageList = this.imageList1;
			this.button7.Location = new System.Drawing.Point(0, 251);
			this.button7.Name = "button7";
			this.button7.Size = new System.Drawing.Size(128, 128);
			this.button7.TabIndex = 7;
			this.button7.Text = "button7";
			this.button7.UseVisualStyleBackColor = true;
			this.button7.Click += new System.EventHandler(this.padlock_Click);
			// 
			// button8
			// 
			this.button8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.button8.ImageIndex = 0;
			this.button8.ImageList = this.imageList1;
			this.button8.Location = new System.Drawing.Point(134, 251);
			this.button8.Name = "button8";
			this.button8.Size = new System.Drawing.Size(128, 128);
			this.button8.TabIndex = 8;
			this.button8.Text = "button8";
			this.button8.UseVisualStyleBackColor = true;
			this.button8.Click += new System.EventHandler(this.padlock_Click);
			// 
			// button9
			// 
			this.button9.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.button9.ImageIndex = 0;
			this.button9.ImageList = this.imageList1;
			this.button9.Location = new System.Drawing.Point(268, 251);
			this.button9.Name = "button9";
			this.button9.Size = new System.Drawing.Size(128, 128);
			this.button9.TabIndex = 9;
			this.button9.Text = "button9";
			this.button9.UseVisualStyleBackColor = true;
			this.button9.Click += new System.EventHandler(this.padlock_Click);
			// 
			// kettle_button
			// 
			this.kettle_button.AutoSize = true;
			this.kettle_button.Location = new System.Drawing.Point(6, 28);
			this.kettle_button.Name = "kettle_button";
			this.kettle_button.Size = new System.Drawing.Size(107, 28);
			this.kettle_button.TabIndex = 10;
			this.kettle_button.TabStop = true;
			this.kettle_button.Text = "澆水壺";
			this.kettle_button.UseVisualStyleBackColor = true;
			// 
			// sickle_button
			// 
			this.sickle_button.AutoSize = true;
			this.sickle_button.Location = new System.Drawing.Point(306, 28);
			this.sickle_button.Name = "sickle_button";
			this.sickle_button.Size = new System.Drawing.Size(83, 28);
			this.sickle_button.TabIndex = 13;
			this.sickle_button.TabStop = true;
			this.sickle_button.Text = "鐮刀";
			this.sickle_button.UseVisualStyleBackColor = true;
			// 
			// f_button
			// 
			this.f_button.AutoSize = true;
			this.f_button.Location = new System.Drawing.Point(214, 28);
			this.f_button.Name = "f_button";
			this.f_button.Size = new System.Drawing.Size(83, 28);
			this.f_button.TabIndex = 12;
			this.f_button.TabStop = true;
			this.f_button.Text = "肥料";
			this.f_button.UseVisualStyleBackColor = true;
			// 
			// seed_button
			// 
			this.seed_button.AutoSize = true;
			this.seed_button.Location = new System.Drawing.Point(122, 28);
			this.seed_button.Name = "seed_button";
			this.seed_button.Size = new System.Drawing.Size(83, 28);
			this.seed_button.TabIndex = 11;
			this.seed_button.TabStop = true;
			this.seed_button.Text = "種子";
			this.seed_button.UseVisualStyleBackColor = true;
			// 
			// button10
			// 
			this.button10.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.button10.ImageIndex = 0;
			this.button10.ImageList = this.imageList1;
			this.button10.Location = new System.Drawing.Point(0, 378);
			this.button10.Name = "button10";
			this.button10.Size = new System.Drawing.Size(128, 128);
			this.button10.TabIndex = 12;
			this.button10.Text = "button10";
			this.button10.UseVisualStyleBackColor = true;
			this.button10.Click += new System.EventHandler(this.padlock_Click);
			// 
			// button11
			// 
			this.button11.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.button11.ImageIndex = 0;
			this.button11.ImageList = this.imageList1;
			this.button11.Location = new System.Drawing.Point(134, 378);
			this.button11.Name = "button11";
			this.button11.Size = new System.Drawing.Size(128, 128);
			this.button11.TabIndex = 13;
			this.button11.Text = "button11";
			this.button11.UseVisualStyleBackColor = true;
			this.button11.Click += new System.EventHandler(this.padlock_Click);
			// 
			// button12
			// 
			this.button12.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.button12.ImageIndex = 0;
			this.button12.ImageList = this.imageList1;
			this.button12.Location = new System.Drawing.Point(268, 378);
			this.button12.Name = "button12";
			this.button12.Size = new System.Drawing.Size(128, 128);
			this.button12.TabIndex = 14;
			this.button12.Text = "button12";
			this.button12.UseVisualStyleBackColor = true;
			this.button12.Click += new System.EventHandler(this.padlock_Click);
			// 
			// groupBox1
			// 
			this.groupBox1.AutoSize = true;
			this.groupBox1.Controls.Add(this.kettle_button);
			this.groupBox1.Controls.Add(this.sickle_button);
			this.groupBox1.Controls.Add(this.f_button);
			this.groupBox1.Controls.Add(this.seed_button);
			this.groupBox1.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBox1.Location = new System.Drawing.Point(420, 392);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(540, 120);
			this.groupBox1.TabIndex = 15;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "工具";
			// 
			// tabControl1
			// 
			this.tabControl1.Controls.Add(this.tabPage1);
			this.tabControl1.Controls.Add(this.tabPage2);
			this.tabControl1.Location = new System.Drawing.Point(0, 0);
			this.tabControl1.Name = "tabControl1";
			this.tabControl1.SelectedIndex = 0;
			this.tabControl1.Size = new System.Drawing.Size(977, 541);
			this.tabControl1.TabIndex = 16;
			this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
			// 
			// tabPage1
			// 
			this.tabPage1.Controls.Add(this.buttton);
			this.tabPage1.Controls.Add(this.fruit);
			this.tabPage1.Controls.Add(this.fertilizer);
			this.tabPage1.Controls.Add(this.seed);
			this.tabPage1.Controls.Add(this.fruit_check);
			this.tabPage1.Controls.Add(this.f_check);
			this.tabPage1.Controls.Add(this.seed_check);
			this.tabPage1.Controls.Add(this.label8);
			this.tabPage1.Controls.Add(this.label7);
			this.tabPage1.Controls.Add(this.label6);
			this.tabPage1.Controls.Add(this.label5);
			this.tabPage1.Controls.Add(this.label4);
			this.tabPage1.Controls.Add(this.label3);
			this.tabPage1.Controls.Add(this.label2);
			this.tabPage1.Controls.Add(this.label1);
			this.tabPage1.Location = new System.Drawing.Point(4, 28);
			this.tabPage1.Name = "tabPage1";
			this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage1.Size = new System.Drawing.Size(969, 509);
			this.tabPage1.TabIndex = 0;
			this.tabPage1.Text = "tabPage1";
			this.tabPage1.UseVisualStyleBackColor = true;
			// 
			// buttton
			// 
			this.buttton.Location = new System.Drawing.Point(257, 330);
			this.buttton.Name = "buttton";
			this.buttton.Size = new System.Drawing.Size(191, 53);
			this.buttton.TabIndex = 14;
			this.buttton.Text = "買/賣";
			this.buttton.UseVisualStyleBackColor = true;
			this.buttton.Click += new System.EventHandler(this.button1_Click);
			// 
			// fruit
			// 
			this.fruit.Font = new System.Drawing.Font("新細明體", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.fruit.Location = new System.Drawing.Point(613, 244);
			this.fruit.Name = "fruit";
			this.fruit.Size = new System.Drawing.Size(70, 34);
			this.fruit.TabIndex = 13;
			this.fruit.Text = "0";
			// 
			// fertilizer
			// 
			this.fertilizer.Font = new System.Drawing.Font("新細明體", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.fertilizer.Location = new System.Drawing.Point(379, 245);
			this.fertilizer.Name = "fertilizer";
			this.fertilizer.Size = new System.Drawing.Size(70, 34);
			this.fertilizer.TabIndex = 12;
			this.fertilizer.Text = "5";
			// 
			// seed
			// 
			this.seed.Font = new System.Drawing.Font("新細明體", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.seed.Location = new System.Drawing.Point(186, 245);
			this.seed.Name = "seed";
			this.seed.Size = new System.Drawing.Size(63, 33);
			this.seed.TabIndex = 11;
			this.seed.Text = "5";
			// 
			// fruit_check
			// 
			this.fruit_check.Location = new System.Drawing.Point(502, 178);
			this.fruit_check.Name = "fruit_check";
			this.fruit_check.Size = new System.Drawing.Size(18, 18);
			this.fruit_check.TabIndex = 10;
			this.fruit_check.Text = "checkBox3";
			this.fruit_check.UseVisualStyleBackColor = true;
			// 
			// f_check
			// 
			this.f_check.Location = new System.Drawing.Point(280, 178);
			this.f_check.Name = "f_check";
			this.f_check.Size = new System.Drawing.Size(18, 18);
			this.f_check.TabIndex = 9;
			this.f_check.Text = "checkBox2";
			this.f_check.UseVisualStyleBackColor = true;
			// 
			// seed_check
			// 
			this.seed_check.Location = new System.Drawing.Point(77, 178);
			this.seed_check.Name = "seed_check";
			this.seed_check.Size = new System.Drawing.Size(18, 18);
			this.seed_check.TabIndex = 8;
			this.seed_check.Text = "checkBox1";
			this.seed_check.UseVisualStyleBackColor = true;
			// 
			// label8
			// 
			this.label8.Font = new System.Drawing.Font("新細明體", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.label8.Location = new System.Drawing.Point(526, 240);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(108, 33);
			this.label8.TabIndex = 7;
			this.label8.Text = "擁有：";
			// 
			// label7
			// 
			this.label7.Font = new System.Drawing.Font("新細明體", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.label7.Location = new System.Drawing.Point(294, 240);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(108, 33);
			this.label7.TabIndex = 6;
			this.label7.Text = "擁有：";
			// 
			// label6
			// 
			this.label6.Font = new System.Drawing.Font("新細明體", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.label6.Location = new System.Drawing.Point(101, 240);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(108, 33);
			this.label6.TabIndex = 5;
			this.label6.Text = "擁有：";
			// 
			// label5
			// 
			this.label5.Font = new System.Drawing.Font("新細明體", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.label5.Location = new System.Drawing.Point(526, 165);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(108, 33);
			this.label5.TabIndex = 4;
			this.label5.Text = "果實";
			// 
			// label4
			// 
			this.label4.Font = new System.Drawing.Font("新細明體", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.label4.Location = new System.Drawing.Point(294, 165);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(108, 33);
			this.label4.TabIndex = 3;
			this.label4.Text = "肥料";
			// 
			// label3
			// 
			this.label3.Font = new System.Drawing.Font("新細明體", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.label3.Location = new System.Drawing.Point(101, 165);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(108, 33);
			this.label3.TabIndex = 2;
			this.label3.Text = "種子";
			// 
			// label2
			// 
			this.label2.Font = new System.Drawing.Font("新細明體", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.label2.Location = new System.Drawing.Point(359, 52);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(75, 39);
			this.label2.TabIndex = 1;
			this.label2.Text = "100";
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("新細明體", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.label1.Location = new System.Drawing.Point(226, 52);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(111, 51);
			this.label1.TabIndex = 0;
			this.label1.Text = "金錢:";
			// 
			// tabPage2
			// 
			this.tabPage2.Controls.Add(this.button1);
			this.tabPage2.Controls.Add(this.groupBox1);
			this.tabPage2.Controls.Add(this.button2);
			this.tabPage2.Controls.Add(this.button10);
			this.tabPage2.Controls.Add(this.button11);
			this.tabPage2.Controls.Add(this.button12);
			this.tabPage2.Controls.Add(this.button3);
			this.tabPage2.Controls.Add(this.button7);
			this.tabPage2.Controls.Add(this.button4);
			this.tabPage2.Controls.Add(this.button9);
			this.tabPage2.Controls.Add(this.button5);
			this.tabPage2.Controls.Add(this.button8);
			this.tabPage2.Controls.Add(this.button6);
			this.tabPage2.Location = new System.Drawing.Point(4, 28);
			this.tabPage2.Name = "tabPage2";
			this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage2.Size = new System.Drawing.Size(969, 509);
			this.tabPage2.TabIndex = 1;
			this.tabPage2.Text = "tabPage2";
			this.tabPage2.UseVisualStyleBackColor = true;
			// 
			// button13
			// 
			this.button13.Location = new System.Drawing.Point(257, 330);
			this.button13.Name = "button13";
			this.button13.Size = new System.Drawing.Size(191, 53);
			this.button13.TabIndex = 14;
			this.button13.Text = "買/賣";
			this.button13.UseVisualStyleBackColor = true;
			// 
			// Form2
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.ClientSize = new System.Drawing.Size(973, 541);
			this.Controls.Add(this.tabControl1);
			this.Name = "Form2";
			this.Text = "Form2";
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.tabControl1.ResumeLayout(false);
			this.tabPage1.ResumeLayout(false);
			this.tabPage2.ResumeLayout(false);
			this.tabPage2.PerformLayout();
			this.ResumeLayout(false);
		}

		private System.Windows.Forms.Button button13;

		private System.Windows.Forms.Button buttton;

		private System.Windows.Forms.Label seed;
		private System.Windows.Forms.Label fertilizer;
		private System.Windows.Forms.Label fruit;

		private System.Windows.Forms.CheckBox seed_check;
		private System.Windows.Forms.CheckBox f_check;
		private System.Windows.Forms.CheckBox fruit_check;

		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label8;

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;

		private System.Windows.Forms.TabControl tabControl1;
		private System.Windows.Forms.TabPage tabPage1;
		private System.Windows.Forms.TabPage tabPage2;

		private System.Windows.Forms.GroupBox groupBox1;

		private System.Windows.Forms.Button button10;
		private System.Windows.Forms.Button button11;
		private System.Windows.Forms.Button button12;

		private System.Windows.Forms.RadioButton seed_button;
		private System.Windows.Forms.RadioButton f_button;
		private System.Windows.Forms.RadioButton sickle_button;

		private System.Windows.Forms.RadioButton kettle_button;

		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.Button button4;
		private System.Windows.Forms.Button button5;
		private System.Windows.Forms.Button button6;
		private System.Windows.Forms.Button button7;
		private System.Windows.Forms.Button button8;
		private System.Windows.Forms.Button button9;

		private System.Windows.Forms.Button button1;

		private System.Windows.Forms.ImageList imageList1;

		#endregion
	}
}