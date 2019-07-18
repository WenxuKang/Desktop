namespace Exercise2
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
            this.lblPizzaForm = new System.Windows.Forms.Label();
            this.lblSelTopping = new System.Windows.Forms.Label();
            this.lblDiningOpt = new System.Windows.Forms.Label();
            this.OnionCheckBox = new System.Windows.Forms.CheckBox();
            this.GreenpeperCheckBox = new System.Windows.Forms.CheckBox();
            this.PepperoniCheckBox = new System.Windows.Forms.CheckBox();
            this.SausageCheckBox = new System.Windows.Forms.CheckBox();
            this.MushroomsCheckBox = new System.Windows.Forms.CheckBox();
            this.TomatoesCheckBox = new System.Windows.Forms.CheckBox();
            this.PickupRadioButton = new System.Windows.Forms.RadioButton();
            this.DeliveryRadioButton = new System.Windows.Forms.RadioButton();
            this.DineinRadioButton = new System.Windows.Forms.RadioButton();
            this.ExpressRadioButton = new System.Windows.Forms.RadioButton();
            this.lblOutput = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblPizzaForm
            // 
            this.lblPizzaForm.AutoSize = true;
            this.lblPizzaForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPizzaForm.Location = new System.Drawing.Point(220, 28);
            this.lblPizzaForm.Name = "lblPizzaForm";
            this.lblPizzaForm.Size = new System.Drawing.Size(263, 36);
            this.lblPizzaForm.TabIndex = 0;
            this.lblPizzaForm.Text = "Pizza Order Form";
            // 
            // lblSelTopping
            // 
            this.lblSelTopping.AutoSize = true;
            this.lblSelTopping.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelTopping.Location = new System.Drawing.Point(95, 95);
            this.lblSelTopping.Name = "lblSelTopping";
            this.lblSelTopping.Size = new System.Drawing.Size(180, 29);
            this.lblSelTopping.TabIndex = 1;
            this.lblSelTopping.Text = "Select toppings";
            // 
            // lblDiningOpt
            // 
            this.lblDiningOpt.AutoSize = true;
            this.lblDiningOpt.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDiningOpt.Location = new System.Drawing.Point(357, 95);
            this.lblDiningOpt.Name = "lblDiningOpt";
            this.lblDiningOpt.Size = new System.Drawing.Size(167, 29);
            this.lblDiningOpt.TabIndex = 2;
            this.lblDiningOpt.Text = "Dining options";
            // 
            // OnionCheckBox
            // 
            this.OnionCheckBox.AutoSize = true;
            this.OnionCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OnionCheckBox.Location = new System.Drawing.Point(133, 143);
            this.OnionCheckBox.Name = "OnionCheckBox";
            this.OnionCheckBox.Size = new System.Drawing.Size(84, 24);
            this.OnionCheckBox.TabIndex = 3;
            this.OnionCheckBox.Text = "Onions";
            this.OnionCheckBox.UseVisualStyleBackColor = true;
            this.OnionCheckBox.CheckedChanged += new System.EventHandler(this.OnionCheckBox_CheckedChanged);
            // 
            // GreenpeperCheckBox
            // 
            this.GreenpeperCheckBox.AutoSize = true;
            this.GreenpeperCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GreenpeperCheckBox.Location = new System.Drawing.Point(133, 187);
            this.GreenpeperCheckBox.Name = "GreenpeperCheckBox";
            this.GreenpeperCheckBox.Size = new System.Drawing.Size(133, 24);
            this.GreenpeperCheckBox.TabIndex = 4;
            this.GreenpeperCheckBox.Text = "Green pepper";
            this.GreenpeperCheckBox.UseVisualStyleBackColor = true;
            this.GreenpeperCheckBox.CheckedChanged += new System.EventHandler(this.GreenpeperCheckBox_CheckedChanged);
            // 
            // PepperoniCheckBox
            // 
            this.PepperoniCheckBox.AutoSize = true;
            this.PepperoniCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PepperoniCheckBox.Location = new System.Drawing.Point(133, 227);
            this.PepperoniCheckBox.Name = "PepperoniCheckBox";
            this.PepperoniCheckBox.Size = new System.Drawing.Size(106, 24);
            this.PepperoniCheckBox.TabIndex = 5;
            this.PepperoniCheckBox.Text = "Pepperoni";
            this.PepperoniCheckBox.UseVisualStyleBackColor = true;
            this.PepperoniCheckBox.CheckedChanged += new System.EventHandler(this.PepperoniCheckBox_CheckedChanged);
            // 
            // SausageCheckBox
            // 
            this.SausageCheckBox.AutoSize = true;
            this.SausageCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SausageCheckBox.Location = new System.Drawing.Point(133, 271);
            this.SausageCheckBox.Name = "SausageCheckBox";
            this.SausageCheckBox.Size = new System.Drawing.Size(96, 24);
            this.SausageCheckBox.TabIndex = 6;
            this.SausageCheckBox.Text = "Sausage";
            this.SausageCheckBox.UseVisualStyleBackColor = true;
            this.SausageCheckBox.CheckedChanged += new System.EventHandler(this.SausageCheckBox_CheckedChanged);
            // 
            // MushroomsCheckBox
            // 
            this.MushroomsCheckBox.AutoSize = true;
            this.MushroomsCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MushroomsCheckBox.Location = new System.Drawing.Point(133, 314);
            this.MushroomsCheckBox.Name = "MushroomsCheckBox";
            this.MushroomsCheckBox.Size = new System.Drawing.Size(119, 24);
            this.MushroomsCheckBox.TabIndex = 7;
            this.MushroomsCheckBox.Text = "Mushrooms";
            this.MushroomsCheckBox.UseVisualStyleBackColor = true;
            this.MushroomsCheckBox.CheckedChanged += new System.EventHandler(this.MushroomsCheckBox_CheckedChanged);
            // 
            // TomatoesCheckBox
            // 
            this.TomatoesCheckBox.AutoSize = true;
            this.TomatoesCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TomatoesCheckBox.Location = new System.Drawing.Point(133, 365);
            this.TomatoesCheckBox.Name = "TomatoesCheckBox";
            this.TomatoesCheckBox.Size = new System.Drawing.Size(105, 24);
            this.TomatoesCheckBox.TabIndex = 8;
            this.TomatoesCheckBox.Text = "Tomatoes";
            this.TomatoesCheckBox.UseVisualStyleBackColor = true;
            this.TomatoesCheckBox.CheckedChanged += new System.EventHandler(this.TomatoesCheckBox_CheckedChanged);
            // 
            // PickupRadioButton
            // 
            this.PickupRadioButton.AutoSize = true;
            this.PickupRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PickupRadioButton.Location = new System.Drawing.Point(362, 143);
            this.PickupRadioButton.Name = "PickupRadioButton";
            this.PickupRadioButton.Size = new System.Drawing.Size(86, 24);
            this.PickupRadioButton.TabIndex = 9;
            this.PickupRadioButton.TabStop = true;
            this.PickupRadioButton.Text = "Pick-up";
            this.PickupRadioButton.UseVisualStyleBackColor = true;
            // 
            // DeliveryRadioButton
            // 
            this.DeliveryRadioButton.AutoSize = true;
            this.DeliveryRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeliveryRadioButton.Location = new System.Drawing.Point(362, 187);
            this.DeliveryRadioButton.Name = "DeliveryRadioButton";
            this.DeliveryRadioButton.Size = new System.Drawing.Size(91, 24);
            this.DeliveryRadioButton.TabIndex = 10;
            this.DeliveryRadioButton.TabStop = true;
            this.DeliveryRadioButton.Text = "Delivery";
            this.DeliveryRadioButton.UseVisualStyleBackColor = true;
            this.DeliveryRadioButton.CheckedChanged += new System.EventHandler(this.DeliveryRadioButton_CheckedChanged);
            // 
            // DineinRadioButton
            // 
            this.DineinRadioButton.AutoSize = true;
            this.DineinRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DineinRadioButton.Location = new System.Drawing.Point(362, 227);
            this.DineinRadioButton.Name = "DineinRadioButton";
            this.DineinRadioButton.Size = new System.Drawing.Size(83, 24);
            this.DineinRadioButton.TabIndex = 11;
            this.DineinRadioButton.TabStop = true;
            this.DineinRadioButton.Text = "Dine in";
            this.DineinRadioButton.UseVisualStyleBackColor = true;
            // 
            // ExpressRadioButton
            // 
            this.ExpressRadioButton.AutoSize = true;
            this.ExpressRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExpressRadioButton.Location = new System.Drawing.Point(362, 271);
            this.ExpressRadioButton.Name = "ExpressRadioButton";
            this.ExpressRadioButton.Size = new System.Drawing.Size(157, 24);
            this.ExpressRadioButton.TabIndex = 12;
            this.ExpressRadioButton.TabStop = true;
            this.ExpressRadioButton.Text = "Express Delivery";
            this.ExpressRadioButton.UseVisualStyleBackColor = true;
            this.ExpressRadioButton.CheckedChanged += new System.EventHandler(this.ExpressRadioButton_CheckedChanged);
            // 
            // lblOutput
            // 
            this.lblOutput.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblOutput.Location = new System.Drawing.Point(362, 353);
            this.lblOutput.Name = "lblOutput";
            this.lblOutput.Size = new System.Drawing.Size(331, 36);
            this.lblOutput.TabIndex = 13;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblOutput);
            this.Controls.Add(this.ExpressRadioButton);
            this.Controls.Add(this.DineinRadioButton);
            this.Controls.Add(this.DeliveryRadioButton);
            this.Controls.Add(this.PickupRadioButton);
            this.Controls.Add(this.TomatoesCheckBox);
            this.Controls.Add(this.MushroomsCheckBox);
            this.Controls.Add(this.SausageCheckBox);
            this.Controls.Add(this.PepperoniCheckBox);
            this.Controls.Add(this.GreenpeperCheckBox);
            this.Controls.Add(this.OnionCheckBox);
            this.Controls.Add(this.lblDiningOpt);
            this.Controls.Add(this.lblSelTopping);
            this.Controls.Add(this.lblPizzaForm);
            this.Name = "Form1";
            this.Text = "Pizza Order Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPizzaForm;
        private System.Windows.Forms.Label lblSelTopping;
        private System.Windows.Forms.Label lblDiningOpt;
        private System.Windows.Forms.CheckBox OnionCheckBox;
        private System.Windows.Forms.CheckBox GreenpeperCheckBox;
        private System.Windows.Forms.CheckBox PepperoniCheckBox;
        private System.Windows.Forms.CheckBox SausageCheckBox;
        private System.Windows.Forms.CheckBox MushroomsCheckBox;
        private System.Windows.Forms.CheckBox TomatoesCheckBox;
        private System.Windows.Forms.RadioButton PickupRadioButton;
        private System.Windows.Forms.RadioButton DeliveryRadioButton;
        private System.Windows.Forms.RadioButton DineinRadioButton;
        private System.Windows.Forms.RadioButton ExpressRadioButton;
        private System.Windows.Forms.Label lblOutput;
    }
}

