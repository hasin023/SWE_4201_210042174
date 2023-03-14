namespace Lab_09
{
    partial class Dashboard
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
            this.dashLabel = new System.Windows.Forms.Label();
            this.logoutClick = new System.Windows.Forms.Button();
            this.userDLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // dashLabel
            // 
            this.dashLabel.AutoSize = true;
            this.dashLabel.Font = new System.Drawing.Font("Microsoft YaHei UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dashLabel.Location = new System.Drawing.Point(256, 168);
            this.dashLabel.Name = "dashLabel";
            this.dashLabel.Size = new System.Drawing.Size(129, 31);
            this.dashLabel.TabIndex = 21;
            this.dashLabel.Text = "Welcome ";
            // 
            // logoutClick
            // 
            this.logoutClick.Font = new System.Drawing.Font("Microsoft YaHei UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logoutClick.Location = new System.Drawing.Point(345, 248);
            this.logoutClick.Name = "logoutClick";
            this.logoutClick.Size = new System.Drawing.Size(87, 40);
            this.logoutClick.TabIndex = 20;
            this.logoutClick.Text = "Log Out";
            this.logoutClick.UseVisualStyleBackColor = true;
            // 
            // userDLabel
            // 
            this.userDLabel.AutoSize = true;
            this.userDLabel.Font = new System.Drawing.Font("Microsoft YaHei UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userDLabel.Location = new System.Drawing.Point(391, 168);
            this.userDLabel.Name = "userDLabel";
            this.userDLabel.Size = new System.Drawing.Size(127, 31);
            this.userDLabel.TabIndex = 22;
            this.userDLabel.Text = "username";
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.userDLabel);
            this.Controls.Add(this.dashLabel);
            this.Controls.Add(this.logoutClick);
            this.Name = "Dashboard";
            this.Text = "Dashboard";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label dashLabel;
        private System.Windows.Forms.Button logoutClick;
        private System.Windows.Forms.Label userDLabel;
    }
}