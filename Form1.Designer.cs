namespace MyRestaurant
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            gbSize = new GroupBox();
            rbLarge = new RadioButton();
            rbMedium = new RadioButton();
            rbSmall = new RadioButton();
            gbToppings = new GroupBox();
            chbGreenPepper = new CheckBox();
            chbOlives = new CheckBox();
            chbOnion = new CheckBox();
            chbTomatoes = new CheckBox();
            chbMushroom = new CheckBox();
            chbExtra = new CheckBox();
            gbSummary = new GroupBox();
            lblTotalPrice = new Label();
            lblWhere = new Label();
            lblCrust = new Label();
            lblToppings = new Label();
            lblSize = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            gbCrust = new GroupBox();
            rbThick = new RadioButton();
            rbThin = new RadioButton();
            gbWhereEat = new GroupBox();
            rbEatIn = new RadioButton();
            rbEatOut = new RadioButton();
            btnOrder = new Button();
            rbReset = new Button();
            label6 = new Label();
            gbSize.SuspendLayout();
            gbToppings.SuspendLayout();
            gbSummary.SuspendLayout();
            gbCrust.SuspendLayout();
            gbWhereEat.SuspendLayout();
            SuspendLayout();
            // 
            // gbSize
            // 
            gbSize.Controls.Add(rbLarge);
            gbSize.Controls.Add(rbMedium);
            gbSize.Controls.Add(rbSmall);
            gbSize.FlatStyle = FlatStyle.Flat;
            gbSize.Location = new Point(9, 117);
            gbSize.Name = "gbSize";
            gbSize.Size = new Size(200, 134);
            gbSize.TabIndex = 0;
            gbSize.TabStop = false;
            gbSize.Text = "Size";
            // 
            // rbLarge
            // 
            rbLarge.AutoSize = true;
            rbLarge.Location = new Point(3, 103);
            rbLarge.Name = "rbLarge";
            rbLarge.Size = new Size(54, 19);
            rbLarge.TabIndex = 2;
            rbLarge.Tag = "40";
            rbLarge.Text = "Large";
            rbLarge.UseVisualStyleBackColor = true;
            rbLarge.CheckedChanged += rbLarge_CheckedChanged;
            // 
            // rbMedium
            // 
            rbMedium.AutoSize = true;
            rbMedium.Checked = true;
            rbMedium.Location = new Point(0, 67);
            rbMedium.Name = "rbMedium";
            rbMedium.Size = new Size(70, 19);
            rbMedium.TabIndex = 1;
            rbMedium.TabStop = true;
            rbMedium.Tag = "30";
            rbMedium.Text = "Medium";
            rbMedium.UseVisualStyleBackColor = true;
            rbMedium.CheckedChanged += rbMedium_CheckedChanged;
            // 
            // rbSmall
            // 
            rbSmall.AutoSize = true;
            rbSmall.Location = new Point(3, 26);
            rbSmall.Name = "rbSmall";
            rbSmall.Size = new Size(54, 19);
            rbSmall.TabIndex = 0;
            rbSmall.Tag = "20";
            rbSmall.Text = "Small";
            rbSmall.UseVisualStyleBackColor = true;
            rbSmall.CheckedChanged += rbSmall_CheckedChanged;
            // 
            // gbToppings
            // 
            gbToppings.Controls.Add(chbGreenPepper);
            gbToppings.Controls.Add(chbOlives);
            gbToppings.Controls.Add(chbOnion);
            gbToppings.Controls.Add(chbTomatoes);
            gbToppings.Controls.Add(chbMushroom);
            gbToppings.Controls.Add(chbExtra);
            gbToppings.Location = new Point(268, 117);
            gbToppings.Name = "gbToppings";
            gbToppings.Size = new Size(200, 134);
            gbToppings.TabIndex = 1;
            gbToppings.TabStop = false;
            gbToppings.Text = "Toppings";
            // 
            // chbGreenPepper
            // 
            chbGreenPepper.AutoSize = true;
            chbGreenPepper.Location = new Point(98, 103);
            chbGreenPepper.Name = "chbGreenPepper";
            chbGreenPepper.Size = new Size(102, 19);
            chbGreenPepper.TabIndex = 5;
            chbGreenPepper.Tag = "5";
            chbGreenPepper.Text = "Green Peppers";
            chbGreenPepper.UseVisualStyleBackColor = true;
            chbGreenPepper.CheckedChanged += chbGreenPepper_CheckedChanged;
            // 
            // chbOlives
            // 
            chbOlives.AutoSize = true;
            chbOlives.Location = new Point(98, 67);
            chbOlives.Name = "chbOlives";
            chbOlives.Size = new Size(58, 19);
            chbOlives.TabIndex = 4;
            chbOlives.Tag = "5";
            chbOlives.Text = "Olives";
            chbOlives.UseVisualStyleBackColor = true;
            chbOlives.CheckedChanged += chbOlives_CheckedChanged;
            // 
            // chbOnion
            // 
            chbOnion.AutoSize = true;
            chbOnion.Location = new Point(97, 27);
            chbOnion.Name = "chbOnion";
            chbOnion.Size = new Size(59, 19);
            chbOnion.TabIndex = 3;
            chbOnion.Tag = "5";
            chbOnion.Text = "Onion";
            chbOnion.UseVisualStyleBackColor = true;
            chbOnion.CheckedChanged += chbOnion_CheckedChanged;
            // 
            // chbTomatoes
            // 
            chbTomatoes.AutoSize = true;
            chbTomatoes.Location = new Point(7, 103);
            chbTomatoes.Name = "chbTomatoes";
            chbTomatoes.Size = new Size(77, 19);
            chbTomatoes.TabIndex = 2;
            chbTomatoes.Tag = "5";
            chbTomatoes.Text = "Tomatoes";
            chbTomatoes.UseVisualStyleBackColor = true;
            chbTomatoes.CheckedChanged += chbTomatoes_CheckedChanged;
            // 
            // chbMushroom
            // 
            chbMushroom.AutoSize = true;
            chbMushroom.Location = new Point(6, 67);
            chbMushroom.Name = "chbMushroom";
            chbMushroom.Size = new Size(85, 19);
            chbMushroom.TabIndex = 1;
            chbMushroom.Tag = "5";
            chbMushroom.Text = "Mushroom";
            chbMushroom.UseVisualStyleBackColor = true;
            chbMushroom.CheckedChanged += chbMushroom_CheckedChanged;
            // 
            // chbExtra
            // 
            chbExtra.AutoSize = true;
            chbExtra.Location = new Point(7, 27);
            chbExtra.Name = "chbExtra";
            chbExtra.Size = new Size(87, 19);
            chbExtra.TabIndex = 0;
            chbExtra.Tag = "5";
            chbExtra.Text = "Extra Chees";
            chbExtra.UseVisualStyleBackColor = true;
            chbExtra.CheckedChanged += chbExtra_CheckedChanged;
            // 
            // gbSummary
            // 
            gbSummary.Controls.Add(lblTotalPrice);
            gbSummary.Controls.Add(lblWhere);
            gbSummary.Controls.Add(lblCrust);
            gbSummary.Controls.Add(lblToppings);
            gbSummary.Controls.Add(lblSize);
            gbSummary.Controls.Add(label5);
            gbSummary.Controls.Add(label4);
            gbSummary.Controls.Add(label3);
            gbSummary.Controls.Add(label2);
            gbSummary.Controls.Add(label1);
            gbSummary.FlatStyle = FlatStyle.Flat;
            gbSummary.ForeColor = SystemColors.ControlText;
            gbSummary.Location = new Point(564, 117);
            gbSummary.Name = "gbSummary";
            gbSummary.Size = new Size(226, 293);
            gbSummary.TabIndex = 2;
            gbSummary.TabStop = false;
            gbSummary.Text = "Order Summary";
            // 
            // lblTotalPrice
            // 
            lblTotalPrice.AutoSize = true;
            lblTotalPrice.Font = new Font("Showcard Gothic", 36F, FontStyle.Regular, GraphicsUnit.Point);
            lblTotalPrice.ForeColor = Color.FromArgb(0, 192, 0);
            lblTotalPrice.Location = new Point(102, 233);
            lblTotalPrice.Name = "lblTotalPrice";
            lblTotalPrice.Size = new Size(0, 60);
            lblTotalPrice.TabIndex = 9;
            // 
            // lblWhere
            // 
            lblWhere.AutoSize = true;
            lblWhere.Location = new Point(102, 183);
            lblWhere.Name = "lblWhere";
            lblWhere.Size = new Size(0, 15);
            lblWhere.TabIndex = 8;
            // 
            // lblCrust
            // 
            lblCrust.AutoSize = true;
            lblCrust.Location = new Point(85, 133);
            lblCrust.Name = "lblCrust";
            lblCrust.Size = new Size(0, 15);
            lblCrust.TabIndex = 7;
            // 
            // lblToppings
            // 
            lblToppings.Location = new Point(86, 69);
            lblToppings.Name = "lblToppings";
            lblToppings.Size = new Size(157, 53);
            lblToppings.TabIndex = 6;
            // 
            // lblSize
            // 
            lblSize.AutoSize = true;
            lblSize.Location = new Point(47, 26);
            lblSize.Name = "lblSize";
            lblSize.Size = new Size(0, 15);
            lblSize.TabIndex = 5;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = SystemColors.ControlText;
            label5.Location = new Point(7, 231);
            label5.Name = "label5";
            label5.Size = new Size(68, 15);
            label5.TabIndex = 4;
            label5.Text = "Total Price:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = SystemColors.ControlText;
            label4.Location = new Point(7, 181);
            label4.Name = "label4";
            label4.Size = new Size(84, 15);
            label4.TabIndex = 3;
            label4.Text = "Where To Eat:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.ControlText;
            label3.Location = new Point(7, 133);
            label3.Name = "label3";
            label3.Size = new Size(68, 15);
            label3.TabIndex = 2;
            label3.Text = "Crust Type:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ControlText;
            label2.Location = new Point(7, 76);
            label2.Name = "label2";
            label2.Size = new Size(59, 15);
            label2.TabIndex = 1;
            label2.Text = "Toppings:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ControlText;
            label1.Location = new Point(6, 26);
            label1.Name = "label1";
            label1.Size = new Size(33, 15);
            label1.TabIndex = 0;
            label1.Text = "Size:";
            // 
            // gbCrust
            // 
            gbCrust.Controls.Add(rbThick);
            gbCrust.Controls.Add(rbThin);
            gbCrust.Location = new Point(3, 270);
            gbCrust.Name = "gbCrust";
            gbCrust.Size = new Size(209, 111);
            gbCrust.TabIndex = 3;
            gbCrust.TabStop = false;
            gbCrust.Text = "Crust Type";
            // 
            // rbThick
            // 
            rbThick.Location = new Point(6, 67);
            rbThick.Name = "rbThick";
            rbThick.Size = new Size(84, 19);
            rbThick.TabIndex = 1;
            rbThick.Tag = "10";
            rbThick.Text = "Thick Crust";
            rbThick.UseVisualStyleBackColor = true;
            rbThick.CheckedChanged += rbThick_CheckedChanged;
            // 
            // rbThin
            // 
            rbThin.AutoSize = true;
            rbThin.Checked = true;
            rbThin.Location = new Point(6, 31);
            rbThin.Name = "rbThin";
            rbThin.Size = new Size(79, 19);
            rbThin.TabIndex = 0;
            rbThin.TabStop = true;
            rbThin.Tag = "0";
            rbThin.Text = "Thin Crust";
            rbThin.UseVisualStyleBackColor = true;
            rbThin.CheckedChanged += rbThin_CheckedChanged;
            // 
            // gbWhereEat
            // 
            gbWhereEat.Controls.Add(rbEatIn);
            gbWhereEat.Controls.Add(rbEatOut);
            gbWhereEat.Location = new Point(269, 283);
            gbWhereEat.Name = "gbWhereEat";
            gbWhereEat.Size = new Size(236, 73);
            gbWhereEat.TabIndex = 4;
            gbWhereEat.TabStop = false;
            gbWhereEat.Text = "Where To Eat";
            // 
            // rbEatIn
            // 
            rbEatIn.AutoSize = true;
            rbEatIn.Checked = true;
            rbEatIn.Location = new Point(6, 35);
            rbEatIn.Name = "rbEatIn";
            rbEatIn.Size = new Size(54, 19);
            rbEatIn.TabIndex = 1;
            rbEatIn.TabStop = true;
            rbEatIn.Text = "Eat In";
            rbEatIn.UseVisualStyleBackColor = true;
            rbEatIn.CheckedChanged += rbEatIn_CheckedChanged;
            // 
            // rbEatOut
            // 
            rbEatOut.AutoSize = true;
            rbEatOut.Location = new Point(120, 35);
            rbEatOut.Name = "rbEatOut";
            rbEatOut.Size = new Size(64, 19);
            rbEatOut.TabIndex = 0;
            rbEatOut.Text = "Eat Out";
            rbEatOut.UseVisualStyleBackColor = true;
            rbEatOut.CheckedChanged += rbEatOut_CheckedChanged;
            // 
            // btnOrder
            // 
            btnOrder.Location = new Point(269, 376);
            btnOrder.Name = "btnOrder";
            btnOrder.Size = new Size(75, 34);
            btnOrder.TabIndex = 5;
            btnOrder.Text = "Order Pizza";
            btnOrder.UseVisualStyleBackColor = true;
            btnOrder.Click += rbOrder_Click;
            // 
            // rbReset
            // 
            rbReset.Location = new Point(429, 376);
            rbReset.Name = "rbReset";
            rbReset.Size = new Size(86, 34);
            rbReset.TabIndex = 6;
            rbReset.Text = "Reset";
            rbReset.UseVisualStyleBackColor = true;
            rbReset.Click += rbReset_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Showcard Gothic", 36F, FontStyle.Regular, GraphicsUnit.Point);
            label6.ForeColor = Color.FromArgb(192, 0, 0);
            label6.Location = new Point(195, 28);
            label6.Name = "label6";
            label6.Size = new Size(454, 60);
            label6.TabIndex = 7;
            label6.Text = "MAKE YOUR PIZZA";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(878, 554);
            Controls.Add(label6);
            Controls.Add(rbReset);
            Controls.Add(btnOrder);
            Controls.Add(gbWhereEat);
            Controls.Add(gbCrust);
            Controls.Add(gbSummary);
            Controls.Add(gbToppings);
            Controls.Add(gbSize);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            Text = "Pizza Order";
            Load += Form1_Load;
            gbSize.ResumeLayout(false);
            gbSize.PerformLayout();
            gbToppings.ResumeLayout(false);
            gbToppings.PerformLayout();
            gbSummary.ResumeLayout(false);
            gbSummary.PerformLayout();
            gbCrust.ResumeLayout(false);
            gbCrust.PerformLayout();
            gbWhereEat.ResumeLayout(false);
            gbWhereEat.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox gbSize;
        private RadioButton rbLarge;
        private RadioButton rbMedium;
        private RadioButton rbSmall;
        private GroupBox gbToppings;
        private CheckBox chbGreenPepper;
        private CheckBox chbOlives;
        private CheckBox chbOnion;
        private CheckBox chbTomatoes;
        private CheckBox chbMushroom;
        private CheckBox chbExtra;
        private GroupBox gbSummary;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private GroupBox gbCrust;
        private RadioButton rbThick;
        private RadioButton rbThin;
        private GroupBox gbWhereEat;
        private RadioButton rbEatIn;
        private RadioButton rbEatOut;
        private Button btnOrder;
        private Button rbReset;
        private Label lblToppings;
        private Label lblSize;
        private Label lblTotalPrice;
        private Label lblWhere;
        private Label lblCrust;
        private Label label6;
        private Label label7;
    }
}