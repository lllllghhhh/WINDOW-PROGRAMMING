namespace Practice4_1
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
			this.imageList1 = new System.Windows.Forms.ImageList(this.components);
			this.button1 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.button3 = new System.Windows.Forms.Button();
			this.button4 = new System.Windows.Forms.Button();
			this.button5 = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// imageList1
			// 
			this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
			this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
			this.imageList1.Images.SetKeyName(0, "0.jpg");
			this.imageList1.Images.SetKeyName(1, "1.jpg");
			this.imageList1.Images.SetKeyName(2, "2.jpg");
			this.imageList1.Images.SetKeyName(3, "3.jpg");
			this.imageList1.Images.SetKeyName(4, "4.jpg");
			this.imageList1.Images.SetKeyName(5, "5.jpg");
			this.imageList1.Images.SetKeyName(6, "6.jpg");
			this.imageList1.Images.SetKeyName(7, "7.jpg");
			this.imageList1.Images.SetKeyName(8, "8.jpg");
			this.imageList1.Images.SetKeyName(9, "9.jpg");
			// 
			// button1
			// 
			this.button1.ImageIndex = 0;
			this.button1.ImageList = this.imageList1;
			this.button1.Location = new System.Drawing.Point(250, 160);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(75, 120);
			this.button1.TabIndex = 0;
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.padlock_click);
			// 
			// button2
			// 
			this.button2.ImageIndex = 0;
			this.button2.ImageList = this.imageList1;
			this.button2.Location = new System.Drawing.Point(354, 160);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(75, 120);
			this.button2.TabIndex = 1;
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.padlock_click);
			// 
			// button3
			// 
			this.button3.ImageIndex = 0;
			this.button3.ImageList = this.imageList1;
			this.button3.Location = new System.Drawing.Point(459, 160);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(75, 120);
			this.button3.TabIndex = 2;
			this.button3.UseVisualStyleBackColor = true;
			this.button3.Click += new System.EventHandler(this.padlock_click);
			// 
			// button4
			// 
			this.button4.ImageIndex = 0;
			this.button4.ImageList = this.imageList1;
			this.button4.Location = new System.Drawing.Point(562, 160);
			this.button4.Name = "button4";
			this.button4.Size = new System.Drawing.Size(75, 120);
			this.button4.TabIndex = 3;
			this.button4.UseVisualStyleBackColor = true;
			this.button4.Click += new System.EventHandler(this.padlock_click);
			// 
			// button5
			// 
			this.button5.Font = new System.Drawing.Font("Consolas", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button5.Location = new System.Drawing.Point(270, 311);
			this.button5.Name = "button5";
			this.button5.Size = new System.Drawing.Size(352, 112);
			this.button5.TabIndex = 4;
			this.button5.Text = "Unlock";
			this.button5.UseVisualStyleBackColor = true;
			this.button5.Click += new System.EventHandler(this.button5_Click);
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(248, 80);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(76, 56);
			this.label1.TabIndex = 5;
			this.label1.Text = "label1";
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(353, 80);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(76, 56);
			this.label2.TabIndex = 6;
			this.label2.Text = "label2";
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(458, 80);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(76, 56);
			this.label3.TabIndex = 7;
			this.label3.Text = "label3";
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(561, 80);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(76, 56);
			this.label4.TabIndex = 8;
			this.label4.Text = "label4";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(885, 524);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.button5);
			this.Controls.Add(this.button4);
			this.Controls.Add(this.button3);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.button1);
			this.Name = "Form1";
			this.Text = "Form1";
			this.ResumeLayout(false);
		}

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;

		private System.Windows.Forms.Button button5;

		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.Button button4;

		private System.Windows.Forms.Button button1;

		private System.Windows.Forms.ImageList imageList1;

		#endregion
	}
}