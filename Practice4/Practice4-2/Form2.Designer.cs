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
			this.label1 = new System.Windows.Forms.Label();
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
			this.panel1 = new System.Windows.Forms.Panel();
			this.sickle_button = new System.Windows.Forms.RadioButton();
			this.f_button = new System.Windows.Forms.RadioButton();
			this.seed_button = new System.Windows.Forms.RadioButton();
			this.button10 = new System.Windows.Forms.Button();
			this.button11 = new System.Windows.Forms.Button();
			this.button12 = new System.Windows.Forms.Button();
			this.panel1.SuspendLayout();
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
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("新細明體", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.label1.ImageList = this.imageList1;
			this.label1.Location = new System.Drawing.Point(445, 376);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(87, 41);
			this.label1.TabIndex = 0;
			this.label1.Text = "工具";
			// 
			// button1
			// 
			this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.button1.ImageIndex = 0;
			this.button1.ImageList = this.imageList1;
			this.button1.Location = new System.Drawing.Point(37, 15);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(115, 104);
			this.button1.TabIndex = 1;
			this.button1.Text = "button1";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.padlock_Click);
			// 
			// button2
			// 
			this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.button2.ImageIndex = 0;
			this.button2.ImageList = this.imageList1;
			this.button2.Location = new System.Drawing.Point(176, 15);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(115, 104);
			this.button2.TabIndex = 2;
			this.button2.Text = "button2";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.padlock_Click);
			// 
			// button3
			// 
			this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.button3.ImageIndex = 0;
			this.button3.ImageList = this.imageList1;
			this.button3.Location = new System.Drawing.Point(324, 15);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(115, 104);
			this.button3.TabIndex = 3;
			this.button3.Text = "button3";
			this.button3.UseVisualStyleBackColor = true;
			this.button3.Click += new System.EventHandler(this.padlock_Click);
			// 
			// button4
			// 
			this.button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.button4.ImageIndex = 0;
			this.button4.ImageList = this.imageList1;
			this.button4.Location = new System.Drawing.Point(37, 156);
			this.button4.Name = "button4";
			this.button4.Size = new System.Drawing.Size(115, 104);
			this.button4.TabIndex = 4;
			this.button4.Text = "button4";
			this.button4.UseVisualStyleBackColor = true;
			this.button4.Click += new System.EventHandler(this.padlock_Click);
			// 
			// button5
			// 
			this.button5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.button5.ImageIndex = 0;
			this.button5.ImageList = this.imageList1;
			this.button5.Location = new System.Drawing.Point(176, 156);
			this.button5.Name = "button5";
			this.button5.Size = new System.Drawing.Size(115, 104);
			this.button5.TabIndex = 5;
			this.button5.Text = "button5";
			this.button5.UseVisualStyleBackColor = true;
			this.button5.Click += new System.EventHandler(this.padlock_Click);
			// 
			// button6
			// 
			this.button6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.button6.ImageIndex = 0;
			this.button6.ImageList = this.imageList1;
			this.button6.Location = new System.Drawing.Point(324, 156);
			this.button6.Name = "button6";
			this.button6.Size = new System.Drawing.Size(115, 104);
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
			this.button7.Location = new System.Drawing.Point(37, 300);
			this.button7.Name = "button7";
			this.button7.Size = new System.Drawing.Size(115, 104);
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
			this.button8.Location = new System.Drawing.Point(176, 300);
			this.button8.Name = "button8";
			this.button8.Size = new System.Drawing.Size(115, 104);
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
			this.button9.Location = new System.Drawing.Point(324, 300);
			this.button9.Name = "button9";
			this.button9.Size = new System.Drawing.Size(115, 104);
			this.button9.TabIndex = 9;
			this.button9.Text = "button9";
			this.button9.UseVisualStyleBackColor = true;
			this.button9.Click += new System.EventHandler(this.padlock_Click);
			// 
			// kettle_button
			// 
			this.kettle_button.Location = new System.Drawing.Point(3, -6);
			this.kettle_button.Name = "kettle_button";
			this.kettle_button.Size = new System.Drawing.Size(100, 100);
			this.kettle_button.TabIndex = 10;
			this.kettle_button.TabStop = true;
			this.kettle_button.Text = "澆水壺";
			this.kettle_button.UseVisualStyleBackColor = true;
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.sickle_button);
			this.panel1.Controls.Add(this.f_button);
			this.panel1.Controls.Add(this.seed_button);
			this.panel1.Controls.Add(this.kettle_button);
			this.panel1.Location = new System.Drawing.Point(455, 420);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(506, 94);
			this.panel1.TabIndex = 11;
			// 
			// sickle_button
			// 
			this.sickle_button.Location = new System.Drawing.Point(395, -6);
			this.sickle_button.Name = "sickle_button";
			this.sickle_button.Size = new System.Drawing.Size(108, 100);
			this.sickle_button.TabIndex = 13;
			this.sickle_button.TabStop = true;
			this.sickle_button.Text = "鐮刀";
			this.sickle_button.UseVisualStyleBackColor = true;
			// 
			// f_button
			// 
			this.f_button.Location = new System.Drawing.Point(262, -6);
			this.f_button.Name = "f_button";
			this.f_button.Size = new System.Drawing.Size(106, 100);
			this.f_button.TabIndex = 12;
			this.f_button.TabStop = true;
			this.f_button.Text = "肥料";
			this.f_button.UseVisualStyleBackColor = true;
			// 
			// seed_button
			// 
			this.seed_button.Location = new System.Drawing.Point(109, -6);
			this.seed_button.Name = "seed_button";
			this.seed_button.Size = new System.Drawing.Size(128, 100);
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
			this.button10.Location = new System.Drawing.Point(37, 425);
			this.button10.Name = "button10";
			this.button10.Size = new System.Drawing.Size(115, 104);
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
			this.button11.Location = new System.Drawing.Point(176, 425);
			this.button11.Name = "button11";
			this.button11.Size = new System.Drawing.Size(115, 104);
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
			this.button12.Location = new System.Drawing.Point(324, 425);
			this.button12.Name = "button12";
			this.button12.Size = new System.Drawing.Size(115, 104);
			this.button12.TabIndex = 14;
			this.button12.Text = "button12";
			this.button12.UseVisualStyleBackColor = true;
			this.button12.Click += new System.EventHandler(this.padlock_Click);
			// 
			// Form2
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(973, 541);
			this.Controls.Add(this.button12);
			this.Controls.Add(this.button11);
			this.Controls.Add(this.button10);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.button9);
			this.Controls.Add(this.button8);
			this.Controls.Add(this.button7);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.button6);
			this.Controls.Add(this.button5);
			this.Controls.Add(this.button4);
			this.Controls.Add(this.button3);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.button1);
			this.Name = "Form2";
			this.Text = "Form2";
			this.panel1.ResumeLayout(false);
			this.ResumeLayout(false);
		}

		private System.Windows.Forms.Button button10;
		private System.Windows.Forms.Button button11;
		private System.Windows.Forms.Button button12;

		private System.Windows.Forms.RadioButton seed_button;
		private System.Windows.Forms.RadioButton f_button;
		private System.Windows.Forms.RadioButton sickle_button;

		private System.Windows.Forms.RadioButton kettle_button;
		private System.Windows.Forms.Panel panel1;

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
		private System.Windows.Forms.Label label1;

		#endregion
	}
}