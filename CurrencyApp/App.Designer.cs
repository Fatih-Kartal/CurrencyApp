﻿namespace CurrencyApp
{
    partial class App
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(App));
            this.pinToTopButton = new System.Windows.Forms.Button();
            this.imageList = new System.Windows.Forms.ImageList(this.components);
            this.CurrencyLabel4 = new System.Windows.Forms.Label();
            this.USDBuyingPriceLabel = new System.Windows.Forms.Label();
            this.EURBuyingPriceLabel = new System.Windows.Forms.Label();
            this.CurrencyLabel1 = new System.Windows.Forms.Label();
            this.CurrencyLabel2 = new System.Windows.Forms.Label();
            this.CurrencyLabel3 = new System.Windows.Forms.Label();
            this.GBPBuyingPriceLabel = new System.Windows.Forms.Label();
            this.GoldBuyingPriceLabel = new System.Windows.Forms.Label();
            this.USDSellingPriceLabel = new System.Windows.Forms.Label();
            this.EURSellingPriceLabel = new System.Windows.Forms.Label();
            this.GBPSellingPriceLabel = new System.Windows.Forms.Label();
            this.GoldSellingPriceLabel = new System.Windows.Forms.Label();
            this.exitButton = new System.Windows.Forms.Button();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.moveButon = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.notifyIconContextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.notifyIconContextMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // pinToTopButton
            // 
            this.pinToTopButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.pinToTopButton.ImageKey = "pin_icon";
            this.pinToTopButton.ImageList = this.imageList;
            this.pinToTopButton.Location = new System.Drawing.Point(163, 9);
            this.pinToTopButton.Name = "pinToTopButton";
            this.pinToTopButton.Size = new System.Drawing.Size(75, 23);
            this.pinToTopButton.TabIndex = 0;
            this.pinToTopButton.Text = "Pin";
            this.pinToTopButton.UseVisualStyleBackColor = true;
            this.pinToTopButton.Click += new System.EventHandler(this.pinToTopButton_Click);
            // 
            // imageList
            // 
            this.imageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList.ImageStream")));
            this.imageList.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList.Images.SetKeyName(0, "pin_icon");
            this.imageList.Images.SetKeyName(1, "exit_icon");
            // 
            // CurrencyLabel4
            // 
            this.CurrencyLabel4.AutoSize = true;
            this.CurrencyLabel4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.CurrencyLabel4.ForeColor = System.Drawing.SystemColors.Control;
            this.CurrencyLabel4.Location = new System.Drawing.Point(12, 69);
            this.CurrencyLabel4.Name = "CurrencyLabel4";
            this.CurrencyLabel4.Size = new System.Drawing.Size(33, 13);
            this.CurrencyLabel4.TabIndex = 1;
            this.CurrencyLabel4.Text = "Gold";
            // 
            // USDBuyingPriceLabel
            // 
            this.USDBuyingPriceLabel.AutoSize = true;
            this.USDBuyingPriceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.USDBuyingPriceLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.USDBuyingPriceLabel.Location = new System.Drawing.Point(59, 9);
            this.USDBuyingPriceLabel.Name = "USDBuyingPriceLabel";
            this.USDBuyingPriceLabel.Size = new System.Drawing.Size(32, 13);
            this.USDBuyingPriceLabel.TabIndex = 2;
            this.USDBuyingPriceLabel.Text = "0.00";
            // 
            // EURBuyingPriceLabel
            // 
            this.EURBuyingPriceLabel.AutoSize = true;
            this.EURBuyingPriceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.EURBuyingPriceLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.EURBuyingPriceLabel.Location = new System.Drawing.Point(59, 29);
            this.EURBuyingPriceLabel.Name = "EURBuyingPriceLabel";
            this.EURBuyingPriceLabel.Size = new System.Drawing.Size(32, 13);
            this.EURBuyingPriceLabel.TabIndex = 3;
            this.EURBuyingPriceLabel.Text = "0.00";
            // 
            // CurrencyLabel1
            // 
            this.CurrencyLabel1.AutoSize = true;
            this.CurrencyLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.CurrencyLabel1.ForeColor = System.Drawing.SystemColors.Control;
            this.CurrencyLabel1.Location = new System.Drawing.Point(12, 9);
            this.CurrencyLabel1.Name = "CurrencyLabel1";
            this.CurrencyLabel1.Size = new System.Drawing.Size(33, 13);
            this.CurrencyLabel1.TabIndex = 4;
            this.CurrencyLabel1.Text = "USD";
            // 
            // CurrencyLabel2
            // 
            this.CurrencyLabel2.AutoSize = true;
            this.CurrencyLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.CurrencyLabel2.ForeColor = System.Drawing.SystemColors.Control;
            this.CurrencyLabel2.Location = new System.Drawing.Point(12, 29);
            this.CurrencyLabel2.Name = "CurrencyLabel2";
            this.CurrencyLabel2.Size = new System.Drawing.Size(33, 13);
            this.CurrencyLabel2.TabIndex = 5;
            this.CurrencyLabel2.Text = "EUR";
            // 
            // CurrencyLabel3
            // 
            this.CurrencyLabel3.AutoSize = true;
            this.CurrencyLabel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.CurrencyLabel3.ForeColor = System.Drawing.SystemColors.Control;
            this.CurrencyLabel3.Location = new System.Drawing.Point(12, 49);
            this.CurrencyLabel3.Name = "CurrencyLabel3";
            this.CurrencyLabel3.Size = new System.Drawing.Size(32, 13);
            this.CurrencyLabel3.TabIndex = 6;
            this.CurrencyLabel3.Text = "GBP";
            // 
            // GBPBuyingPriceLabel
            // 
            this.GBPBuyingPriceLabel.AutoSize = true;
            this.GBPBuyingPriceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.GBPBuyingPriceLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.GBPBuyingPriceLabel.Location = new System.Drawing.Point(59, 49);
            this.GBPBuyingPriceLabel.Name = "GBPBuyingPriceLabel";
            this.GBPBuyingPriceLabel.Size = new System.Drawing.Size(32, 13);
            this.GBPBuyingPriceLabel.TabIndex = 7;
            this.GBPBuyingPriceLabel.Text = "0.00";
            // 
            // GoldBuyingPriceLabel
            // 
            this.GoldBuyingPriceLabel.AutoSize = true;
            this.GoldBuyingPriceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.GoldBuyingPriceLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.GoldBuyingPriceLabel.Location = new System.Drawing.Point(59, 69);
            this.GoldBuyingPriceLabel.Name = "GoldBuyingPriceLabel";
            this.GoldBuyingPriceLabel.Size = new System.Drawing.Size(32, 13);
            this.GoldBuyingPriceLabel.TabIndex = 8;
            this.GoldBuyingPriceLabel.Text = "0.00";
            // 
            // USDSellingPriceLabel
            // 
            this.USDSellingPriceLabel.AutoSize = true;
            this.USDSellingPriceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.USDSellingPriceLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.USDSellingPriceLabel.Location = new System.Drawing.Point(109, 9);
            this.USDSellingPriceLabel.Name = "USDSellingPriceLabel";
            this.USDSellingPriceLabel.Size = new System.Drawing.Size(32, 13);
            this.USDSellingPriceLabel.TabIndex = 9;
            this.USDSellingPriceLabel.Text = "0.00";
            // 
            // EURSellingPriceLabel
            // 
            this.EURSellingPriceLabel.AutoSize = true;
            this.EURSellingPriceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.EURSellingPriceLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.EURSellingPriceLabel.Location = new System.Drawing.Point(109, 29);
            this.EURSellingPriceLabel.Name = "EURSellingPriceLabel";
            this.EURSellingPriceLabel.Size = new System.Drawing.Size(32, 13);
            this.EURSellingPriceLabel.TabIndex = 10;
            this.EURSellingPriceLabel.Text = "0.00";
            // 
            // GBPSellingPriceLabel
            // 
            this.GBPSellingPriceLabel.AutoSize = true;
            this.GBPSellingPriceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.GBPSellingPriceLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.GBPSellingPriceLabel.Location = new System.Drawing.Point(109, 49);
            this.GBPSellingPriceLabel.Name = "GBPSellingPriceLabel";
            this.GBPSellingPriceLabel.Size = new System.Drawing.Size(32, 13);
            this.GBPSellingPriceLabel.TabIndex = 11;
            this.GBPSellingPriceLabel.Text = "0.00";
            // 
            // GoldSellingPriceLabel
            // 
            this.GoldSellingPriceLabel.AutoSize = true;
            this.GoldSellingPriceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.GoldSellingPriceLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.GoldSellingPriceLabel.Location = new System.Drawing.Point(109, 69);
            this.GoldSellingPriceLabel.Name = "GoldSellingPriceLabel";
            this.GoldSellingPriceLabel.Size = new System.Drawing.Size(32, 13);
            this.GoldSellingPriceLabel.TabIndex = 12;
            this.GoldSellingPriceLabel.Text = "0.00";
            // 
            // exitButton
            // 
            this.exitButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.exitButton.ImageKey = "exit_icon";
            this.exitButton.ImageList = this.imageList;
            this.exitButton.Location = new System.Drawing.Point(163, 58);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 23);
            this.exitButton.TabIndex = 13;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // timer
            // 
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.Timer_Tick);
            // 
            // moveButon
            // 
            this.moveButon.Font = new System.Drawing.Font("Microsoft Sans Serif", 5.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.moveButon.Location = new System.Drawing.Point(163, 38);
            this.moveButon.Name = "moveButon";
            this.moveButon.Size = new System.Drawing.Size(34, 14);
            this.moveButon.TabIndex = 14;
            this.moveButon.Text = "MOVE";
            this.moveButon.UseVisualStyleBackColor = true;
            this.moveButon.Click += new System.EventHandler(this.moveButon_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 5.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(203, 38);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(34, 14);
            this.button1.TabIndex = 15;
            this.button1.Text = "Options";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // notifyIcon
            // 
            this.notifyIcon.ContextMenuStrip = this.notifyIconContextMenu;
            this.notifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon.Icon")));
            this.notifyIcon.Text = "Currency App";
            this.notifyIcon.Visible = true;
            // 
            // notifyIconContextMenu
            // 
            this.notifyIconContextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.notifyIconContextMenu.Name = "notifyIconContextMenu";
            this.notifyIconContextMenu.Size = new System.Drawing.Size(94, 26);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(93, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // App
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Desktop;
            this.ClientSize = new System.Drawing.Size(250, 94);
            this.ControlBox = false;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.moveButon);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.GoldSellingPriceLabel);
            this.Controls.Add(this.GBPSellingPriceLabel);
            this.Controls.Add(this.EURSellingPriceLabel);
            this.Controls.Add(this.USDSellingPriceLabel);
            this.Controls.Add(this.GoldBuyingPriceLabel);
            this.Controls.Add(this.GBPBuyingPriceLabel);
            this.Controls.Add(this.CurrencyLabel3);
            this.Controls.Add(this.CurrencyLabel2);
            this.Controls.Add(this.CurrencyLabel1);
            this.Controls.Add(this.EURBuyingPriceLabel);
            this.Controls.Add(this.USDBuyingPriceLabel);
            this.Controls.Add(this.CurrencyLabel4);
            this.Controls.Add(this.pinToTopButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "App";
            this.ShowInTaskbar = false;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.App_Load);
            this.notifyIconContextMenu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button pinToTopButton;
        private System.Windows.Forms.ImageList imageList;
        private System.Windows.Forms.Label CurrencyLabel4;
        private System.Windows.Forms.Label USDBuyingPriceLabel;
        private System.Windows.Forms.Label EURBuyingPriceLabel;
        private System.Windows.Forms.Label CurrencyLabel1;
        private System.Windows.Forms.Label CurrencyLabel2;
        private System.Windows.Forms.Label CurrencyLabel3;
        private System.Windows.Forms.Label GBPBuyingPriceLabel;
        private System.Windows.Forms.Label GoldBuyingPriceLabel;
        private System.Windows.Forms.Label USDSellingPriceLabel;
        private System.Windows.Forms.Label EURSellingPriceLabel;
        private System.Windows.Forms.Label GBPSellingPriceLabel;
        private System.Windows.Forms.Label GoldSellingPriceLabel;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Button moveButon;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.NotifyIcon notifyIcon;
        private System.Windows.Forms.ContextMenuStrip notifyIconContextMenu;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
    }
}

