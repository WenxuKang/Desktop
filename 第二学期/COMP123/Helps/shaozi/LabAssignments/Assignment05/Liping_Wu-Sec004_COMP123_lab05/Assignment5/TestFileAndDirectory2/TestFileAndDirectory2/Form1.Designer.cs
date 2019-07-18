namespace TestFileAndDirectory2
{
	partial class TestFileandDirectoryForm
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
			this.lblSelect = new System.Windows.Forms.Label();
			this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
			this.lblCreat = new System.Windows.Forms.Label();
			this.lblCreateDetail = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// lblSelect
			// 
			this.lblSelect.AutoSize = true;
			this.lblSelect.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblSelect.Location = new System.Drawing.Point(13, 23);
			this.lblSelect.Name = "lblSelect";
			this.lblSelect.Size = new System.Drawing.Size(90, 16);
			this.lblSelect.TabIndex = 0;
			this.lblSelect.Text = "Select a file";
			// 
			// checkedListBox1
			// 
			this.checkedListBox1.FormattingEnabled = true;
			this.checkedListBox1.Items.AddRange(new object[] {
            "F:Centennial Wu\\2018Winter\\COMP123 C#\\ASSIGNMENTS\\Assignment5\\TestFileAndDirector" +
                "y2\\NoteToDad.txt",
            "F:Centennial Wu\\2018Winter\\COMP123 C#\\ASSIGNMENTS\\Assignment5\\TestFileAndDirector" +
                "y2\\ShoppingList.txt",
            "F:Centennial Wu\\2018Winter\\COMP123 C#\\ASSIGNMENTS\\Assignment5\\TestFileAndDirector" +
                "y2\\ThingsToTakeCamping.txt"});
			this.checkedListBox1.Location = new System.Drawing.Point(29, 58);
			this.checkedListBox1.Name = "checkedListBox1";
			this.checkedListBox1.Size = new System.Drawing.Size(703, 109);
			this.checkedListBox1.TabIndex = 1;
			this.checkedListBox1.SelectedIndexChanged += new System.EventHandler(this.checkedListBox1_SelectedIndexChanged);
			// 
			// lblCreat
			// 
			this.lblCreat.AutoSize = true;
			this.lblCreat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblCreat.Location = new System.Drawing.Point(16, 184);
			this.lblCreat.Name = "lblCreat";
			this.lblCreat.Size = new System.Drawing.Size(146, 16);
			this.lblCreat.TabIndex = 2;
			this.lblCreat.Text = "Creation information";
			// 
			// lblCreateDetail
			// 
			this.lblCreateDetail.AutoSize = true;
			this.lblCreateDetail.Location = new System.Drawing.Point(16, 211);
			this.lblCreateDetail.Name = "lblCreateDetail";
			this.lblCreateDetail.Size = new System.Drawing.Size(139, 13);
			this.lblCreateDetail.TabIndex = 3;
			this.lblCreateDetail.Text = "will display the file properties";
			// 
			// TestFileandDirectoryForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(787, 422);
			this.Controls.Add(this.lblCreateDetail);
			this.Controls.Add(this.lblCreat);
			this.Controls.Add(this.checkedListBox1);
			this.Controls.Add(this.lblSelect);
			this.Name = "TestFileandDirectoryForm";
			this.Text = "Test File and Directory";
			this.Load += new System.EventHandler(this.TestFileandDirectoryForm_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label lblSelect;
		private System.Windows.Forms.CheckedListBox checkedListBox1;
		private System.Windows.Forms.Label lblCreat;
		private System.Windows.Forms.Label lblCreateDetail;
	}
}

