using System;

namespace Noots
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
            this.btnloginLI = new System.Windows.Forms.Button();
            this.lblusernameLI = new System.Windows.Forms.Label();
            this.lblpasswordLI = new System.Windows.Forms.Label();
            this.txtusernameLI = new System.Windows.Forms.TextBox();
            this.txtpasswordLI = new System.Windows.Forms.TextBox();
            this.panelSignIn = new System.Windows.Forms.Panel();
            this.btncreateacountLI = new System.Windows.Forms.Button();
            this.lblSignInLI = new System.Windows.Forms.Label();
            this.panelSignUp = new System.Windows.Forms.Panel();
            this.dateTimePickerBirthDate = new System.Windows.Forms.DateTimePicker();
            this.listBoxErrors = new System.Windows.Forms.ListBox();
            this.lblDateOfBirth = new System.Windows.Forms.Label();
            this.txtPasswordUp = new System.Windows.Forms.TextBox();
            this.txtEmailUp1 = new System.Windows.Forms.TextBox();
            this.txtUserNameUp = new System.Windows.Forms.TextBox();
            this.txtFirstNameUp = new System.Windows.Forms.TextBox();
            this.txtLastNameUp = new System.Windows.Forms.TextBox();
            this.lblUserNameUp = new System.Windows.Forms.Label();
            this.lblPasswordUp = new System.Windows.Forms.Label();
            this.lblEmailUp = new System.Windows.Forms.Label();
            this.lblFirstNameUp = new System.Windows.Forms.Label();
            this.lblLastNameUp = new System.Windows.Forms.Label();
            this.lblSignUpUp = new System.Windows.Forms.Label();
            this.btnBackToSignInUp = new System.Windows.Forms.Button();
            this.btnCreatAcountUp = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblUserNameValidUp = new System.Windows.Forms.Label();
            this.panelSignIn.SuspendLayout();
            this.panelSignUp.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnloginLI
            // 
            this.btnloginLI.Location = new System.Drawing.Point(10, 425);
            this.btnloginLI.Name = "btnloginLI";
            this.btnloginLI.Size = new System.Drawing.Size(84, 23);
            this.btnloginLI.TabIndex = 0;
            this.btnloginLI.Text = "Login";
            this.btnloginLI.UseVisualStyleBackColor = true;
            this.btnloginLI.Click += new System.EventHandler(this.btnloginLI_Click);
            // 
            // lblusernameLI
            // 
            this.lblusernameLI.AutoSize = true;
            this.lblusernameLI.Location = new System.Drawing.Point(7, 40);
            this.lblusernameLI.Name = "lblusernameLI";
            this.lblusernameLI.Size = new System.Drawing.Size(73, 16);
            this.lblusernameLI.TabIndex = 2;
            this.lblusernameLI.Text = "User name";
            this.lblusernameLI.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblpasswordLI
            // 
            this.lblpasswordLI.AutoSize = true;
            this.lblpasswordLI.Location = new System.Drawing.Point(7, 74);
            this.lblpasswordLI.Name = "lblpasswordLI";
            this.lblpasswordLI.Size = new System.Drawing.Size(67, 16);
            this.lblpasswordLI.TabIndex = 3;
            this.lblpasswordLI.Text = "Password";
            this.lblpasswordLI.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtusernameLI
            // 
            this.txtusernameLI.Location = new System.Drawing.Point(190, 37);
            this.txtusernameLI.Name = "txtusernameLI";
            this.txtusernameLI.Size = new System.Drawing.Size(175, 22);
            this.txtusernameLI.TabIndex = 4;
            // 
            // txtpasswordLI
            // 
            this.txtpasswordLI.Location = new System.Drawing.Point(190, 71);
            this.txtpasswordLI.Name = "txtpasswordLI";
            this.txtpasswordLI.Size = new System.Drawing.Size(175, 22);
            this.txtpasswordLI.TabIndex = 5;
            // 
            // panelSignIn
            // 
            this.panelSignIn.Controls.Add(this.btncreateacountLI);
            this.panelSignIn.Controls.Add(this.lblSignInLI);
            this.panelSignIn.Controls.Add(this.txtusernameLI);
            this.panelSignIn.Controls.Add(this.btnloginLI);
            this.panelSignIn.Controls.Add(this.txtpasswordLI);
            this.panelSignIn.Controls.Add(this.lblusernameLI);
            this.panelSignIn.Controls.Add(this.lblpasswordLI);
            this.panelSignIn.Location = new System.Drawing.Point(1, 1);
            this.panelSignIn.Name = "panelSignIn";
            this.panelSignIn.Size = new System.Drawing.Size(373, 457);
            this.panelSignIn.TabIndex = 6;
            this.panelSignIn.Paint += new System.Windows.Forms.PaintEventHandler(this.panelSignIn_Paint);
            // 
            // btncreateacountLI
            // 
            this.btncreateacountLI.Location = new System.Drawing.Point(280, 425);
            this.btncreateacountLI.Name = "btncreateacountLI";
            this.btncreateacountLI.Size = new System.Drawing.Size(85, 23);
            this.btncreateacountLI.TabIndex = 12;
            this.btncreateacountLI.Text = "Create acount";
            this.btncreateacountLI.UseVisualStyleBackColor = true;
            this.btncreateacountLI.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblSignInLI
            // 
            this.lblSignInLI.AutoSize = true;
            this.lblSignInLI.Location = new System.Drawing.Point(155, 7);
            this.lblSignInLI.Name = "lblSignInLI";
            this.lblSignInLI.Size = new System.Drawing.Size(47, 16);
            this.lblSignInLI.TabIndex = 10;
            this.lblSignInLI.Text = "Sign in";
            // 
            // panelSignUp
            // 
            this.panelSignUp.Controls.Add(this.lblUserNameValidUp);
            this.panelSignUp.Controls.Add(this.label1);
            this.panelSignUp.Controls.Add(this.dateTimePickerBirthDate);
            this.panelSignUp.Controls.Add(this.listBoxErrors);
            this.panelSignUp.Controls.Add(this.lblDateOfBirth);
            this.panelSignUp.Controls.Add(this.txtPasswordUp);
            this.panelSignUp.Controls.Add(this.txtEmailUp1);
            this.panelSignUp.Controls.Add(this.txtUserNameUp);
            this.panelSignUp.Controls.Add(this.txtFirstNameUp);
            this.panelSignUp.Controls.Add(this.txtLastNameUp);
            this.panelSignUp.Controls.Add(this.lblUserNameUp);
            this.panelSignUp.Controls.Add(this.lblPasswordUp);
            this.panelSignUp.Controls.Add(this.lblEmailUp);
            this.panelSignUp.Controls.Add(this.lblFirstNameUp);
            this.panelSignUp.Controls.Add(this.lblLastNameUp);
            this.panelSignUp.Controls.Add(this.lblSignUpUp);
            this.panelSignUp.Controls.Add(this.btnBackToSignInUp);
            this.panelSignUp.Controls.Add(this.btnCreatAcountUp);
            this.panelSignUp.Location = new System.Drawing.Point(1, 1);
            this.panelSignUp.Name = "panelSignUp";
            this.panelSignUp.Size = new System.Drawing.Size(373, 473);
            this.panelSignUp.TabIndex = 0;
            this.panelSignUp.Paint += new System.Windows.Forms.PaintEventHandler(this.panelSignUp_Paint);
            // 
            // dateTimePickerBirthDate
            // 
            this.dateTimePickerBirthDate.Location = new System.Drawing.Point(187, 285);
            this.dateTimePickerBirthDate.Name = "dateTimePickerBirthDate";
            this.dateTimePickerBirthDate.Size = new System.Drawing.Size(176, 22);
            this.dateTimePickerBirthDate.TabIndex = 26;
            // 
            // listBoxErrors
            // 
            this.listBoxErrors.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxErrors.FormattingEnabled = true;
            this.listBoxErrors.Location = new System.Drawing.Point(9, 313);
            this.listBoxErrors.Name = "listBoxErrors";
            this.listBoxErrors.Size = new System.Drawing.Size(354, 95);
            this.listBoxErrors.TabIndex = 25;
            // 
            // lblDateOfBirth
            // 
            this.lblDateOfBirth.AutoSize = true;
            this.lblDateOfBirth.Location = new System.Drawing.Point(14, 285);
            this.lblDateOfBirth.Name = "lblDateOfBirth";
            this.lblDateOfBirth.Size = new System.Drawing.Size(78, 16);
            this.lblDateOfBirth.TabIndex = 24;
            this.lblDateOfBirth.Text = "Date of birth";
            // 
            // txtPasswordUp
            // 
            this.txtPasswordUp.Location = new System.Drawing.Point(187, 189);
            this.txtPasswordUp.Name = "txtPasswordUp";
            this.txtPasswordUp.Size = new System.Drawing.Size(176, 22);
            this.txtPasswordUp.TabIndex = 20;
            // 
            // txtEmailUp1
            // 
            this.txtEmailUp1.Location = new System.Drawing.Point(187, 242);
            this.txtEmailUp1.Name = "txtEmailUp1";
            this.txtEmailUp1.Size = new System.Drawing.Size(177, 22);
            this.txtEmailUp1.TabIndex = 21;
            // 
            // txtUserNameUp
            // 
            this.txtUserNameUp.Location = new System.Drawing.Point(187, 140);
            this.txtUserNameUp.Name = "txtUserNameUp";
            this.txtUserNameUp.Size = new System.Drawing.Size(177, 22);
            this.txtUserNameUp.TabIndex = 19;
            // 
            // txtFirstNameUp
            // 
            this.txtFirstNameUp.Location = new System.Drawing.Point(187, 40);
            this.txtFirstNameUp.Name = "txtFirstNameUp";
            this.txtFirstNameUp.Size = new System.Drawing.Size(177, 22);
            this.txtFirstNameUp.TabIndex = 17;
            // 
            // txtLastNameUp
            // 
            this.txtLastNameUp.Location = new System.Drawing.Point(187, 92);
            this.txtLastNameUp.Name = "txtLastNameUp";
            this.txtLastNameUp.Size = new System.Drawing.Size(177, 22);
            this.txtLastNameUp.TabIndex = 18;
            // 
            // lblUserNameUp
            // 
            this.lblUserNameUp.AutoSize = true;
            this.lblUserNameUp.Location = new System.Drawing.Point(14, 143);
            this.lblUserNameUp.Name = "lblUserNameUp";
            this.lblUserNameUp.Size = new System.Drawing.Size(70, 16);
            this.lblUserNameUp.TabIndex = 16;
            this.lblUserNameUp.Text = "Username";
            // 
            // lblPasswordUp
            // 
            this.lblPasswordUp.AutoSize = true;
            this.lblPasswordUp.Location = new System.Drawing.Point(14, 195);
            this.lblPasswordUp.Name = "lblPasswordUp";
            this.lblPasswordUp.Size = new System.Drawing.Size(67, 16);
            this.lblPasswordUp.TabIndex = 15;
            this.lblPasswordUp.Text = "Password";
            // 
            // lblEmailUp
            // 
            this.lblEmailUp.AutoSize = true;
            this.lblEmailUp.Location = new System.Drawing.Point(14, 248);
            this.lblEmailUp.Name = "lblEmailUp";
            this.lblEmailUp.Size = new System.Drawing.Size(41, 16);
            this.lblEmailUp.TabIndex = 14;
            this.lblEmailUp.Text = "Email";
            // 
            // lblFirstNameUp
            // 
            this.lblFirstNameUp.AutoSize = true;
            this.lblFirstNameUp.Location = new System.Drawing.Point(14, 43);
            this.lblFirstNameUp.Name = "lblFirstNameUp";
            this.lblFirstNameUp.Size = new System.Drawing.Size(72, 16);
            this.lblFirstNameUp.TabIndex = 11;
            this.lblFirstNameUp.Text = "First name ";
            // 
            // lblLastNameUp
            // 
            this.lblLastNameUp.AutoSize = true;
            this.lblLastNameUp.Location = new System.Drawing.Point(14, 98);
            this.lblLastNameUp.Name = "lblLastNameUp";
            this.lblLastNameUp.Size = new System.Drawing.Size(69, 16);
            this.lblLastNameUp.TabIndex = 10;
            this.lblLastNameUp.Text = "Last name";
            // 
            // lblSignUpUp
            // 
            this.lblSignUpUp.AutoSize = true;
            this.lblSignUpUp.Location = new System.Drawing.Point(149, 8);
            this.lblSignUpUp.Name = "lblSignUpUp";
            this.lblSignUpUp.Size = new System.Drawing.Size(52, 16);
            this.lblSignUpUp.TabIndex = 9;
            this.lblSignUpUp.Text = "Sign up";
            // 
            // btnBackToSignInUp
            // 
            this.btnBackToSignInUp.Location = new System.Drawing.Point(10, 418);
            this.btnBackToSignInUp.Name = "btnBackToSignInUp";
            this.btnBackToSignInUp.Size = new System.Drawing.Size(109, 23);
            this.btnBackToSignInUp.TabIndex = 7;
            this.btnBackToSignInUp.Text = "Back to sign in";
            this.btnBackToSignInUp.UseVisualStyleBackColor = true;
            this.btnBackToSignInUp.Click += new System.EventHandler(this.btnBackToSignInUp_Click);
            // 
            // btnCreatAcountUp
            // 
            this.btnCreatAcountUp.Location = new System.Drawing.Point(260, 419);
            this.btnCreatAcountUp.Name = "btnCreatAcountUp";
            this.btnCreatAcountUp.Size = new System.Drawing.Size(103, 23);
            this.btnCreatAcountUp.TabIndex = 8;
            this.btnCreatAcountUp.Text = "Create acount";
            this.btnCreatAcountUp.UseVisualStyleBackColor = true;
            this.btnCreatAcountUp.Click += new System.EventHandler(this.btnCreatAcountUp_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(17, 211);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(184, 26);
            this.label1.TabIndex = 27;
            this.label1.Text = "8–20 characters: \r\n(uppercase, lowercase, and numbers)";
            // 
            // lblUserNameValidUp
            // 
            this.lblUserNameValidUp.AutoSize = true;
            this.lblUserNameValidUp.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserNameValidUp.Location = new System.Drawing.Point(17, 159);
            this.lblUserNameValidUp.Name = "lblUserNameValidUp";
            this.lblUserNameValidUp.Size = new System.Drawing.Size(117, 26);
            this.lblUserNameValidUp.TabIndex = 28;
            this.lblUserNameValidUp.Text = "5–20 characters: \r\n(letters, numbers, ., _, -)";
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(372, 454);
            this.Controls.Add(this.panelSignUp);
            this.Controls.Add(this.panelSignIn);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panelSignIn.ResumeLayout(false);
            this.panelSignIn.PerformLayout();
            this.panelSignUp.ResumeLayout(false);
            this.panelSignUp.PerformLayout();
            this.ResumeLayout(false);

        }



        private void label2_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.TextBox txtUsernameIn;
        private System.Windows.Forms.Button btnCreatacount;
        private System.Windows.Forms.Label lblSignin;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox txtPasswordIn;
        private System.Windows.Forms.Button btnloginLI;
        private System.Windows.Forms.Label lblusernameLI;
        private System.Windows.Forms.Label lblpasswordLI;
        private System.Windows.Forms.TextBox txtusernameLI;
        private System.Windows.Forms.TextBox txtpasswordLI;
        private System.Windows.Forms.Panel panelSignIn;
        private System.Windows.Forms.Panel panelSignUp;
        private System.Windows.Forms.Button btnCreatAcountUp;
        private System.Windows.Forms.Button btnBackToSignInUp;
        private System.Windows.Forms.Label lblSignUpUp;
        private System.Windows.Forms.Label lblUserNameUp;
        private System.Windows.Forms.Label lblPasswordUp;
        private System.Windows.Forms.Label lblEmailUp;
        private System.Windows.Forms.Label lblFirstNameUp;
        private System.Windows.Forms.Label lblLastNameUp;
        private System.Windows.Forms.TextBox txtPasswordUp;
        private System.Windows.Forms.TextBox txtEmailUp1;
        private System.Windows.Forms.TextBox txtUserNameUp;
        private System.Windows.Forms.TextBox txtFirstNameUp;
        private System.Windows.Forms.TextBox txtLastNameUp;
        private System.Windows.Forms.Label lblSignInLI;
        private System.Windows.Forms.Button btncreateacountLI;
        private System.Windows.Forms.Label lblDateOfBirth;
        private System.Windows.Forms.ListBox listBoxErrors;
        private System.Windows.Forms.DateTimePicker dateTimePickerBirthDate;
        private System.Windows.Forms.Label lblUserNameValidUp;
        private System.Windows.Forms.Label label1;
    }
}

