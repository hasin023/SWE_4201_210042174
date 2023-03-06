namespace Banking_Management_System
{
    partial class _bms
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
            this.bankName = new System.Windows.Forms.Label();
            this.accNo = new System.Windows.Forms.Label();
            this.userName = new System.Windows.Forms.Label();
            this.branch = new System.Windows.Forms.Label();
            this.initialdepo = new System.Windows.Forms.Label();
            this.type = new System.Windows.Forms.Label();
            this.createAcc = new System.Windows.Forms.Button();
            this.userNameBox = new System.Windows.Forms.TextBox();
            this.initialDepoBox = new System.Windows.Forms.TextBox();
            this.branchComboBox = new System.Windows.Forms.ComboBox();
            this.typeComboBox = new System.Windows.Forms.ComboBox();
            this.accNumberBox = new System.Windows.Forms.TextBox();
            this._accNumber = new System.Windows.Forms.Label();
            this._accNoTextBox = new System.Windows.Forms.TextBox();
            this.showButton = new System.Windows.Forms.Button();
            this.suspendButton = new System.Windows.Forms.Button();
            this.titleLabel = new System.Windows.Forms.Label();
            this.accNumBox2 = new System.Windows.Forms.TextBox();
            this.accNum2 = new System.Windows.Forms.Label();
            this.amountBox = new System.Windows.Forms.TextBox();
            this.amount = new System.Windows.Forms.Label();
            this.depositButton = new System.Windows.Forms.Button();
            this.withdrawButton = new System.Windows.Forms.Button();
            this.showBalButton = new System.Windows.Forms.Button();
            this.infoListBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // bankName
            // 
            this.bankName.AutoSize = true;
            this.bankName.Font = new System.Drawing.Font("MS Reference Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bankName.Location = new System.Drawing.Point(378, 27);
            this.bankName.Name = "bankName";
            this.bankName.Size = new System.Drawing.Size(380, 28);
            this.bankName.TabIndex = 0;
            this.bankName.Text = "AB Bank Limited, Bangladesh";
            // 
            // accNo
            // 
            this.accNo.AutoSize = true;
            this.accNo.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.accNo.Location = new System.Drawing.Point(7, 148);
            this.accNo.Name = "accNo";
            this.accNo.Size = new System.Drawing.Size(151, 19);
            this.accNo.TabIndex = 1;
            this.accNo.Text = "Account Number : ";
            // 
            // userName
            // 
            this.userName.AutoSize = true;
            this.userName.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userName.Location = new System.Drawing.Point(8, 199);
            this.userName.Name = "userName";
            this.userName.Size = new System.Drawing.Size(55, 19);
            this.userName.TabIndex = 2;
            this.userName.Text = "Name";
            // 
            // branch
            // 
            this.branch.AutoSize = true;
            this.branch.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.branch.Location = new System.Drawing.Point(9, 231);
            this.branch.Name = "branch";
            this.branch.Size = new System.Drawing.Size(62, 19);
            this.branch.TabIndex = 3;
            this.branch.Text = "Branch";
            // 
            // initialdepo
            // 
            this.initialdepo.AutoSize = true;
            this.initialdepo.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.initialdepo.Location = new System.Drawing.Point(9, 297);
            this.initialdepo.Name = "initialdepo";
            this.initialdepo.Size = new System.Drawing.Size(122, 19);
            this.initialdepo.TabIndex = 4;
            this.initialdepo.Text = "Initial Deposite";
            // 
            // type
            // 
            this.type.AutoSize = true;
            this.type.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.type.Location = new System.Drawing.Point(9, 263);
            this.type.Name = "type";
            this.type.Size = new System.Drawing.Size(113, 19);
            this.type.TabIndex = 5;
            this.type.Text = "Account Type";
            // 
            // createAcc
            // 
            this.createAcc.Location = new System.Drawing.Point(63, 394);
            this.createAcc.Name = "createAcc";
            this.createAcc.Size = new System.Drawing.Size(224, 23);
            this.createAcc.TabIndex = 6;
            this.createAcc.Text = "Create Account";
            this.createAcc.UseVisualStyleBackColor = true;
            this.createAcc.Click += new System.EventHandler(this.createAcc_Click);
            // 
            // userNameBox
            // 
            this.userNameBox.Location = new System.Drawing.Point(147, 196);
            this.userNameBox.Name = "userNameBox";
            this.userNameBox.Size = new System.Drawing.Size(194, 22);
            this.userNameBox.TabIndex = 7;
            // 
            // initialDepoBox
            // 
            this.initialDepoBox.Location = new System.Drawing.Point(147, 294);
            this.initialDepoBox.Name = "initialDepoBox";
            this.initialDepoBox.Size = new System.Drawing.Size(194, 22);
            this.initialDepoBox.TabIndex = 8;
            // 
            // branchComboBox
            // 
            this.branchComboBox.FormattingEnabled = true;
            this.branchComboBox.Location = new System.Drawing.Point(147, 226);
            this.branchComboBox.Name = "branchComboBox";
            this.branchComboBox.Size = new System.Drawing.Size(194, 24);
            this.branchComboBox.TabIndex = 9;
            // 
            // typeComboBox
            // 
            this.typeComboBox.FormattingEnabled = true;
            this.typeComboBox.Location = new System.Drawing.Point(147, 262);
            this.typeComboBox.Name = "typeComboBox";
            this.typeComboBox.Size = new System.Drawing.Size(194, 24);
            this.typeComboBox.TabIndex = 10;
            // 
            // accNumberBox
            // 
            this.accNumberBox.BackColor = System.Drawing.Color.Moccasin;
            this.accNumberBox.Location = new System.Drawing.Point(165, 148);
            this.accNumberBox.Name = "accNumberBox";
            this.accNumberBox.Size = new System.Drawing.Size(100, 22);
            this.accNumberBox.TabIndex = 11;
            // 
            // _accNumber
            // 
            this._accNumber.AutoSize = true;
            this._accNumber.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._accNumber.Location = new System.Drawing.Point(415, 151);
            this._accNumber.Name = "_accNumber";
            this._accNumber.Size = new System.Drawing.Size(139, 19);
            this._accNumber.TabIndex = 12;
            this._accNumber.Text = "Account Number";
            // 
            // _accNoTextBox
            // 
            this._accNoTextBox.Location = new System.Drawing.Point(572, 150);
            this._accNoTextBox.Name = "_accNoTextBox";
            this._accNoTextBox.Size = new System.Drawing.Size(194, 22);
            this._accNoTextBox.TabIndex = 13;
            // 
            // showButton
            // 
            this.showButton.Location = new System.Drawing.Point(497, 202);
            this.showButton.Name = "showButton";
            this.showButton.Size = new System.Drawing.Size(186, 23);
            this.showButton.TabIndex = 14;
            this.showButton.Text = "Show Account Information";
            this.showButton.UseVisualStyleBackColor = true;
            this.showButton.Click += new System.EventHandler(this.showButton_Click);
            // 
            // suspendButton
            // 
            this.suspendButton.Location = new System.Drawing.Point(497, 245);
            this.suspendButton.Name = "suspendButton";
            this.suspendButton.Size = new System.Drawing.Size(186, 23);
            this.suspendButton.TabIndex = 15;
            this.suspendButton.Text = "Suspend Account";
            this.suspendButton.UseVisualStyleBackColor = true;
            this.suspendButton.Click += new System.EventHandler(this.suspendButton_Click);
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("MS Reference Sans Serif", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.Location = new System.Drawing.Point(483, 285);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(212, 23);
            this.titleLabel.TabIndex = 16;
            this.titleLabel.Text = "Account Information";
            // 
            // accNumBox2
            // 
            this.accNumBox2.Location = new System.Drawing.Point(992, 152);
            this.accNumBox2.Name = "accNumBox2";
            this.accNumBox2.Size = new System.Drawing.Size(194, 22);
            this.accNumBox2.TabIndex = 18;
            // 
            // accNum2
            // 
            this.accNum2.AutoSize = true;
            this.accNum2.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.accNum2.Location = new System.Drawing.Point(835, 153);
            this.accNum2.Name = "accNum2";
            this.accNum2.Size = new System.Drawing.Size(139, 19);
            this.accNum2.TabIndex = 17;
            this.accNum2.Text = "Account Number";
            // 
            // amountBox
            // 
            this.amountBox.Location = new System.Drawing.Point(992, 195);
            this.amountBox.Name = "amountBox";
            this.amountBox.Size = new System.Drawing.Size(194, 22);
            this.amountBox.TabIndex = 20;
            // 
            // amount
            // 
            this.amount.AutoSize = true;
            this.amount.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.amount.Location = new System.Drawing.Point(835, 196);
            this.amount.Name = "amount";
            this.amount.Size = new System.Drawing.Size(114, 19);
            this.amount.TabIndex = 19;
            this.amount.Text = "Amount(BDT)";
            // 
            // depositButton
            // 
            this.depositButton.Location = new System.Drawing.Point(953, 306);
            this.depositButton.Name = "depositButton";
            this.depositButton.Size = new System.Drawing.Size(186, 23);
            this.depositButton.TabIndex = 22;
            this.depositButton.Text = "Deposit";
            this.depositButton.UseVisualStyleBackColor = true;
            this.depositButton.Click += new System.EventHandler(this.depositButton_Click);
            // 
            // withdrawButton
            // 
            this.withdrawButton.Location = new System.Drawing.Point(953, 263);
            this.withdrawButton.Name = "withdrawButton";
            this.withdrawButton.Size = new System.Drawing.Size(186, 23);
            this.withdrawButton.TabIndex = 21;
            this.withdrawButton.Text = "Withdraw";
            this.withdrawButton.UseVisualStyleBackColor = true;
            this.withdrawButton.Click += new System.EventHandler(this.withdrawButton_Click);
            // 
            // showBalButton
            // 
            this.showBalButton.Location = new System.Drawing.Point(953, 351);
            this.showBalButton.Name = "showBalButton";
            this.showBalButton.Size = new System.Drawing.Size(186, 23);
            this.showBalButton.TabIndex = 23;
            this.showBalButton.Text = "Show Balance";
            this.showBalButton.UseVisualStyleBackColor = true;
            this.showBalButton.Click += new System.EventHandler(this.showBalButton_Click);
            // 
            // infoListBox
            // 
            this.infoListBox.FormattingEnabled = true;
            this.infoListBox.ItemHeight = 16;
            this.infoListBox.Location = new System.Drawing.Point(487, 338);
            this.infoListBox.Name = "infoListBox";
            this.infoListBox.Size = new System.Drawing.Size(208, 244);
            this.infoListBox.TabIndex = 24;
            // 
            // _bms
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Moccasin;
            this.ClientSize = new System.Drawing.Size(1210, 623);
            this.Controls.Add(this.infoListBox);
            this.Controls.Add(this.showBalButton);
            this.Controls.Add(this.depositButton);
            this.Controls.Add(this.withdrawButton);
            this.Controls.Add(this.amountBox);
            this.Controls.Add(this.amount);
            this.Controls.Add(this.accNumBox2);
            this.Controls.Add(this.accNum2);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.suspendButton);
            this.Controls.Add(this.showButton);
            this.Controls.Add(this._accNoTextBox);
            this.Controls.Add(this._accNumber);
            this.Controls.Add(this.accNumberBox);
            this.Controls.Add(this.typeComboBox);
            this.Controls.Add(this.branchComboBox);
            this.Controls.Add(this.initialDepoBox);
            this.Controls.Add(this.userNameBox);
            this.Controls.Add(this.createAcc);
            this.Controls.Add(this.type);
            this.Controls.Add(this.initialdepo);
            this.Controls.Add(this.branch);
            this.Controls.Add(this.userName);
            this.Controls.Add(this.accNo);
            this.Controls.Add(this.bankName);
            this.Name = "_bms";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Banking Management System";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label bankName;
        private System.Windows.Forms.Label accNo;
        private System.Windows.Forms.Label userName;
        private System.Windows.Forms.Label branch;
        private System.Windows.Forms.Label initialdepo;
        private System.Windows.Forms.Label type;
        private System.Windows.Forms.Button createAcc;
        private System.Windows.Forms.TextBox userNameBox;
        private System.Windows.Forms.TextBox initialDepoBox;
        private System.Windows.Forms.ComboBox branchComboBox;
        private System.Windows.Forms.ComboBox typeComboBox;
        private System.Windows.Forms.TextBox accNumberBox;
        private System.Windows.Forms.Label _accNumber;
        private System.Windows.Forms.TextBox _accNoTextBox;
        private System.Windows.Forms.Button showButton;
        private System.Windows.Forms.Button suspendButton;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.TextBox accNumBox2;
        private System.Windows.Forms.Label accNum2;
        private System.Windows.Forms.TextBox amountBox;
        private System.Windows.Forms.Label amount;
        private System.Windows.Forms.Button depositButton;
        private System.Windows.Forms.Button withdrawButton;
        private System.Windows.Forms.Button showBalButton;
        private System.Windows.Forms.ListBox infoListBox;
    }
}

