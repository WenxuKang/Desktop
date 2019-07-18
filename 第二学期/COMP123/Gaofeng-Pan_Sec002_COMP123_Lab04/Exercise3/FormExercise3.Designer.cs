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
            this.lblMessage = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.lblGrade = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblLastName = new System.Windows.Forms.Label();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.lblUsername = new System.Windows.Forms.Label();
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
            this.grpInformation.Location = new System.Drawing.Point(65, 33);
            this.grpInformation.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.grpInformation.Name = "grpInformation";
            this.grpInformation.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.grpInformation.Size = new System.Drawing.Size(427, 235);
            this.grpInformation.TabIndex = 0;
            this.grpInformation.TabStop = false;
            this.grpInformation.Text = "Student information";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(286, 189);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(100, 27);
            this.btnSave.TabIndex = 10;
            this.btnSave.Text = "&Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtGrade
            // 
            this.txtGrade.Location = new System.Drawing.Point(120, 162);
            this.txtGrade.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtGrade.Name = "txtGrade";
            this.txtGrade.Size = new System.Drawing.Size(132, 25);
            this.txtGrade.TabIndex = 9;
            // 
            // lblMessage
            // 
            this.lblMessage.AutoSize = true;
            this.lblMessage.ForeColor = System.Drawing.Color.Red;
            this.lblMessage.Location = new System.Drawing.Point(15, 201);
            this.lblMessage.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(0, 15);
            this.lblMessage.TabIndex = 11;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(120, 131);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(132, 25);
            this.txtEmail.TabIndex = 8;
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(120, 97);
            this.txtLastName.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(132, 25);
            this.txtLastName.TabIndex = 7;
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(120, 65);
            this.txtFirstName.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(132, 25);
            this.txtFirstName.TabIndex = 6;
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(120, 34);
            this.txtUsername.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(132, 25);
            this.txtUsername.TabIndex = 5;
            // 
            // lblGrade
            // 
            this.lblGrade.AutoSize = true;
            this.lblGrade.Location = new System.Drawing.Point(15, 172);
            this.lblGrade.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblGrade.Name = "lblGrade";
            this.lblGrade.Size = new System.Drawing.Size(55, 15);
            this.lblGrade.TabIndex = 4;
            this.lblGrade.Text = "Grade:";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(15, 141);
            this.lblEmail.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(55, 15);
            this.lblEmail.TabIndex = 3;
            this.lblEmail.Text = "Email:";
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Location = new System.Drawing.Point(15, 107);
            this.lblLastName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(87, 15);
            this.lblLastName.TabIndex = 2;
            this.lblLastName.Text = "Last name:";
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Location = new System.Drawing.Point(15, 75);
            this.lblFirstName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(95, 15);
            this.lblFirstName.TabIndex = 1;
            this.lblFirstName.Text = "First name:";
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Location = new System.Drawing.Point(15, 44);
            this.lblUsername.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(79, 15);
            this.lblUsername.TabIndex = 0;
            this.lblUsername.Text = "Username:";
            // 
            // grpList
            // 
            this.grpList.Controls.Add(this.lstStudents);
            this.grpList.Controls.Add(this.btnLoad);
            this.grpList.Location = new System.Drawing.Point(500, 33);
            this.grpList.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.grpList.Name = "grpList";
            this.grpList.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.grpList.Size = new System.Drawing.Size(504, 235);
            this.grpList.TabIndex = 12;
            this.grpList.TabStop = false;
            this.grpList.Text = "Student list";
            // 
            // lstStudents
            // 
            this.lstStudents.FormattingEnabled = true;
            this.lstStudents.ItemHeight = 15;
            this.lstStudents.Location = new System.Drawing.Point(37, 30);
            this.lstStudents.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.lstStudents.Name = "lstStudents";
            this.lstStudents.Size = new System.Drawing.Size(441, 154);
            this.lstStudents.TabIndex = 12;
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(379, 189);
            this.btnLoad.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(100, 27);
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
            this.grpSearch.Location = new System.Drawing.Point(67, 299);
            this.grpSearch.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.grpSearch.Name = "grpSearch";
            this.grpSearch.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.grpSearch.Size = new System.Drawing.Size(425, 212);
            this.grpSearch.TabIndex = 13;
            this.grpSearch.TabStop = false;
            this.grpSearch.Text = "Student search";
            // 
            // lblSearchMsg
            // 
            this.lblSearchMsg.AutoSize = true;
            this.lblSearchMsg.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearchMsg.ForeColor = System.Drawing.Color.Red;
            this.lblSearchMsg.Location = new System.Drawing.Point(17, 186);
            this.lblSearchMsg.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSearchMsg.Name = "lblSearchMsg";
            this.lblSearchMsg.Size = new System.Drawing.Size(0, 15);
            this.lblSearchMsg.TabIndex = 7;
            this.lblSearchMsg.Click += new System.EventHandler(this.lblSearchMsg_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(273, 174);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 27);
            this.button1.TabIndex = 6;
            this.button1.Text = "S&earch";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtSearchUser
            // 
            this.txtSearchUser.Location = new System.Drawing.Point(152, 30);
            this.txtSearchUser.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtSearchUser.Name = "txtSearchUser";
            this.txtSearchUser.Size = new System.Drawing.Size(139, 25);
            this.txtSearchUser.TabIndex = 5;
            this.txtSearchUser.TextChanged += new System.EventHandler(this.txtSearchUser_TextChanged);
            // 
            // lblSearchGrade
            // 
            this.lblSearchGrade.AutoSize = true;
            this.lblSearchGrade.Location = new System.Drawing.Point(17, 160);
            this.lblSearchGrade.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSearchGrade.Name = "lblSearchGrade";
            this.lblSearchGrade.Size = new System.Drawing.Size(55, 15);
            this.lblSearchGrade.TabIndex = 4;
            this.lblSearchGrade.Text = "Grade:";
            // 
            // lblSearchEmail
            // 
            this.lblSearchEmail.AutoSize = true;
            this.lblSearchEmail.Location = new System.Drawing.Point(17, 131);
            this.lblSearchEmail.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSearchEmail.Name = "lblSearchEmail";
            this.lblSearchEmail.Size = new System.Drawing.Size(55, 15);
            this.lblSearchEmail.TabIndex = 3;
            this.lblSearchEmail.Text = "Email:";
            // 
            // lblSearchLn
            // 
            this.lblSearchLn.AutoSize = true;
            this.lblSearchLn.Location = new System.Drawing.Point(17, 102);
            this.lblSearchLn.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSearchLn.Name = "lblSearchLn";
            this.lblSearchLn.Size = new System.Drawing.Size(87, 15);
            this.lblSearchLn.TabIndex = 2;
            this.lblSearchLn.Text = "Last name:";
            // 
            // lblSearchFn
            // 
            this.lblSearchFn.AutoSize = true;
            this.lblSearchFn.Location = new System.Drawing.Point(17, 72);
            this.lblSearchFn.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSearchFn.Name = "lblSearchFn";
            this.lblSearchFn.Size = new System.Drawing.Size(95, 15);
            this.lblSearchFn.TabIndex = 1;
            this.lblSearchFn.Text = "First name:";
            // 
            // lblSearchUser
            // 
            this.lblSearchUser.AutoSize = true;
            this.lblSearchUser.Location = new System.Drawing.Point(17, 33);
            this.lblSearchUser.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSearchUser.Name = "lblSearchUser";
            this.lblSearchUser.Size = new System.Drawing.Size(127, 15);
            this.lblSearchUser.TabIndex = 0;
            this.lblSearchUser.Text = "Enter username:";
            // 
            // FormExercise3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1045, 585);
            this.Controls.Add(this.grpSearch);
            this.Controls.Add(this.grpList);
            this.Controls.Add(this.grpInformation);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
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

