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
            this.btncreateacountLI = new System.Windows.Forms.Button();
            this.lblusernameLI = new System.Windows.Forms.Label();
            this.lblpasswordLI = new System.Windows.Forms.Label();
            this.txtusernameLI = new System.Windows.Forms.TextBox();
            this.txtpasswordLI = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnloginLI
            // 
            this.btnloginLI.Location = new System.Drawing.Point(32, 252);
            this.btnloginLI.Name = "btnloginLI";
            this.btnloginLI.Size = new System.Drawing.Size(84, 23);
            this.btnloginLI.TabIndex = 0;
            this.btnloginLI.Text = "Login";
            this.btnloginLI.UseVisualStyleBackColor = true;
            this.btnloginLI.Click += new System.EventHandler(this.btnloginLI_Click);
            // 
            // btncreateacountLI
            // 
            this.btncreateacountLI.Location = new System.Drawing.Point(134, 252);
            this.btncreateacountLI.Name = "btncreateacountLI";
            this.btncreateacountLI.Size = new System.Drawing.Size(86, 23);
            this.btncreateacountLI.TabIndex = 1;
            this.btncreateacountLI.Text = "Create acount";
            this.btncreateacountLI.UseVisualStyleBackColor = true;
            this.btncreateacountLI.Click += new System.EventHandler(this.lblCA_Click);
            // 
            // lblusernameLI
            // 
            this.lblusernameLI.AutoSize = true;
            this.lblusernameLI.Location = new System.Drawing.Point(12, 34);
            this.lblusernameLI.Name = "lblusernameLI";
            this.lblusernameLI.Size = new System.Drawing.Size(58, 13);
            this.lblusernameLI.TabIndex = 2;
            this.lblusernameLI.Text = "User name";
            this.lblusernameLI.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblpasswordLI
            // 
            this.lblpasswordLI.AutoSize = true;
            this.lblpasswordLI.Location = new System.Drawing.Point(12, 69);
            this.lblpasswordLI.Name = "lblpasswordLI";
            this.lblpasswordLI.Size = new System.Drawing.Size(53, 13);
            this.lblpasswordLI.TabIndex = 3;
            this.lblpasswordLI.Text = "Password";
            this.lblpasswordLI.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtusernameLI
            // 
            this.txtusernameLI.Location = new System.Drawing.Point(101, 27);
            this.txtusernameLI.Name = "txtusernameLI";
            this.txtusernameLI.Size = new System.Drawing.Size(137, 20);
            this.txtusernameLI.TabIndex = 4;
            // 
            // txtpasswordLI
            // 
            this.txtpasswordLI.Location = new System.Drawing.Point(101, 62);
            this.txtpasswordLI.Name = "txtpasswordLI";
            this.txtpasswordLI.Size = new System.Drawing.Size(137, 20);
            this.txtpasswordLI.TabIndex = 5;
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(259, 324);
            this.Controls.Add(this.txtpasswordLI);
            this.Controls.Add(this.txtusernameLI);
            this.Controls.Add(this.lblpasswordLI);
            this.Controls.Add(this.lblusernameLI);
            this.Controls.Add(this.btncreateacountLI);
            this.Controls.Add(this.btnloginLI);
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private System.Windows.Forms.Button btncreateacountLI;
        private System.Windows.Forms.Label lblusernameLI;
        private System.Windows.Forms.Label lblpasswordLI;
        private System.Windows.Forms.TextBox txtusernameLI;
        private System.Windows.Forms.TextBox txtpasswordLI;
    }
}

