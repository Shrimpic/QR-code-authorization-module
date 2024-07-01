
namespace QR_code
{
    partial class UserForm
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
            this.qrcodePictureBox = new System.Windows.Forms.PictureBox();
            this.createQRcodeButton = new System.Windows.Forms.Button();
            this.saveQRcodeButton = new System.Windows.Forms.Button();
            this.userIDtext = new System.Windows.Forms.Label();
            this.exitButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.qrcodePictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // qrcodePictureBox
            // 
            this.qrcodePictureBox.Location = new System.Drawing.Point(25, 97);
            this.qrcodePictureBox.Name = "qrcodePictureBox";
            this.qrcodePictureBox.Size = new System.Drawing.Size(300, 300);
            this.qrcodePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.qrcodePictureBox.TabIndex = 8;
            this.qrcodePictureBox.TabStop = false;
            // 
            // createQRcodeButton
            // 
            this.createQRcodeButton.Location = new System.Drawing.Point(44, 54);
            this.createQRcodeButton.Name = "createQRcodeButton";
            this.createQRcodeButton.Size = new System.Drawing.Size(250, 25);
            this.createQRcodeButton.TabIndex = 9;
            this.createQRcodeButton.Text = "Создать QR-code";
            this.createQRcodeButton.UseVisualStyleBackColor = true;
            this.createQRcodeButton.Click += new System.EventHandler(this.createQRcodeButton_Click);
            // 
            // saveQRcodeButton
            // 
            this.saveQRcodeButton.Location = new System.Drawing.Point(45, 403);
            this.saveQRcodeButton.Name = "saveQRcodeButton";
            this.saveQRcodeButton.Size = new System.Drawing.Size(250, 47);
            this.saveQRcodeButton.TabIndex = 10;
            this.saveQRcodeButton.Text = "Сохранить QR-code";
            this.saveQRcodeButton.UseVisualStyleBackColor = true;
            this.saveQRcodeButton.Visible = false;
            this.saveQRcodeButton.Click += new System.EventHandler(this.saveQRcodeButton_Click);
            // 
            // userIDtext
            // 
            this.userIDtext.AutoSize = true;
            this.userIDtext.Location = new System.Drawing.Point(41, 34);
            this.userIDtext.Name = "userIDtext";
            this.userIDtext.Size = new System.Drawing.Size(264, 17);
            this.userIDtext.TabIndex = 11;
            this.userIDtext.Text = "Не удалось загрузить ID пользователя";
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(259, 465);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(89, 30);
            this.exitButton.TabIndex = 12;
            this.exitButton.Text = "Выйти";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // UserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(349, 498);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.userIDtext);
            this.Controls.Add(this.saveQRcodeButton);
            this.Controls.Add(this.createQRcodeButton);
            this.Controls.Add(this.qrcodePictureBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "UserForm";
            this.Text = "Меню пользователя";
            ((System.ComponentModel.ISupportInitialize)(this.qrcodePictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox qrcodePictureBox;
        private System.Windows.Forms.Button createQRcodeButton;
        private System.Windows.Forms.Button saveQRcodeButton;
        private System.Windows.Forms.Label userIDtext;
        private System.Windows.Forms.Button exitButton;
    }
}