namespace Lab_09
{
    partial class Registration
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
            this.loginLink = new System.Windows.Forms.LinkLabel();
            this.label2 = new System.Windows.Forms.Label();
            this.userLabel = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.repasstxt = new System.Windows.Forms.TextBox();
            this.passLabel = new System.Windows.Forms.Label();
            this.regClick = new System.Windows.Forms.Button();
            this.passtxt = new System.Windows.Forms.TextBox();
            this.regLabel = new System.Windows.Forms.Label();
            this.nametxt = new System.Windows.Forms.TextBox();
            this.usertxt = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // loginLink
            // 
            this.loginLink.AutoSize = true;
            this.loginLink.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.loginLink.Location = new System.Drawing.Point(436, 364);
            this.loginLink.Name = "loginLink";
            this.loginLink.Size = new System.Drawing.Size(43, 16);
            this.loginLink.TabIndex = 29;
            this.loginLink.TabStop = true;
            this.loginLink.Text = "Log In";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(259, 361);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(177, 20);
            this.label2.TabIndex = 28;
            this.label2.Text = "Don\'t have an account?";
            // 
            // userLabel
            // 
            this.userLabel.AutoSize = true;
            this.userLabel.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userLabel.Location = new System.Drawing.Point(226, 124);
            this.userLabel.Name = "userLabel";
            this.userLabel.Size = new System.Drawing.Size(96, 24);
            this.userLabel.TabIndex = 27;
            this.userLabel.Text = "Username";
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameLabel.Location = new System.Drawing.Point(226, 164);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(62, 24);
            this.nameLabel.TabIndex = 26;
            this.nameLabel.Text = "Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(226, 247);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(165, 24);
            this.label1.TabIndex = 25;
            this.label1.Text = "Confirm Password";
            // 
            // repasstxt
            // 
            this.repasstxt.Location = new System.Drawing.Point(399, 249);
            this.repasstxt.Name = "repasstxt";
            this.repasstxt.Size = new System.Drawing.Size(176, 22);
            this.repasstxt.TabIndex = 24;
            // 
            // passLabel
            // 
            this.passLabel.AutoSize = true;
            this.passLabel.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passLabel.Location = new System.Drawing.Point(226, 209);
            this.passLabel.Name = "passLabel";
            this.passLabel.Size = new System.Drawing.Size(91, 24);
            this.passLabel.TabIndex = 23;
            this.passLabel.Text = "Password";
            // 
            // regClick
            // 
            this.regClick.Font = new System.Drawing.Font("Microsoft YaHei UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.regClick.Location = new System.Drawing.Point(399, 296);
            this.regClick.Name = "regClick";
            this.regClick.Size = new System.Drawing.Size(87, 40);
            this.regClick.TabIndex = 22;
            this.regClick.Text = "Register";
            this.regClick.UseVisualStyleBackColor = true;
            // 
            // passtxt
            // 
            this.passtxt.Location = new System.Drawing.Point(357, 209);
            this.passtxt.Name = "passtxt";
            this.passtxt.Size = new System.Drawing.Size(176, 22);
            this.passtxt.TabIndex = 21;
            // 
            // regLabel
            // 
            this.regLabel.AutoSize = true;
            this.regLabel.Font = new System.Drawing.Font("Microsoft YaHei UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.regLabel.Location = new System.Drawing.Point(393, 70);
            this.regLabel.Name = "regLabel";
            this.regLabel.Size = new System.Drawing.Size(109, 31);
            this.regLabel.TabIndex = 20;
            this.regLabel.Text = "Register";
            // 
            // nametxt
            // 
            this.nametxt.Location = new System.Drawing.Point(357, 167);
            this.nametxt.Name = "nametxt";
            this.nametxt.Size = new System.Drawing.Size(176, 22);
            this.nametxt.TabIndex = 19;
            // 
            // usertxt
            // 
            this.usertxt.Location = new System.Drawing.Point(357, 124);
            this.usertxt.Name = "usertxt";
            this.usertxt.Size = new System.Drawing.Size(176, 22);
            this.usertxt.TabIndex = 18;
            // 
            // Registration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.loginLink);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.userLabel);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.repasstxt);
            this.Controls.Add(this.passLabel);
            this.Controls.Add(this.regClick);
            this.Controls.Add(this.passtxt);
            this.Controls.Add(this.regLabel);
            this.Controls.Add(this.nametxt);
            this.Controls.Add(this.usertxt);
            this.Name = "Registration";
            this.Text = "Registration";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel loginLink;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label userLabel;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox repasstxt;
        private System.Windows.Forms.Label passLabel;
        private System.Windows.Forms.Button regClick;
        private System.Windows.Forms.TextBox passtxt;
        private System.Windows.Forms.Label regLabel;
        private System.Windows.Forms.TextBox nametxt;
        private System.Windows.Forms.TextBox usertxt;
    }
}