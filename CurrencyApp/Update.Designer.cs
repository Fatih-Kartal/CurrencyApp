namespace CurrencyApp
{
    partial class Update
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
            this.downloadingProgressBar = new System.Windows.Forms.ProgressBar();
            this.startUpdateButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // downloadingProgressBar
            // 
            this.downloadingProgressBar.Location = new System.Drawing.Point(12, 12);
            this.downloadingProgressBar.Name = "downloadingProgressBar";
            this.downloadingProgressBar.Size = new System.Drawing.Size(358, 39);
            this.downloadingProgressBar.TabIndex = 0;
            // 
            // startUpdateButton
            // 
            this.startUpdateButton.Location = new System.Drawing.Point(12, 57);
            this.startUpdateButton.Name = "startUpdateButton";
            this.startUpdateButton.Size = new System.Drawing.Size(358, 39);
            this.startUpdateButton.TabIndex = 1;
            this.startUpdateButton.Text = "Start Update";
            this.startUpdateButton.UseVisualStyleBackColor = true;
            this.startUpdateButton.Click += new System.EventHandler(this.startUpdateButton_Click);
            // 
            // Update
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(382, 103);
            this.Controls.Add(this.startUpdateButton);
            this.Controls.Add(this.downloadingProgressBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Update";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Update";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Update_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ProgressBar downloadingProgressBar;
        private System.Windows.Forms.Button startUpdateButton;
    }
}