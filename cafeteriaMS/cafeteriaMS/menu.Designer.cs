﻿
namespace cafeteriaMS
{
    partial class formMenu
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
            this.button1 = new System.Windows.Forms.Button();
            this.dtpDeliveryTime = new System.Windows.Forms.DateTimePicker();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.linkLblAccount = new System.Windows.Forms.LinkLabel();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.comboFoodName = new System.Windows.Forms.ComboBox();
            this.lblFoodName = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.linkLblMenu = new System.Windows.Forms.LinkLabel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.linkLblOrder = new System.Windows.Forms.LinkLabel();
            this.linkLblHome = new System.Windows.Forms.LinkLabel();
            this.groupNav = new System.Windows.Forms.GroupBox();
            this.pictureLogo = new System.Windows.Forms.PictureBox();
            this.groupHome = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupNav.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureLogo)).BeginInit();
            this.groupHome.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(116, 299);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(206, 44);
            this.button1.TabIndex = 7;
            this.button1.Text = "Place Order";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // dtpDeliveryTime
            // 
            this.dtpDeliveryTime.Location = new System.Drawing.Point(151, 150);
            this.dtpDeliveryTime.Name = "dtpDeliveryTime";
            this.dtpDeliveryTime.Size = new System.Drawing.Size(200, 20);
            this.dtpDeliveryTime.TabIndex = 5;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(152, 108);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(119, 20);
            this.numericUpDown1.TabIndex = 4;
            // 
            // linkLblAccount
            // 
            this.linkLblAccount.AutoSize = true;
            this.linkLblAccount.BackColor = System.Drawing.Color.MistyRose;
            this.linkLblAccount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.linkLblAccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLblAccount.LinkColor = System.Drawing.Color.Blue;
            this.linkLblAccount.Location = new System.Drawing.Point(770, 35);
            this.linkLblAccount.Name = "linkLblAccount";
            this.linkLblAccount.Size = new System.Drawing.Size(89, 26);
            this.linkLblAccount.TabIndex = 4;
            this.linkLblAccount.TabStop = true;
            this.linkLblAccount.Text = "Account";
            // 
            // lblQuantity
            // 
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuantity.Location = new System.Drawing.Point(17, 106);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(76, 20);
            this.lblQuantity.TabIndex = 3;
            this.lblQuantity.Text = "Quantity";
            // 
            // comboFoodName
            // 
            this.comboFoodName.FormattingEnabled = true;
            this.comboFoodName.Items.AddRange(new object[] {
            "Idly",
            "Dosa",
            "Rice",
            "Pizza",
            "Pulav"});
            this.comboFoodName.Location = new System.Drawing.Point(151, 59);
            this.comboFoodName.Name = "comboFoodName";
            this.comboFoodName.Size = new System.Drawing.Size(121, 21);
            this.comboFoodName.TabIndex = 2;
            // 
            // lblFoodName
            // 
            this.lblFoodName.AutoSize = true;
            this.lblFoodName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFoodName.Location = new System.Drawing.Point(17, 58);
            this.lblFoodName.Name = "lblFoodName";
            this.lblFoodName.Size = new System.Drawing.Size(101, 20);
            this.lblFoodName.TabIndex = 1;
            this.lblFoodName.Text = "Food Name";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.button1);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.dtpDeliveryTime);
            this.groupBox3.Controls.Add(this.numericUpDown1);
            this.groupBox3.Controls.Add(this.lblQuantity);
            this.groupBox3.Controls.Add(this.comboFoodName);
            this.groupBox3.Controls.Add(this.lblFoodName);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Location = new System.Drawing.Point(327, 73);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(465, 360);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(17, 151);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Delivery Time";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(175, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(156, 29);
            this.label2.TabIndex = 0;
            this.label2.Text = "Order Details";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Gainsboro;
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(3, 10);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(884, 57);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(381, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(184, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "Food Menu";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::cafeteriaMS.Properties.Resources.orderFood;
            this.pictureBox1.Location = new System.Drawing.Point(6, 105);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(314, 294);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // linkLblMenu
            // 
            this.linkLblMenu.AutoSize = true;
            this.linkLblMenu.BackColor = System.Drawing.Color.White;
            this.linkLblMenu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.linkLblMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLblMenu.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.linkLblMenu.Location = new System.Drawing.Point(670, 35);
            this.linkLblMenu.Name = "linkLblMenu";
            this.linkLblMenu.Size = new System.Drawing.Size(65, 26);
            this.linkLblMenu.TabIndex = 3;
            this.linkLblMenu.TabStop = true;
            this.linkLblMenu.Text = "Menu";
            this.linkLblMenu.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLblMenu_LinkClicked);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.groupBox1.Location = new System.Drawing.Point(29, 107);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(887, 439);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // linkLblOrder
            // 
            this.linkLblOrder.AutoSize = true;
            this.linkLblOrder.BackColor = System.Drawing.Color.White;
            this.linkLblOrder.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.linkLblOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLblOrder.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.linkLblOrder.Location = new System.Drawing.Point(572, 35);
            this.linkLblOrder.Name = "linkLblOrder";
            this.linkLblOrder.Size = new System.Drawing.Size(66, 26);
            this.linkLblOrder.TabIndex = 2;
            this.linkLblOrder.TabStop = true;
            this.linkLblOrder.Text = "Order";
            this.linkLblOrder.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLblOrder_LinkClicked);
            // 
            // linkLblHome
            // 
            this.linkLblHome.AutoSize = true;
            this.linkLblHome.BackColor = System.Drawing.Color.White;
            this.linkLblHome.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.linkLblHome.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLblHome.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.linkLblHome.Location = new System.Drawing.Point(466, 35);
            this.linkLblHome.Name = "linkLblHome";
            this.linkLblHome.Size = new System.Drawing.Size(68, 26);
            this.linkLblHome.TabIndex = 0;
            this.linkLblHome.TabStop = true;
            this.linkLblHome.Text = "Home";
            this.linkLblHome.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLblHome_LinkClicked);
            // 
            // groupNav
            // 
            this.groupNav.Controls.Add(this.linkLblAccount);
            this.groupNav.Controls.Add(this.linkLblMenu);
            this.groupNav.Controls.Add(this.linkLblOrder);
            this.groupNav.Controls.Add(this.pictureLogo);
            this.groupNav.Controls.Add(this.linkLblHome);
            this.groupNav.Location = new System.Drawing.Point(29, 12);
            this.groupNav.Name = "groupNav";
            this.groupNav.Size = new System.Drawing.Size(887, 90);
            this.groupNav.TabIndex = 2;
            this.groupNav.TabStop = false;
            // 
            // pictureLogo
            // 
            this.pictureLogo.Image = global::cafeteriaMS.Properties.Resources.logo;
            this.pictureLogo.InitialImage = null;
            this.pictureLogo.Location = new System.Drawing.Point(6, 11);
            this.pictureLogo.Name = "pictureLogo";
            this.pictureLogo.Size = new System.Drawing.Size(119, 71);
            this.pictureLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureLogo.TabIndex = 1;
            this.pictureLogo.TabStop = false;
            // 
            // groupHome
            // 
            this.groupHome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.groupHome.Controls.Add(this.groupNav);
            this.groupHome.Controls.Add(this.groupBox1);
            this.groupHome.Location = new System.Drawing.Point(33, 2);
            this.groupHome.Name = "groupHome";
            this.groupHome.Size = new System.Drawing.Size(940, 578);
            this.groupHome.TabIndex = 2;
            this.groupHome.TabStop = false;
            // 
            // formMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(995, 586);
            this.Controls.Add(this.groupHome);
            this.Name = "formMenu";
            this.Text = "Menu";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupNav.ResumeLayout(false);
            this.groupNav.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureLogo)).EndInit();
            this.groupHome.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DateTimePicker dtpDeliveryTime;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.LinkLabel linkLblAccount;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.ComboBox comboFoodName;
        private System.Windows.Forms.Label lblFoodName;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.LinkLabel linkLblMenu;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.LinkLabel linkLblOrder;
        private System.Windows.Forms.LinkLabel linkLblHome;
        private System.Windows.Forms.GroupBox groupNav;
        private System.Windows.Forms.PictureBox pictureLogo;
        private System.Windows.Forms.GroupBox groupHome;
    }
}