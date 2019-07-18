namespace Gaofeng_Pan_Exercise01
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.lblID = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblAddress = new System.Windows.Forms.Label();
            this.lblType = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.btnPrint = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.lblPurchase = new System.Windows.Forms.Label();
            this.radEdu = new System.Windows.Forms.RadioButton();
            this.radBus = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.lblProducts = new System.Windows.Forms.Label();
            this.cheMouse = new System.Windows.Forms.CheckBox();
            this.cheKeyboard = new System.Windows.Forms.CheckBox();
            this.chePrinter = new System.Windows.Forms.CheckBox();
            this.lbl30 = new System.Windows.Forms.Label();
            this.lbl50 = new System.Windows.Forms.Label();
            this.lbl80 = new System.Windows.Forms.Label();
            this.lblSub = new System.Windows.Forms.Label();
            this.lblOutputSub = new System.Windows.Forms.Label();
            this.lblDiscount = new System.Windows.Forms.Label();
            this.lblOutputDiscount = new System.Windows.Forms.Label();
            this.lblTax = new System.Windows.Forms.Label();
            this.lblOutputTax = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblOutputTotal = new System.Windows.Forms.Label();
            this.lblOutput = new System.Windows.Forms.Label();
            this.comType = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(50, 103);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(103, 15);
            this.lblID.TabIndex = 0;
            this.lblID.Text = "Customer ID:";
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(173, 93);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(100, 25);
            this.txtID.TabIndex = 1;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(50, 146);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(119, 15);
            this.lblName.TabIndex = 2;
            this.lblName.Text = "Customer Name:";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(173, 136);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 25);
            this.txtName.TabIndex = 3;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(50, 189);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(63, 15);
            this.lblEmail.TabIndex = 4;
            this.lblEmail.Text = "E-mail:";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(173, 179);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(100, 25);
            this.txtEmail.TabIndex = 5;
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Location = new System.Drawing.Point(50, 229);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(71, 15);
            this.lblAddress.TabIndex = 6;
            this.lblAddress.Text = "Address:";
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblType.Location = new System.Drawing.Point(50, 266);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(297, 17);
            this.lblType.TabIndex = 7;
            this.lblType.Text = "Customer Type:(Student.Adult.Teacher)";
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(173, 219);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(100, 25);
            this.txtAddress.TabIndex = 8;
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(50, 350);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(75, 22);
            this.btnPrint.TabIndex = 10;
            this.btnPrint.Text = "Print";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(184, 350);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 22);
            this.btnClear.TabIndex = 11;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // lblPurchase
            // 
            this.lblPurchase.AutoSize = true;
            this.lblPurchase.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPurchase.Location = new System.Drawing.Point(378, 105);
            this.lblPurchase.Name = "lblPurchase";
            this.lblPurchase.Size = new System.Drawing.Size(134, 20);
            this.lblPurchase.TabIndex = 12;
            this.lblPurchase.Text = "Purchase Type";
            // 
            // radEdu
            // 
            this.radEdu.AutoSize = true;
            this.radEdu.Location = new System.Drawing.Point(312, 139);
            this.radEdu.Name = "radEdu";
            this.radEdu.Size = new System.Drawing.Size(116, 19);
            this.radEdu.TabIndex = 13;
            this.radEdu.TabStop = true;
            this.radEdu.Text = "Educational";
            this.radEdu.UseVisualStyleBackColor = true;
            this.radEdu.CheckedChanged += new System.EventHandler(this.radEdu_CheckedChanged);
            // 
            // radBus
            // 
            this.radBus.AutoSize = true;
            this.radBus.Location = new System.Drawing.Point(445, 139);
            this.radBus.Name = "radBus";
            this.radBus.Size = new System.Drawing.Size(92, 19);
            this.radBus.TabIndex = 14;
            this.radBus.TabStop = true;
            this.radBus.Text = "Business";
            this.radBus.UseVisualStyleBackColor = true;
            this.radBus.CheckedChanged += new System.EventHandler(this.radBus_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(266, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(246, 29);
            this.label1.TabIndex = 15;
            this.label1.Text = "Product Order Form";
            // 
            // lblProducts
            // 
            this.lblProducts.AutoSize = true;
            this.lblProducts.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProducts.Location = new System.Drawing.Point(571, 98);
            this.lblProducts.Name = "lblProducts";
            this.lblProducts.Size = new System.Drawing.Size(161, 25);
            this.lblProducts.TabIndex = 16;
            this.lblProducts.Text = "List of Products";
            // 
            // cheMouse
            // 
            this.cheMouse.AutoSize = true;
            this.cheMouse.Location = new System.Drawing.Point(586, 141);
            this.cheMouse.Name = "cheMouse";
            this.cheMouse.Size = new System.Drawing.Size(69, 19);
            this.cheMouse.TabIndex = 17;
            this.cheMouse.Text = "Mouse";
            this.cheMouse.UseVisualStyleBackColor = true;
            this.cheMouse.CheckedChanged += new System.EventHandler(this.cheMouse_CheckedChanged);
            // 
            // cheKeyboard
            // 
            this.cheKeyboard.AutoSize = true;
            this.cheKeyboard.Location = new System.Drawing.Point(586, 179);
            this.cheKeyboard.Name = "cheKeyboard";
            this.cheKeyboard.Size = new System.Drawing.Size(93, 19);
            this.cheKeyboard.TabIndex = 18;
            this.cheKeyboard.Text = "Keyboard";
            this.cheKeyboard.UseVisualStyleBackColor = true;
            this.cheKeyboard.CheckedChanged += new System.EventHandler(this.cheKeyboard_CheckedChanged);
            // 
            // chePrinter
            // 
            this.chePrinter.AutoSize = true;
            this.chePrinter.Location = new System.Drawing.Point(586, 219);
            this.chePrinter.Name = "chePrinter";
            this.chePrinter.Size = new System.Drawing.Size(85, 19);
            this.chePrinter.TabIndex = 19;
            this.chePrinter.Text = "Printer";
            this.chePrinter.UseVisualStyleBackColor = true;
            this.chePrinter.CheckedChanged += new System.EventHandler(this.chePrinter_CheckedChanged);
            // 
            // lbl30
            // 
            this.lbl30.AutoSize = true;
            this.lbl30.Location = new System.Drawing.Point(699, 141);
            this.lbl30.Name = "lbl30";
            this.lbl30.Size = new System.Drawing.Size(47, 15);
            this.lbl30.TabIndex = 20;
            this.lbl30.Text = "30.00";
            // 
            // lbl50
            // 
            this.lbl50.AutoSize = true;
            this.lbl50.Location = new System.Drawing.Point(699, 182);
            this.lbl50.Name = "lbl50";
            this.lbl50.Size = new System.Drawing.Size(47, 15);
            this.lbl50.TabIndex = 21;
            this.lbl50.Text = "50.00";
            // 
            // lbl80
            // 
            this.lbl80.AutoSize = true;
            this.lbl80.Location = new System.Drawing.Point(699, 223);
            this.lbl80.Name = "lbl80";
            this.lbl80.Size = new System.Drawing.Size(47, 15);
            this.lbl80.TabIndex = 22;
            this.lbl80.Text = "80.00";
            // 
            // lblSub
            // 
            this.lblSub.AutoSize = true;
            this.lblSub.Location = new System.Drawing.Point(583, 281);
            this.lblSub.Name = "lblSub";
            this.lblSub.Size = new System.Drawing.Size(87, 15);
            this.lblSub.TabIndex = 23;
            this.lblSub.Text = "Sub Total:";
            // 
            // lblOutputSub
            // 
            this.lblOutputSub.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblOutputSub.Location = new System.Drawing.Point(686, 266);
            this.lblOutputSub.Name = "lblOutputSub";
            this.lblOutputSub.Size = new System.Drawing.Size(185, 31);
            this.lblOutputSub.TabIndex = 24;
            this.lblOutputSub.Click += new System.EventHandler(this.lblOutputSub_Click);
            // 
            // lblDiscount
            // 
            this.lblDiscount.AutoSize = true;
            this.lblDiscount.Location = new System.Drawing.Point(442, 328);
            this.lblDiscount.Name = "lblDiscount";
            this.lblDiscount.Size = new System.Drawing.Size(79, 15);
            this.lblDiscount.TabIndex = 25;
            this.lblDiscount.Text = "Discount:";
            // 
            // lblOutputDiscount
            // 
            this.lblOutputDiscount.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblOutputDiscount.Location = new System.Drawing.Point(539, 327);
            this.lblOutputDiscount.Name = "lblOutputDiscount";
            this.lblOutputDiscount.Size = new System.Drawing.Size(100, 22);
            this.lblOutputDiscount.TabIndex = 26;
            this.lblOutputDiscount.Click += new System.EventHandler(this.lblOutputDiscount_Click);
            // 
            // lblTax
            // 
            this.lblTax.AutoSize = true;
            this.lblTax.Location = new System.Drawing.Point(683, 332);
            this.lblTax.Name = "lblTax";
            this.lblTax.Size = new System.Drawing.Size(71, 15);
            this.lblTax.TabIndex = 27;
            this.lblTax.Text = "Tax (5%)";
            // 
            // lblOutputTax
            // 
            this.lblOutputTax.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblOutputTax.Location = new System.Drawing.Point(769, 327);
            this.lblOutputTax.Name = "lblOutputTax";
            this.lblOutputTax.Size = new System.Drawing.Size(100, 22);
            this.lblOutputTax.TabIndex = 28;
            this.lblOutputTax.Click += new System.EventHandler(this.lblOutputTax_Click);
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(539, 370);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(55, 15);
            this.lblTotal.TabIndex = 29;
            this.lblTotal.Text = "Total:";
            // 
            // lblOutputTotal
            // 
            this.lblOutputTotal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblOutputTotal.Location = new System.Drawing.Point(603, 369);
            this.lblOutputTotal.Name = "lblOutputTotal";
            this.lblOutputTotal.Size = new System.Drawing.Size(265, 22);
            this.lblOutputTotal.TabIndex = 30;
            this.lblOutputTotal.Click += new System.EventHandler(this.lblOutputTotal_Click);
            // 
            // lblOutput
            // 
            this.lblOutput.AutoSize = true;
            this.lblOutput.Location = new System.Drawing.Point(50, 401);
            this.lblOutput.Name = "lblOutput";
            this.lblOutput.Size = new System.Drawing.Size(63, 15);
            this.lblOutput.TabIndex = 31;
            this.lblOutput.Text = "Output:";
            // 
            // comType
            // 
            this.comType.FormattingEnabled = true;
            this.comType.Items.AddRange(new object[] {
            "Student",
            "Adult",
            "Teacher"});
            this.comType.Location = new System.Drawing.Point(53, 299);
            this.comType.Name = "comType";
            this.comType.Size = new System.Drawing.Size(294, 23);
            this.comType.TabIndex = 33;
            this.comType.SelectedIndexChanged += new System.EventHandler(this.comType_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(903, 548);
            this.Controls.Add(this.comType);
            this.Controls.Add(this.lblOutput);
            this.Controls.Add(this.lblOutputTotal);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.lblOutputTax);
            this.Controls.Add(this.lblTax);
            this.Controls.Add(this.lblOutputDiscount);
            this.Controls.Add(this.lblDiscount);
            this.Controls.Add(this.lblOutputSub);
            this.Controls.Add(this.lblSub);
            this.Controls.Add(this.lbl80);
            this.Controls.Add(this.lbl50);
            this.Controls.Add(this.lbl30);
            this.Controls.Add(this.chePrinter);
            this.Controls.Add(this.cheKeyboard);
            this.Controls.Add(this.cheMouse);
            this.Controls.Add(this.lblProducts);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.radBus);
            this.Controls.Add(this.radEdu);
            this.Controls.Add(this.lblPurchase);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.lblType);
            this.Controls.Add(this.lblAddress);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.lblID);
            this.Name = "Form1";
            this.Text = "Product Order System";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label lblPurchase;
        private System.Windows.Forms.RadioButton radEdu;
        private System.Windows.Forms.RadioButton radBus;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblProducts;
        private System.Windows.Forms.CheckBox cheMouse;
        private System.Windows.Forms.CheckBox cheKeyboard;
        private System.Windows.Forms.CheckBox chePrinter;
        private System.Windows.Forms.Label lbl30;
        private System.Windows.Forms.Label lbl50;
        private System.Windows.Forms.Label lbl80;
        private System.Windows.Forms.Label lblSub;
        private System.Windows.Forms.Label lblOutputSub;
        private System.Windows.Forms.Label lblDiscount;
        private System.Windows.Forms.Label lblOutputDiscount;
        private System.Windows.Forms.Label lblTax;
        private System.Windows.Forms.Label lblOutputTax;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblOutputTotal;
        private System.Windows.Forms.Label lblOutput;
        private System.Windows.Forms.ComboBox comType;
    }
}
