namespace Exercise3
{
    partial class FormExercise3
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.grpInformation = new System.Windows.Forms.GroupBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtGrade = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.lblGrade = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblLastName = new System.Windows.Forms.Label();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.lblUsername = new System.Windows.Forms.Label();
            this.lblMessage = new System.Windows.Forms.Label();
            this.grpList = new System.Windows.Forms.GroupBox();
            this.lstStudents = new System.Windows.Forms.ListBox();
            this.btnLoad = new System.Windows.Forms.Button();
            this.grpSearch = new System.Windows.Forms.GroupBox();
            this.lblSearchMsg = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.txtSearchUser = new System.Windows.Forms.TextBox();
            this.lblSearchGrade = new System.Windows.Forms.Label();
            this.lblSearchEmail = new System.Windows.Forms.Label();
            this.lblSearchLn = new System.Windows.Forms.Label();
            this.lblSearchFn = new System.Windows.Forms.Label();
            this.lblSearchUser = new System.Windows.Forms.Label();
            this.grpInformation.SuspendLayout();
            this.grpList.SuspendLayout();
            this.grpSearch.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpInformation
            // 
            this.grpInformation.Controls.Add(this.btnSave);
            this.grpInformation.Controls.Add(this.txtGrade);
            this.grpInformation.Controls.Add(this.lblMessage);
            this.grpInformation.Controls.Add(this.txtEmail);
            this.grpInformation.Controls.Add(this.txtLastName);
            this.grpInformation.Controls.Add(this.txtFirstName);
            this.grpInformation.Controls.Add(this.txtUsername);
            this.grpInformation.Controls.Add(this.lblGrade);
            this.grpInformation.Controls.Add(this.lblEmail);
            this.grpInformation.Controls.Add(this.lblLastName);
            this.grpInformation.Controls.Add(this.lblFirstName);
            this.grpInformation.Controls.Add(this.lblUsername);
            this.grpInformation.Location = new System.Drawing.Point(49, 29);
            this.grpInformation.Name = "grpInformation";
            this.grpInformation.Size = new System.Drawing.Size(278, 204);
            this.grpInformation.TabIndex = 0;
            this.grpInformation.TabStop = false;
            this.grpInformation.Text = "Student information";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(185, 164);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 10;
            this.btnSave.Text = "&Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtGrade
            // 
            this.txtGrade.Location = new System.Drawing.Point(82, 137);
            this.txtGrade.Name = "txtGrade";
            this.txtGrade.Size = new System.Drawing.Size(100, 20);
            this.txtGrade.TabIndex = 9;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(82, 108);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(100, 20);
            this.txtEmail.TabIndex = 8;
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(82, 84);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(100, 20);
            this.txtLastName.TabIndex = 7;
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(82, 56);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(100, 20);
            this.txtFirstName.TabIndex = 6;
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(82, 23);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(100, 20);
            this.txtUsername.TabIndex = 5;
            // 
            // lblGrade
            // 
            this.lblGrade.AutoSize = true;
            this.lblGrade.Location = new System.Drawing.Point(11, 140);
            this.lblGrade.Name = "lblGrade";
            this.lblGrade.Size = new System.Drawing.Size(39, 13);
            this.lblGrade.TabIndex = 4;
            this.lblGrade.Text = "Grade:";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(11, 111);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(35, 13);
            this.lblEmail.TabIndex = 3;
            this.lblEmail.Text = "Email:";
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Location = new System.Drawing.Point(11, 84);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(59, 13);
            this.lblLastName.TabIndex = 2;
            this.lblLastName.Text = "Last name:";
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Location = new System.Drawing.Point(11, 56);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(58, 13);
            this.lblFirstName.TabIndex = 1;
            this.lblFirstName.Text = "First name:";
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Location = new System.Drawing.Point(11, 26);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(58, 13);
            this.lblUsername.TabIndex = 0;
            this.lblUsername.Text = "Username:";
            // 
            // lblMessage
            // 
            this.lblMessage.AutoSize = true;
            this.lblMessage.ForeColor = System.Drawing.Color.Red;
            this.lblMessage.Location = new System.Drawing.Point(10, 174);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(60, 13);
            this.lblMessage.TabIndex = 11;
            this.lblMessage.Text = "lblMessage";
            // 
            // grpList
            // 
            this.grpList.Controls.Add(this.lstStudents);
            this.grpList.Controls.Add(this.btnLoad);
            this.grpList.Location = new System.Drawing.Point(364, 29);
            this.grpList.Name = "grpList";
            this.grpList.Size = new System.Drawing.Size(389, 204);
            this.grpList.TabIndex = 12;
            this.grpList.TabStop = false;
            this.grpList.Text = "Student list";
            // 
            // lstStudents
            // 
            this.lstStudents.FormattingEnabled = true;
            this.lstStudents.Location = new System.Drawing.Point(28, 26);
            this.lstStudents.Name = "lstStudents";
            this.lstStudents.Size = new System.Drawing.Size(332, 134);
            this.lstStudents.TabIndex = 12;
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(284, 164);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(75, 23);
            this.btnLoad.TabIndex = 11;
            this.btnLoad.Text = "&Load";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // grpSearch
            // 
            this.grpSearch.Controls.Add(this.lblSearchMsg);
            this.grpSearch.Controls.Add(this.button1);
            this.grpSearch.Controls.Add(this.txtSearchUser);
            this.grpSearch.Controls.Add(this.lblSearchGrade);
            this.grpSearch.Controls.Add(this.lblSearchEmail);
            this.grpSearch.Controls.Add(this.lblSearchLn);
            this.grpSearch.Controls.Add(this.lblSearchFn);
            this.grpSearch.Controls.Add(this.lblSearchUser);
            this.grpSearch.Location = new System.Drawing.Point(50, 259);
            this.grpSearch.Name = "grpSearch";
            this.grpSearch.Size = new System.Drawing.Size(276, 184);
            this.grpSearch.TabIndex = 13;
            this.grpSearch.TabStop = false;
            this.grpSearch.Text = "Student search";
            // 
            // lblSearchMsg
            // 
            this.lblSearchMsg.AutoSize = true;
            this.lblSearchMsg.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearchMsg.ForeColor = System.Drawing.Color.Red;
            this.lblSearchMsg.Location = new System.Drawing.Point(13, 161);
            this.lblSearchMsg.Name = "lblSearchMsg";
            this.lblSearchMsg.Size = new System.Drawing.Size(46, 17);
            this.lblSearchMsg.TabIndex = 7;
            this.lblSearchMsg.Text = "label1";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(195, 24);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "S&earch";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtSearchUser
            // 
            this.txtSearchUser.Location = new System.Drawing.Point(95, 27);
            this.txtSearchUser.Name = "txtSearchUser";
            this.txtSearchUser.Size = new System.Drawing.Size(85, 20);
            this.txtSearchUser.TabIndex = 5;
            // 
            // lblSearchGrade
            // 
            this.lblSearchGrade.AutoSize = true;
            this.lblSearchGrade.Location = new System.Drawing.Point(13, 139);
            this.lblSearchGrade.Name = "lblSearchGrade";
            this.lblSearchGrade.Size = new System.Drawing.Size(39, 13);
            this.lblSearchGrade.TabIndex = 4;
            this.lblSearchGrade.Text = "Grade:";
            // 
            // lblSearchEmail
            // 
            this.lblSearchEmail.AutoSize = true;
            this.lblSearchEmail.Location = new System.Drawing.Point(13, 113);
            this.lblSearchEmail.Name = "lblSearchEmail";
            this.lblSearchEmail.Size = new System.Drawing.Size(35, 13);
            this.lblSearchEmail.TabIndex = 3;
            this.lblSearchEmail.Text = "Email:";
            // 
            // lblSearchLn
            // 
            this.lblSearchLn.AutoSize = true;
            this.lblSearchLn.Location = new System.Drawing.Point(13, 88);
            this.lblSearchLn.Name = "lblSearchLn";
            this.lblSearchLn.Size = new System.Drawing.Size(59, 13);
            this.lblSearchLn.TabIndex = 2;
            this.lblSearchLn.Text = "Last name:";
            // 
            // lblSearchFn
            // 
            this.lblSearchFn.AutoSize = true;
            this.lblSearchFn.Location = new System.Drawing.Point(13, 62);
            this.lblSearchFn.Name = "lblSearchFn";
            this.lblSearchFn.Size = new System.Drawing.Size(58, 13);
            this.lblSearchFn.TabIndex = 1;
            this.lblSearchFn.Text = "First name:";
            // 
            // lblSearchUser
            // 
            this.lblSearchUser.AutoSize = true;
            this.lblSearchUser.Location = new System.Drawing.Point(13, 29);
            this.lblSearchUser.Name = "lblSearchUser";
            this.lblSearchUser.Size = new System.Drawing.Size(84, 13);
            this.lblSearchUser.TabIndex = 0;
            this.lblSearchUser.Text = "Enter username:";
            // 
            // FormExercise3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(814, 496);
            this.Controls.Add(this.grpSearch);
            this.Controls.Add(this.grpList);
            this.Controls.Add(this.grpInformation);
            this.Name = "FormExercise3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Exercise 3";
            this.Activated += new System.EventHandler(this.FormExercise3_Activated);
            this.grpInformation.ResumeLayout(false);
            this.grpInformation.PerformLayout();
            this.grpList.ResumeLayout(false);
            this.grpSearch.ResumeLayout(false);
            this.grpSearch.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpInformation;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtGrade;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label lblGrade;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.GroupBox grpList;
        private System.Windows.Forms.ListBox lstStudents;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.GroupBox grpSearch;
        private System.Windows.Forms.Label lblSearchMsg;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtSearchUser;
        private System.Windows.Forms.Label lblSearchGrade;
        private System.Windows.Forms.Label lblSearchEmail;
        private System.Windows.Forms.Label lblSearchLn;
        private System.Windows.Forms.Label lblSearchFn;
        private System.Windows.Forms.Label lblSearchUser;
    }
}

