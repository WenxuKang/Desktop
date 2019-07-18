namespace CustomizeAForm
{
	partial class YellowForm
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
			this.lblSelectionTitle = new System.Windows.Forms.Label();
			this.lblTitle = new System.Windows.Forms.Label();
			this.btnSave = new System.Windows.Forms.Button();
			this.tbTitle = new System.Windows.Forms.TextBox();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.rdbLarge = new System.Windows.Forms.RadioButton();
			this.rdbSmall = new System.Windows.Forms.RadioButton();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.rdbYellow = new System.Windows.Forms.RadioButton();
			this.rdbRed = new System.Windows.Forms.RadioButton();
			this.rbtBlue = new System.Windows.Forms.RadioButton();
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.SuspendLayout();
			// 
			// lblSelectionTitle
			// 
			this.lblSelectionTitle.AutoSize = true;
			this.lblSelectionTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblSelectionTitle.Location = new System.Drawing.Point(21, 9);
			this.lblSelectionTitle.Name = "lblSelectionTitle";
			this.lblSelectionTitle.Size = new System.Drawing.Size(141, 16);
			this.lblSelectionTitle.TabIndex = 0;
			this.lblSelectionTitle.Text = "Select form options";
			// 
			// lblTitle
			// 
			this.lblTitle.AutoSize = true;
			this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblTitle.Location = new System.Drawing.Point(39, 210);
			this.lblTitle.Name = "lblTitle";
			this.lblTitle.Size = new System.Drawing.Size(34, 16);
			this.lblTitle.TabIndex = 9;
			this.lblTitle.Text = "Title";
			// 
			// btnSave
			// 
			this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnSave.Location = new System.Drawing.Point(44, 254);
			this.btnSave.Name = "btnSave";
			this.btnSave.Size = new System.Drawing.Size(136, 23);
			this.btnSave.TabIndex = 10;
			this.btnSave.Text = "Save form settings";
			this.btnSave.UseVisualStyleBackColor = true;
			this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
			// 
			// tbTitle
			// 
			this.tbTitle.Location = new System.Drawing.Point(79, 210);
			this.tbTitle.Name = "tbTitle";
			this.tbTitle.Size = new System.Drawing.Size(281, 20);
			this.tbTitle.TabIndex = 11;
			this.tbTitle.Leave += new System.EventHandler(this.tbTitle_TextChanged);
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.rdbLarge);
			this.groupBox1.Controls.Add(this.rdbSmall);
			this.groupBox1.Location = new System.Drawing.Point(246, 45);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(134, 130);
			this.groupBox1.TabIndex = 12;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Size";
			// 
			// rdbLarge
			// 
			this.rdbLarge.AutoSize = true;
			this.rdbLarge.Location = new System.Drawing.Point(33, 48);
			this.rdbLarge.Name = "rdbLarge";
			this.rdbLarge.Size = new System.Drawing.Size(52, 17);
			this.rdbLarge.TabIndex = 9;
			this.rdbLarge.Text = "Large";
			this.rdbLarge.UseVisualStyleBackColor = true;
			this.rdbLarge.Click += new System.EventHandler(this.sizes_CheckedChanged);
			// 
			// rdbSmall
			// 
			this.rdbSmall.AutoSize = true;
			this.rdbSmall.Location = new System.Drawing.Point(33, 24);
			this.rdbSmall.Name = "rdbSmall";
			this.rdbSmall.Size = new System.Drawing.Size(50, 17);
			this.rdbSmall.TabIndex = 8;
			this.rdbSmall.Text = "Small";
			this.rdbSmall.UseVisualStyleBackColor = true;
			this.rdbSmall.Click += new System.EventHandler(this.sizes_CheckedChanged);
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.rdbYellow);
			this.groupBox2.Controls.Add(this.rdbRed);
			this.groupBox2.Controls.Add(this.rbtBlue);
			this.groupBox2.Location = new System.Drawing.Point(39, 39);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(149, 142);
			this.groupBox2.TabIndex = 13;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Color";
			// 
			// rdbYellow
			// 
			this.rdbYellow.AutoSize = true;
			this.rdbYellow.Location = new System.Drawing.Point(36, 77);
			this.rdbYellow.Name = "rdbYellow";
			this.rdbYellow.Size = new System.Drawing.Size(56, 17);
			this.rdbYellow.TabIndex = 7;
			this.rdbYellow.Text = "Yellow";
			this.rdbYellow.UseVisualStyleBackColor = true;
			this.rdbYellow.Click += new System.EventHandler(this.colors_CheckedChanged);
			// 
			// rdbRed
			// 
			this.rdbRed.AutoSize = true;
			this.rdbRed.Location = new System.Drawing.Point(36, 53);
			this.rdbRed.Name = "rdbRed";
			this.rdbRed.Size = new System.Drawing.Size(45, 17);
			this.rdbRed.TabIndex = 6;
			this.rdbRed.Text = "Red";
			this.rdbRed.UseVisualStyleBackColor = true;
			this.rdbRed.Click += new System.EventHandler(this.colors_CheckedChanged);
			// 
			// rbtBlue
			// 
			this.rbtBlue.AutoSize = true;
			this.rbtBlue.Location = new System.Drawing.Point(36, 29);
			this.rbtBlue.Name = "rbtBlue";
			this.rbtBlue.Size = new System.Drawing.Size(46, 17);
			this.rbtBlue.TabIndex = 5;
			this.rbtBlue.Text = "Blue";
			this.rbtBlue.UseVisualStyleBackColor = true;
			this.rbtBlue.Click += new System.EventHandler(this.colors_CheckedChanged);
			// 
			// YellowForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(556, 360);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.tbTitle);
			this.Controls.Add(this.btnSave);
			this.Controls.Add(this.lblTitle);
			this.Controls.Add(this.lblSelectionTitle);
			this.Name = "YellowForm";
			this.Text = "YellowForm";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.YellowForm_FormClosing);
			this.Load += new System.EventHandler(this.YellowForm_Load);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label lblSelectionTitle;
		private System.Windows.Forms.Label lblTitle;
		private System.Windows.Forms.Button btnSave;
		private System.Windows.Forms.TextBox tbTitle;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.RadioButton rdbLarge;
		private System.Windows.Forms.RadioButton rdbSmall;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.RadioButton rdbYellow;
		private System.Windows.Forms.RadioButton rdbRed;
		private System.Windows.Forms.RadioButton rbtBlue;
	}
}

