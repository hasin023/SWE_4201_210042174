namespace Lab_09
{
    partial class Login
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
            this.regLink = new System.Windows.Forms.LinkLabel();
            this.regLabel = new System.Windows.Forms.Label();
            this.userLabel = new System.Windows.Forms.Label();
            this.passLabel = new System.Windows.Forms.Label();
            this.loginClick = new System.Windows.Forms.Button();
            this.LoginLabel = new System.Windows.Forms.Label();
            this.passtxt = new System.Windows.Forms.TextBox();
            this.usertxt = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // regLink
            // 
            this.regLink.AutoSize = true;
            this.regLink.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.regLink.Location = new System.Drawing.Point(434, 359);
            this.regLink.Name = "regLink";
            this.regLink.Size = new System.Drawing.Size(79, 16);
            this.regLink.TabIndex = 17;
            this.regLink.TabStop = true;
            this.regLink.Text = "Create one!!";
            // 
            // regLabel
            // 
            this.regLabel.AutoSize = true;
            this.regLabel.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.regLabel.Location = new System.Drawing.Point(257, 356);
            this.regLabel.Name = "regLabel";
            this.regLabel.Size = new System.Drawing.Size(177, 20);
            this.regLabel.TabIndex = 16;
            this.regLabel.Text = "Don\'t have an account?";
            // 
            // userLabel
            // 
            this.userLabel.AutoSize = true;
            this.userLabel.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userLabel.Location = new System.Drawing.Point(205, 139);
            this.userLabel.Name = "userLabel";
            this.userLabel.Size = new System.Drawing.Size(96, 24);
            this.userLabel.TabIndex = 15;
            this.userLabel.Text = "Username";
            // 
            // passLabel
            // 
            this.passLabel.AutoSize = true;
            this.passLabel.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passLabel.Location = new System.Drawing.Point(205, 196);
            this.passLabel.Name = "passLabel";
            this.passLabel.Size = new System.Drawing.Size(91, 24);
            this.passLabel.TabIndex = 14;
            this.passLabel.Text = "Password";
            // 
            // loginClick
            // 
            this.loginClick.Font = new System.Drawing.Font("Microsoft YaHei UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginClick.Location = new System.Drawing.Point(379, 263);
            this.loginClick.Name = "loginClick";
            this.loginClick.Size = new System.Drawing.Size(87, 40);
            this.loginClick.TabIndex = 13;
            this.loginClick.Text = "Login";
            this.loginClick.UseVisualStyleBackColor = true;
            // 
            // LoginLabel
            // 
            this.LoginLabel.AutoSize = true;
            this.LoginLabel.Font = new System.Drawing.Font("Microsoft YaHei UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoginLabel.Location = new System.Drawing.Point(387, 79);
            this.LoginLabel.Name = "LoginLabel";
            this.LoginLabel.Size = new System.Drawing.Size(79, 31);
            this.LoginLabel.TabIndex = 12;
            this.LoginLabel.Text = "Login";
            // 
            // passtxt
            // 
            this.passtxt.Location = new System.Drawing.Point(337, 196);
            this.passtxt.Name = "passtxt";
            this.passtxt.Size = new System.Drawing.Size(176, 22);
            this.passtxt.TabIndex = 11;
            // 
            // usertxt
            // 
            this.usertxt.Location = new System.Drawing.Point(337, 139);
            this.usertxt.Name = "usertxt";
            this.usertxt.Size = new System.Drawing.Size(176, 22);
            this.usertxt.TabIndex = 10;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.regLink);
            this.Controls.Add(this.regLabel);
            this.Controls.Add(this.userLabel);
            this.Controls.Add(this.passLabel);
            this.Controls.Add(this.loginClick);
            this.Controls.Add(this.LoginLabel);
            this.Controls.Add(this.passtxt);
            this.Controls.Add(this.usertxt);
            this.Name = "Login";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel regLink;
        private System.Windows.Forms.Label regLabel;
        private System.Windows.Forms.Label userLabel;
        private System.Windows.Forms.Label passLabel;
        private System.Windows.Forms.Button loginClick;
        private System.Windows.Forms.Label LoginLabel;
        private System.Windows.Forms.TextBox passtxt;
        private System.Windows.Forms.TextBox usertxt;
    }
}

