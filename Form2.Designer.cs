namespace Noots
{
    partial class Form2
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
            this.btnLS = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.groupBoxAdd = new System.Windows.Forms.GroupBox();
            this.btnAddFile1 = new System.Windows.Forms.Button();
            this.btnAddText1 = new System.Windows.Forms.Button();
            this.btnAddImage1 = new System.Windows.Forms.Button();
            this.groupBoxText = new System.Windows.Forms.GroupBox();
            this.btnCancelText = new System.Windows.Forms.Button();
            this.btnSaveText = new System.Windows.Forms.Button();
            this.txtInput = new System.Windows.Forms.TextBox();
            this.groupBoxAddImage = new System.Windows.Forms.GroupBox();
            this.pictureBoxImageInput = new System.Windows.Forms.PictureBox();
            this.btnCancelImage = new System.Windows.Forms.Button();
            this.btnSaveImage = new System.Windows.Forms.Button();
            this.groupBoxAdd.SuspendLayout();
            this.groupBoxText.SuspendLayout();
            this.groupBoxAddImage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxImageInput)).BeginInit();
            this.SuspendLayout();
            // 
            // btnLS
            // 
            this.btnLS.Location = new System.Drawing.Point(12, 12);
            this.btnLS.Name = "btnLS";
            this.btnLS.Size = new System.Drawing.Size(71, 23);
            this.btnLS.TabIndex = 0;
            this.btnLS.Text = "Login/Sign up";
            this.btnLS.UseVisualStyleBackColor = true;
            this.btnLS.Click += new System.EventHandler(this.btnLS_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(793, 12);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(57, 32);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.button2_Click);
            // 
            // groupBoxAdd
            // 
            this.groupBoxAdd.Controls.Add(this.btnAddFile1);
            this.groupBoxAdd.Controls.Add(this.btnAddText1);
            this.groupBoxAdd.Controls.Add(this.btnAddImage1);
            this.groupBoxAdd.Location = new System.Drawing.Point(696, 50);
            this.groupBoxAdd.Name = "groupBoxAdd";
            this.groupBoxAdd.Size = new System.Drawing.Size(253, 28);
            this.groupBoxAdd.TabIndex = 3;
            this.groupBoxAdd.TabStop = false;
            // 
            // btnAddFile1
            // 
            this.btnAddFile1.Location = new System.Drawing.Point(182, 0);
            this.btnAddFile1.Name = "btnAddFile1";
            this.btnAddFile1.Size = new System.Drawing.Size(71, 23);
            this.btnAddFile1.TabIndex = 6;
            this.btnAddFile1.Text = "File";
            this.btnAddFile1.UseVisualStyleBackColor = true;
            // 
            // btnAddText1
            // 
            this.btnAddText1.Location = new System.Drawing.Point(0, 0);
            this.btnAddText1.Name = "btnAddText1";
            this.btnAddText1.Size = new System.Drawing.Size(71, 23);
            this.btnAddText1.TabIndex = 5;
            this.btnAddText1.Text = "Text";
            this.btnAddText1.UseVisualStyleBackColor = true;
            this.btnAddText1.Click += new System.EventHandler(this.btnAddText1_Click);
            // 
            // btnAddImage1
            // 
            this.btnAddImage1.Location = new System.Drawing.Point(90, 0);
            this.btnAddImage1.Name = "btnAddImage1";
            this.btnAddImage1.Size = new System.Drawing.Size(71, 23);
            this.btnAddImage1.TabIndex = 4;
            this.btnAddImage1.Text = "Image";
            this.btnAddImage1.UseVisualStyleBackColor = true;
            this.btnAddImage1.Click += new System.EventHandler(this.btnAddImage1_Click);
            // 
            // groupBoxText
            // 
            this.groupBoxText.Controls.Add(this.btnCancelText);
            this.groupBoxText.Controls.Add(this.btnSaveText);
            this.groupBoxText.Controls.Add(this.txtInput);
            this.groupBoxText.Location = new System.Drawing.Point(393, 50);
            this.groupBoxText.Name = "groupBoxText";
            this.groupBoxText.Size = new System.Drawing.Size(860, 405);
            this.groupBoxText.TabIndex = 4;
            this.groupBoxText.TabStop = false;
            this.groupBoxText.Enter += new System.EventHandler(this.groupBoxText_Enter);
            // 
            // btnCancelText
            // 
            this.btnCancelText.Location = new System.Drawing.Point(24, 340);
            this.btnCancelText.Name = "btnCancelText";
            this.btnCancelText.Size = new System.Drawing.Size(71, 23);
            this.btnCancelText.TabIndex = 7;
            this.btnCancelText.Text = "Cancell";
            this.btnCancelText.UseVisualStyleBackColor = true;
            this.btnCancelText.Click += new System.EventHandler(this.btnCancelText_Click);
            // 
            // btnSaveText
            // 
            this.btnSaveText.Location = new System.Drawing.Point(783, 340);
            this.btnSaveText.Name = "btnSaveText";
            this.btnSaveText.Size = new System.Drawing.Size(71, 23);
            this.btnSaveText.TabIndex = 6;
            this.btnSaveText.Text = "Save";
            this.btnSaveText.UseVisualStyleBackColor = true;
            this.btnSaveText.Click += new System.EventHandler(this.btnSaveText_Click);
            // 
            // txtInput
            // 
            this.txtInput.Location = new System.Drawing.Point(6, 19);
            this.txtInput.Multiline = true;
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(848, 315);
            this.txtInput.TabIndex = 0;
            this.txtInput.TextChanged += new System.EventHandler(this.txtInput_TextChanged);
            // 
            // groupBoxAddImage
            // 
            this.groupBoxAddImage.Controls.Add(this.pictureBoxImageInput);
            this.groupBoxAddImage.Controls.Add(this.btnCancelImage);
            this.groupBoxAddImage.Controls.Add(this.btnSaveImage);
            this.groupBoxAddImage.Location = new System.Drawing.Point(393, 50);
            this.groupBoxAddImage.Name = "groupBoxAddImage";
            this.groupBoxAddImage.Size = new System.Drawing.Size(860, 405);
            this.groupBoxAddImage.TabIndex = 5;
            this.groupBoxAddImage.TabStop = false;
            // 
            // pictureBoxImageInput
            // 
            this.pictureBoxImageInput.Location = new System.Drawing.Point(6, 19);
            this.pictureBoxImageInput.Name = "pictureBoxImageInput";
            this.pictureBoxImageInput.Size = new System.Drawing.Size(848, 315);
            this.pictureBoxImageInput.TabIndex = 8;
            this.pictureBoxImageInput.TabStop = false;
            // 
            // btnCancelImage
            // 
            this.btnCancelImage.Location = new System.Drawing.Point(6, 340);
            this.btnCancelImage.Name = "btnCancelImage";
            this.btnCancelImage.Size = new System.Drawing.Size(71, 23);
            this.btnCancelImage.TabIndex = 7;
            this.btnCancelImage.Text = "Cancel";
            this.btnCancelImage.UseVisualStyleBackColor = true;
            this.btnCancelImage.Click += new System.EventHandler(this.btnCancelImage_Click);
            // 
            // btnSaveImage
            // 
            this.btnSaveImage.Location = new System.Drawing.Point(783, 340);
            this.btnSaveImage.Name = "btnSaveImage";
            this.btnSaveImage.Size = new System.Drawing.Size(71, 23);
            this.btnSaveImage.TabIndex = 6;
            this.btnSaveImage.Text = "Save";
            this.btnSaveImage.UseVisualStyleBackColor = true;
            this.btnSaveImage.Click += new System.EventHandler(this.btnSaveImage_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1256, 944);
            this.Controls.Add(this.groupBoxAddImage);
            this.Controls.Add(this.groupBoxText);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.groupBoxAdd);
            this.Controls.Add(this.btnLS);
            this.Name = "Form2";
            this.Text = "Form2";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form2_Load);
            this.groupBoxAdd.ResumeLayout(false);
            this.groupBoxText.ResumeLayout(false);
            this.groupBoxText.PerformLayout();
            this.groupBoxAddImage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxImageInput)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnLS;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.GroupBox groupBoxAdd;
        private System.Windows.Forms.Button btnAddImage1;
        private System.Windows.Forms.Button btnAddFile1;
        private System.Windows.Forms.Button btnAddText1;
        private System.Windows.Forms.GroupBox groupBoxText;
        private System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.Button btnCancelText;
        private System.Windows.Forms.Button btnSaveText;
        private System.Windows.Forms.GroupBox groupBoxAddImage;
        private System.Windows.Forms.PictureBox pictureBoxImageInput;
        private System.Windows.Forms.Button btnCancelImage;
        private System.Windows.Forms.Button btnSaveImage;
    }
}