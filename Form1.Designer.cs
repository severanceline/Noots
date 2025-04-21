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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btncreateacountLI = new System.Windows.Forms.Button();
            this.lblSignInLI = new System.Windows.Forms.Label();
            this.panelSignUp = new System.Windows.Forms.Panel();
            this.lblDateOfBirth = new System.Windows.Forms.Label();
            this.txtDateOfBirthUp = new System.Windows.Forms.TextBox();
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
            this.panelSignIn.SuspendLayout();
            this.panelSignUp.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnloginLI
            // 
            this.btnloginLI.Location = new System.Drawing.Point(38, 265);
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
            this.lblusernameLI.Location = new System.Drawing.Point(35, 40);
            this.lblusernameLI.Name = "lblusernameLI";
            this.lblusernameLI.Size = new System.Drawing.Size(58, 13);
            this.lblusernameLI.TabIndex = 2;
            this.lblusernameLI.Text = "User name";
            this.lblusernameLI.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblpasswordLI
            // 
            this.lblpasswordLI.AutoSize = true;
            this.lblpasswordLI.Location = new System.Drawing.Point(35, 77);
            this.lblpasswordLI.Name = "lblpasswordLI";
            this.lblpasswordLI.Size = new System.Drawing.Size(53, 13);
            this.lblpasswordLI.TabIndex = 3;
            this.lblpasswordLI.Text = "Password";
            this.lblpasswordLI.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtusernameLI
            // 
            this.txtusernameLI.Location = new System.Drawing.Point(106, 37);
            this.txtusernameLI.Name = "txtusernameLI";
            this.txtusernameLI.Size = new System.Drawing.Size(137, 20);
            this.txtusernameLI.TabIndex = 4;
            // 
            // txtpasswordLI
            // 
            this.txtpasswordLI.Location = new System.Drawing.Point(106, 70);
            this.txtpasswordLI.Name = "txtpasswordLI";
            this.txtpasswordLI.Size = new System.Drawing.Size(137, 20);
            this.txtpasswordLI.TabIndex = 5;
            // 
            // panelSignIn
            // 
            this.panelSignIn.Controls.Add(this.textBox1);
            this.panelSignIn.Controls.Add(this.btncreateacountLI);
            this.panelSignIn.Controls.Add(this.lblSignInLI);
            this.panelSignIn.Controls.Add(this.txtusernameLI);
            this.panelSignIn.Controls.Add(this.btnloginLI);
            this.panelSignIn.Controls.Add(this.txtpasswordLI);
            this.panelSignIn.Controls.Add(this.lblusernameLI);
            this.panelSignIn.Controls.Add(this.lblpasswordLI);
            this.panelSignIn.Location = new System.Drawing.Point(3, 3);
            this.panelSignIn.Name = "panelSignIn";
            this.panelSignIn.Size = new System.Drawing.Size(281, 336);
            this.panelSignIn.TabIndex = 6;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(-54, -19);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(137, 20);
            this.textBox1.TabIndex = 23;
            // 
            // btncreateacountLI
            // 
            this.btncreateacountLI.Location = new System.Drawing.Point(158, 265);
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
            this.lblSignInLI.Location = new System.Drawing.Point(116, 8);
            this.lblSignInLI.Name = "lblSignInLI";
            this.lblSignInLI.Size = new System.Drawing.Size(39, 13);
            this.lblSignInLI.TabIndex = 10;
            this.lblSignInLI.Text = "Sign in";
            // 
            // panelSignUp
            // 
            this.panelSignUp.Controls.Add(this.lblDateOfBirth);
            this.panelSignUp.Controls.Add(this.txtDateOfBirthUp);
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
            this.panelSignUp.Location = new System.Drawing.Point(3, 3);
            this.panelSignUp.Name = "panelSignUp";
            this.panelSignUp.Size = new System.Drawing.Size(281, 336);
            this.panelSignUp.TabIndex = 0;
            this.panelSignUp.Paint += new System.Windows.Forms.PaintEventHandler(this.panelSignUp_Paint);
            // 
            // lblDateOfBirth
            // 
            this.lblDateOfBirth.AutoSize = true;
            this.lblDateOfBirth.Location = new System.Drawing.Point(38, 200);
            this.lblDateOfBirth.Name = "lblDateOfBirth";
            this.lblDateOfBirth.Size = new System.Drawing.Size(65, 13);
            this.lblDateOfBirth.TabIndex = 24;
            this.lblDateOfBirth.Text = "Date of birth";
            // 
            // txtDateOfBirthUp
            // 
            this.txtDateOfBirthUp.Location = new System.Drawing.Point(112, 193);
            this.txtDateOfBirthUp.Name = "txtDateOfBirthUp";
            this.txtDateOfBirthUp.Size = new System.Drawing.Size(137, 20);
            this.txtDateOfBirthUp.TabIndex = 23;
            // 
            // txtPasswordUp
            // 
            this.txtPasswordUp.Location = new System.Drawing.Point(113, 132);
            this.txtPasswordUp.Name = "txtPasswordUp";
            this.txtPasswordUp.Size = new System.Drawing.Size(137, 20);
            this.txtPasswordUp.TabIndex = 20;
            // 
            // txtEmailUp1
            // 
            this.txtEmailUp1.Location = new System.Drawing.Point(113, 162);
            this.txtEmailUp1.Name = "txtEmailUp1";
            this.txtEmailUp1.Size = new System.Drawing.Size(137, 20);
            this.txtEmailUp1.TabIndex = 21;
            // 
            // txtUserNameUp
            // 
            this.txtUserNameUp.Location = new System.Drawing.Point(113, 102);
            this.txtUserNameUp.Name = "txtUserNameUp";
            this.txtUserNameUp.Size = new System.Drawing.Size(137, 20);
            this.txtUserNameUp.TabIndex = 19;
            // 
            // txtFirstNameUp
            // 
            this.txtFirstNameUp.Location = new System.Drawing.Point(112, 37);
            this.txtFirstNameUp.Name = "txtFirstNameUp";
            this.txtFirstNameUp.Size = new System.Drawing.Size(137, 20);
            this.txtFirstNameUp.TabIndex = 17;
            // 
            // txtLastNameUp
            // 
            this.txtLastNameUp.Location = new System.Drawing.Point(112, 70);
            this.txtLastNameUp.Name = "txtLastNameUp";
            this.txtLastNameUp.Size = new System.Drawing.Size(137, 20);
            this.txtLastNameUp.TabIndex = 18;
            // 
            // lblUserNameUp
            // 
            this.lblUserNameUp.AutoSize = true;
            this.lblUserNameUp.Location = new System.Drawing.Point(35, 100);
            this.lblUserNameUp.Name = "lblUserNameUp";
            this.lblUserNameUp.Size = new System.Drawing.Size(55, 13);
            this.lblUserNameUp.TabIndex = 16;
            this.lblUserNameUp.Text = "Username";
            // 
            // lblPasswordUp
            // 
            this.lblPasswordUp.AutoSize = true;
            this.lblPasswordUp.Location = new System.Drawing.Point(37, 131);
            this.lblPasswordUp.Name = "lblPasswordUp";
            this.lblPasswordUp.Size = new System.Drawing.Size(53, 13);
            this.lblPasswordUp.TabIndex = 15;
            this.lblPasswordUp.Text = "Password";
            // 
            // lblEmailUp
            // 
            this.lblEmailUp.AutoSize = true;
            this.lblEmailUp.Location = new System.Drawing.Point(38, 165);
            this.lblEmailUp.Name = "lblEmailUp";
            this.lblEmailUp.Size = new System.Drawing.Size(32, 13);
            this.lblEmailUp.TabIndex = 14;
            this.lblEmailUp.Text = "Email";
            // 
            // lblFirstNameUp
            // 
            this.lblFirstNameUp.AutoSize = true;
            this.lblFirstNameUp.Location = new System.Drawing.Point(36, 37);
            this.lblFirstNameUp.Name = "lblFirstNameUp";
            this.lblFirstNameUp.Size = new System.Drawing.Size(55, 13);
            this.lblFirstNameUp.TabIndex = 11;
            this.lblFirstNameUp.Text = "First name";
            // 
            // lblLastNameUp
            // 
            this.lblLastNameUp.AutoSize = true;
            this.lblLastNameUp.Location = new System.Drawing.Point(37, 74);
            this.lblLastNameUp.Name = "lblLastNameUp";
            this.lblLastNameUp.Size = new System.Drawing.Size(56, 13);
            this.lblLastNameUp.TabIndex = 10;
            this.lblLastNameUp.Text = "Last name";
            // 
            // lblSignUpUp
            // 
            this.lblSignUpUp.AutoSize = true;
            this.lblSignUpUp.Location = new System.Drawing.Point(116, 9);
            this.lblSignUpUp.Name = "lblSignUpUp";
            this.lblSignUpUp.Size = new System.Drawing.Size(43, 13);
            this.lblSignUpUp.TabIndex = 9;
            this.lblSignUpUp.Text = "Sign up";
            // 
            // btnBackToSignInUp
            // 
            this.btnBackToSignInUp.Location = new System.Drawing.Point(38, 273);
            this.btnBackToSignInUp.Name = "btnBackToSignInUp";
            this.btnBackToSignInUp.Size = new System.Drawing.Size(86, 23);
            this.btnBackToSignInUp.TabIndex = 7;
            this.btnBackToSignInUp.Text = "Back to sign in";
            this.btnBackToSignInUp.UseVisualStyleBackColor = true;
            this.btnBackToSignInUp.Click += new System.EventHandler(this.btnBackToSignInUp_Click);
            // 
            // btnCreatAcountUp
            // 
            this.btnCreatAcountUp.Location = new System.Drawing.Point(167, 273);
            this.btnCreatAcountUp.Name = "btnCreatAcountUp";
            this.btnCreatAcountUp.Size = new System.Drawing.Size(83, 23);
            this.btnCreatAcountUp.TabIndex = 8;
            this.btnCreatAcountUp.Text = "Create acount";
            this.btnCreatAcountUp.UseVisualStyleBackColor = true;
            this.btnCreatAcountUp.Click += new System.EventHandler(this.btnCreatAcountUp_Click_1);
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(281, 336);
            this.Controls.Add(this.panelSignUp);
            this.Controls.Add(this.panelSignIn);
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
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblDateOfBirth;
        private System.Windows.Forms.TextBox txtDateOfBirthUp;
    }
}

