namespace CustomizeAform
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
            this.rdoDarkSalmon = new System.Windows.Forms.RadioButton();
            this.rdoBeige = new System.Windows.Forms.RadioButton();
            this.rdoCornflowerBlue = new System.Windows.Forms.RadioButton();
            this.rdoSmall = new System.Windows.Forms.RadioButton();
            this.rdoLarge = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // rdoDarkSalmon
            // 
            this.rdoDarkSalmon.AutoSize = true;
            this.rdoDarkSalmon.Location = new System.Drawing.Point(21, 35);
            this.rdoDarkSalmon.Name = "rdoDarkSalmon";
            this.rdoDarkSalmon.Size = new System.Drawing.Size(106, 21);
            this.rdoDarkSalmon.TabIndex = 0;
            this.rdoDarkSalmon.TabStop = true;
            this.rdoDarkSalmon.Text = "DarkSalmon";
            this.rdoDarkSalmon.UseVisualStyleBackColor = true;
            this.rdoDarkSalmon.CheckedChanged += new System.EventHandler(this.rdoDarkSalmon_CheckedChanged);
            // 
            // rdoBeige
            // 
            this.rdoBeige.AutoSize = true;
            this.rdoBeige.Location = new System.Drawing.Point(21, 80);
            this.rdoBeige.Name = "rdoBeige";
            this.rdoBeige.Size = new System.Drawing.Size(65, 21);
            this.rdoBeige.TabIndex = 1;
            this.rdoBeige.TabStop = true;
            this.rdoBeige.Text = "Beige";
            this.rdoBeige.UseVisualStyleBackColor = true;
            this.rdoBeige.CheckedChanged += new System.EventHandler(this.rdoBeige_CheckedChanged);
            // 
            // rdoCornflowerBlue
            // 
            this.rdoCornflowerBlue.AutoSize = true;
            this.rdoCornflowerBlue.Location = new System.Drawing.Point(21, 124);
            this.rdoCornflowerBlue.Name = "rdoCornflowerBlue";
            this.rdoCornflowerBlue.Size = new System.Drawing.Size(124, 21);
            this.rdoCornflowerBlue.TabIndex = 2;
            this.rdoCornflowerBlue.TabStop = true;
            this.rdoCornflowerBlue.Text = "CornflowerBlue";
            this.rdoCornflowerBlue.UseVisualStyleBackColor = true;
            this.rdoCornflowerBlue.CheckedChanged += new System.EventHandler(this.rdoCornflowerBlue_CheckedChanged);
            // 
            // rdoSmall
            // 
            this.rdoSmall.AutoSize = true;
            this.rdoSmall.Location = new System.Drawing.Point(29, 35);
            this.rdoSmall.Name = "rdoSmall";
            this.rdoSmall.Size = new System.Drawing.Size(63, 21);
            this.rdoSmall.TabIndex = 3;
            this.rdoSmall.TabStop = true;
            this.rdoSmall.Text = "Small";
            this.rdoSmall.UseVisualStyleBackColor = true;
            this.rdoSmall.CheckedChanged += new System.EventHandler(this.rdoSmall_CheckedChanged);
            // 
            // rdoLarge
            // 
            this.rdoLarge.AutoSize = true;
            this.rdoLarge.Location = new System.Drawing.Point(29, 80);
            this.rdoLarge.Name = "rdoLarge";
            this.rdoLarge.Size = new System.Drawing.Size(66, 21);
            this.rdoLarge.TabIndex = 4;
            this.rdoLarge.TabStop = true;
            this.rdoLarge.Text = "Large";
            this.rdoLarge.UseVisualStyleBackColor = true;
            this.rdoLarge.CheckedChanged += new System.EventHandler(this.rdoLarge_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdoDarkSalmon);
            this.groupBox1.Controls.Add(this.rdoBeige);
            this.groupBox1.Controls.Add(this.rdoCornflowerBlue);
            this.groupBox1.Location = new System.Drawing.Point(46, 147);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(190, 173);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Color";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rdoSmall);
            this.groupBox2.Controls.Add(this.rdoLarge);
            this.groupBox2.Location = new System.Drawing.Point(346, 147);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(198, 135);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Size";
            // 
            // txtTitle
            // 
            this.txtTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTitle.Location = new System.Drawing.Point(136, 72);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(408, 27);
            this.txtTitle.TabIndex = 7;
            this.txtTitle.TextChanged += new System.EventHandler(this.txtTitle_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(41, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 29);
            this.label1.TabIndex = 8;
            this.label1.Text = "Title";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(633, 65);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(132, 34);
            this.btnSave.TabIndex = 9;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtTitle);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "CustomizeAform";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rdoDarkSalmon;
        private System.Windows.Forms.RadioButton rdoBeige;
        private System.Windows.Forms.RadioButton rdoCornflowerBlue;
        private System.Windows.Forms.RadioButton rdoSmall;
        private System.Windows.Forms.RadioButton rdoLarge;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSave;
    }
}

