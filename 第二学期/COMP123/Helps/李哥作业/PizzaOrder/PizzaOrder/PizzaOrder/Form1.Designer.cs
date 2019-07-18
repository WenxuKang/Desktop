namespace PizzaOrder
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components;

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
            this.onionCheckBox = new System.Windows.Forms.CheckBox();
            this.greenPepperCheckBox = new System.Windows.Forms.CheckBox();
            this.pepperoniCheckBox = new System.Windows.Forms.CheckBox();
            this.sausageCheckBox = new System.Windows.Forms.CheckBox();
            this.pickUpRadioButton = new System.Windows.Forms.RadioButton();
            this.deliverRadioButton = new System.Windows.Forms.RadioButton();
            this.dineInRadioButton = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.outputLabel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // onionCheckBox
            // 
            this.onionCheckBox.AutoSize = true;
            this.onionCheckBox.Location = new System.Drawing.Point(64, 196);
            this.onionCheckBox.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.onionCheckBox.Name = "onionCheckBox";
            this.onionCheckBox.Size = new System.Drawing.Size(112, 29);
            this.onionCheckBox.TabIndex = 0;
            this.onionCheckBox.Text = "Onions";
            this.onionCheckBox.UseVisualStyleBackColor = true;
            this.onionCheckBox.CheckedChanged += new System.EventHandler(this.onionCheckBox_CheckedChanged);
            // 
            // greenPepperCheckBox
            // 
            this.greenPepperCheckBox.AutoSize = true;
            this.greenPepperCheckBox.Location = new System.Drawing.Point(64, 242);
            this.greenPepperCheckBox.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.greenPepperCheckBox.Name = "greenPepperCheckBox";
            this.greenPepperCheckBox.Size = new System.Drawing.Size(176, 29);
            this.greenPepperCheckBox.TabIndex = 1;
            this.greenPepperCheckBox.Text = "Green pepper";
            this.greenPepperCheckBox.UseVisualStyleBackColor = true;
            this.greenPepperCheckBox.CheckedChanged += new System.EventHandler(this.greenPepperCheckBox_CheckedChanged);
            // 
            // pepperoniCheckBox
            // 
            this.pepperoniCheckBox.AutoSize = true;
            this.pepperoniCheckBox.Location = new System.Drawing.Point(64, 288);
            this.pepperoniCheckBox.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.pepperoniCheckBox.Name = "pepperoniCheckBox";
            this.pepperoniCheckBox.Size = new System.Drawing.Size(142, 29);
            this.pepperoniCheckBox.TabIndex = 2;
            this.pepperoniCheckBox.Text = "Pepperoni";
            this.pepperoniCheckBox.UseVisualStyleBackColor = true;
            this.pepperoniCheckBox.CheckedChanged += new System.EventHandler(this.pepperoniCheckBox_CheckedChanged);
            // 
            // sausageCheckBox
            // 
            this.sausageCheckBox.AutoSize = true;
            this.sausageCheckBox.Location = new System.Drawing.Point(64, 335);
            this.sausageCheckBox.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.sausageCheckBox.Name = "sausageCheckBox";
            this.sausageCheckBox.Size = new System.Drawing.Size(129, 29);
            this.sausageCheckBox.TabIndex = 3;
            this.sausageCheckBox.Text = "Sausage";
            this.sausageCheckBox.UseVisualStyleBackColor = true;
            this.sausageCheckBox.CheckedChanged += new System.EventHandler(this.sausageCheckBox_CheckedChanged);
            // 
            // pickUpRadioButton
            // 
            this.pickUpRadioButton.AutoSize = true;
            this.pickUpRadioButton.Location = new System.Drawing.Point(304, 194);
            this.pickUpRadioButton.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.pickUpRadioButton.Name = "pickUpRadioButton";
            this.pickUpRadioButton.Size = new System.Drawing.Size(115, 29);
            this.pickUpRadioButton.TabIndex = 4;
            this.pickUpRadioButton.TabStop = true;
            this.pickUpRadioButton.Text = "Pick-up";
            this.pickUpRadioButton.UseVisualStyleBackColor = true;
            this.pickUpRadioButton.CheckedChanged += new System.EventHandler(this.pickUpRadioButton_CheckedChanged);
            // 
            // deliverRadioButton
            // 
            this.deliverRadioButton.AutoSize = true;
            this.deliverRadioButton.Location = new System.Drawing.Point(304, 240);
            this.deliverRadioButton.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.deliverRadioButton.Name = "deliverRadioButton";
            this.deliverRadioButton.Size = new System.Drawing.Size(121, 29);
            this.deliverRadioButton.TabIndex = 5;
            this.deliverRadioButton.TabStop = true;
            this.deliverRadioButton.Text = "Delivery";
            this.deliverRadioButton.UseVisualStyleBackColor = true;
            this.deliverRadioButton.CheckedChanged += new System.EventHandler(this.deliverRadioButton_CheckedChanged);
            // 
            // dineInRadioButton
            // 
            this.dineInRadioButton.AutoSize = true;
            this.dineInRadioButton.Location = new System.Drawing.Point(304, 287);
            this.dineInRadioButton.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.dineInRadioButton.Name = "dineInRadioButton";
            this.dineInRadioButton.Size = new System.Drawing.Size(110, 29);
            this.dineInRadioButton.TabIndex = 6;
            this.dineInRadioButton.TabStop = true;
            this.dineInRadioButton.Text = "Dine in";
            this.dineInRadioButton.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(88, 42);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(350, 48);
            this.label1.TabIndex = 7;
            this.label1.Text = "Pizza Order Form";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(24, 121);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(235, 37);
            this.label2.TabIndex = 8;
            this.label2.Text = "Select toppings";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(296, 121);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(221, 37);
            this.label3.TabIndex = 9;
            this.label3.Text = "Dining options";
            // 
            // outputLabel
            // 
            this.outputLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.outputLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outputLabel.Location = new System.Drawing.Point(280, 417);
            this.outputLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.outputLabel.Name = "outputLabel";
            this.outputLabel.Size = new System.Drawing.Size(264, 38);
            this.outputLabel.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(200, 429);
            this.label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 25);
            this.label4.TabIndex = 11;
            this.label4.Text = "Total:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(568, 504);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.outputLabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dineInRadioButton);
            this.Controls.Add(this.deliverRadioButton);
            this.Controls.Add(this.pickUpRadioButton);
            this.Controls.Add(this.sausageCheckBox);
            this.Controls.Add(this.pepperoniCheckBox);
            this.Controls.Add(this.greenPepperCheckBox);
            this.Controls.Add(this.onionCheckBox);
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "Form1";
            this.Text = "Pizza Order Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox onionCheckBox;
        private System.Windows.Forms.CheckBox greenPepperCheckBox;
        private System.Windows.Forms.CheckBox pepperoniCheckBox;
        private System.Windows.Forms.CheckBox sausageCheckBox;
        private System.Windows.Forms.RadioButton pickUpRadioButton;
        private System.Windows.Forms.RadioButton deliverRadioButton;
        private System.Windows.Forms.RadioButton dineInRadioButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label outputLabel;
        private System.Windows.Forms.Label label4;
    }
}

