namespace Xiaohui_Hao_Sec004_Comp123_Lab04
{
    partial class Excercise1
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
            this.lblNum01 = new System.Windows.Forms.Label();
            this.lblNum02 = new System.Windows.Forms.Label();
            this.txtNum01 = new System.Windows.Forms.TextBox();
            this.txtNum02 = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnSub = new System.Windows.Forms.Button();
            this.btnMpy = new System.Windows.Forms.Button();
            this.btnDiv = new System.Windows.Forms.Button();
            this.lblOutput = new System.Windows.Forms.Label();
            this.lblOutput1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblNum01
            // 
            this.lblNum01.AutoSize = true;
            this.lblNum01.Location = new System.Drawing.Point(44, 54);
            this.lblNum01.Name = "lblNum01";
            this.lblNum01.Size = new System.Drawing.Size(78, 17);
            this.lblNum01.TabIndex = 0;
            this.lblNum01.Text = "Number 01";
            // 
            // lblNum02
            // 
            this.lblNum02.AutoSize = true;
            this.lblNum02.Location = new System.Drawing.Point(44, 133);
            this.lblNum02.Name = "lblNum02";
            this.lblNum02.Size = new System.Drawing.Size(78, 17);
            this.lblNum02.TabIndex = 1;
            this.lblNum02.Text = "Number 02";
            // 
            // txtNum01
            // 
            this.txtNum01.Location = new System.Drawing.Point(165, 49);
            this.txtNum01.Name = "txtNum01";
            this.txtNum01.Size = new System.Drawing.Size(237, 22);
            this.txtNum01.TabIndex = 2;
            // 
            // txtNum02
            // 
            this.txtNum02.Location = new System.Drawing.Point(165, 128);
            this.txtNum02.Name = "txtNum02";
            this.txtNum02.Size = new System.Drawing.Size(237, 22);
            this.txtNum02.TabIndex = 3;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(599, 54);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.Text = "ADD";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnSub
            // 
            this.btnSub.Location = new System.Drawing.Point(599, 127);
            this.btnSub.Name = "btnSub";
            this.btnSub.Size = new System.Drawing.Size(75, 23);
            this.btnSub.TabIndex = 5;
            this.btnSub.Text = "SUB";
            this.btnSub.UseVisualStyleBackColor = true;
            this.btnSub.Click += new System.EventHandler(this.btnSub_Click);
            // 
            // btnMpy
            // 
            this.btnMpy.Location = new System.Drawing.Point(599, 196);
            this.btnMpy.Name = "btnMpy";
            this.btnMpy.Size = new System.Drawing.Size(75, 23);
            this.btnMpy.TabIndex = 6;
            this.btnMpy.Text = "MPY";
            this.btnMpy.UseVisualStyleBackColor = true;
            this.btnMpy.Click += new System.EventHandler(this.btnMpy_Click);
            // 
            // btnDiv
            // 
            this.btnDiv.Location = new System.Drawing.Point(599, 264);
            this.btnDiv.Name = "btnDiv";
            this.btnDiv.Size = new System.Drawing.Size(75, 23);
            this.btnDiv.TabIndex = 7;
            this.btnDiv.Text = "DIV";
            this.btnDiv.UseVisualStyleBackColor = true;
            this.btnDiv.Click += new System.EventHandler(this.btnDiv_Click);
            // 
            // lblOutput
            // 
            this.lblOutput.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblOutput.Location = new System.Drawing.Point(165, 264);
            this.lblOutput.Name = "lblOutput";
            this.lblOutput.Size = new System.Drawing.Size(340, 23);
            this.lblOutput.TabIndex = 8;
            // 
            // lblOutput1
            // 
            this.lblOutput1.AutoSize = true;
            this.lblOutput1.Location = new System.Drawing.Point(44, 264);
            this.lblOutput1.Name = "lblOutput1";
            this.lblOutput1.Size = new System.Drawing.Size(51, 17);
            this.lblOutput1.TabIndex = 9;
            this.lblOutput1.Text = "Output";
            // 
            // Excercise1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblOutput1);
            this.Controls.Add(this.lblOutput);
            this.Controls.Add(this.btnDiv);
            this.Controls.Add(this.btnMpy);
            this.Controls.Add(this.btnSub);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtNum02);
            this.Controls.Add(this.txtNum01);
            this.Controls.Add(this.lblNum02);
            this.Controls.Add(this.lblNum01);
            this.Name = "Excercise1";
            this.Text = "Exercise #1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNum01;
        private System.Windows.Forms.Label lblNum02;
        private System.Windows.Forms.TextBox txtNum01;
        private System.Windows.Forms.TextBox txtNum02;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnSub;
        private System.Windows.Forms.Button btnMpy;
        private System.Windows.Forms.Button btnDiv;
        private System.Windows.Forms.Label lblOutput;
        private System.Windows.Forms.Label lblOutput1;
    }
}

