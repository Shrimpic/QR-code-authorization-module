
namespace QR_code
{
    partial class AuthorizationForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.loginTextBox = new System.Windows.Forms.TextBox();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.authorizationButton = new System.Windows.Forms.Button();
            this.scanQRcodeButton = new System.Windows.Forms.Button();
            this.qrcodePictureBox = new System.Windows.Forms.PictureBox();
            this.openQRcodeButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panelQRcode = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.qrcodePictureBox)).BeginInit();
            this.panelQRcode.SuspendLayout();
            this.SuspendLayout();
            // 
            // loginTextBox
            // 
            this.loginTextBox.Location = new System.Drawing.Point(99, 167);
            this.loginTextBox.Name = "loginTextBox";
            this.loginTextBox.Size = new System.Drawing.Size(209, 22);
            this.loginTextBox.TabIndex = 0;
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Location = new System.Drawing.Point(99, 202);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.PasswordChar = '*';
            this.passwordTextBox.Size = new System.Drawing.Size(209, 22);
            this.passwordTextBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 170);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Логин";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 205);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Пароль";
            // 
            // authorizationButton
            // 
            this.authorizationButton.Location = new System.Drawing.Point(186, 230);
            this.authorizationButton.Name = "authorizationButton";
            this.authorizationButton.Size = new System.Drawing.Size(122, 35);
            this.authorizationButton.TabIndex = 4;
            this.authorizationButton.Text = "Войти";
            this.authorizationButton.UseVisualStyleBackColor = true;
            this.authorizationButton.Click += new System.EventHandler(this.authorizationButton_Click);
            // 
            // scanQRcodeButton
            // 
            this.scanQRcodeButton.Location = new System.Drawing.Point(451, 353);
            this.scanQRcodeButton.Name = "scanQRcodeButton";
            this.scanQRcodeButton.Size = new System.Drawing.Size(250, 25);
            this.scanQRcodeButton.TabIndex = 6;
            this.scanQRcodeButton.Text = "Сканировать";
            this.scanQRcodeButton.UseVisualStyleBackColor = true;
            this.scanQRcodeButton.Click += new System.EventHandler(this.scanQRcodeButton_Click);
            // 
            // qrcodePictureBox
            // 
            this.qrcodePictureBox.BackColor = System.Drawing.SystemColors.ControlLight;
            this.qrcodePictureBox.Location = new System.Drawing.Point(3, 3);
            this.qrcodePictureBox.Name = "qrcodePictureBox";
            this.qrcodePictureBox.Size = new System.Drawing.Size(250, 250);
            this.qrcodePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.qrcodePictureBox.TabIndex = 7;
            this.qrcodePictureBox.TabStop = false;
            // 
            // openQRcodeButton
            // 
            this.openQRcodeButton.Location = new System.Drawing.Point(451, 385);
            this.openQRcodeButton.Name = "openQRcodeButton";
            this.openQRcodeButton.Size = new System.Drawing.Size(250, 23);
            this.openQRcodeButton.TabIndex = 8;
            this.openQRcodeButton.Text = "Вставить QR-код";
            this.openQRcodeButton.UseVisualStyleBackColor = true;
            this.openQRcodeButton.Click += new System.EventHandler(this.openQRcodeButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(93, 44);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(187, 32);
            this.label3.TabIndex = 9;
            this.label3.Text = "Авторизация";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(347, 190);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 32);
            this.label4.TabIndex = 10;
            this.label4.Text = "Или";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(519, 44);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(112, 32);
            this.label5.TabIndex = 11;
            this.label5.Text = "QR-код";
            // 
            // panelQRcode
            // 
            this.panelQRcode.AllowDrop = true;
            this.panelQRcode.Controls.Add(this.qrcodePictureBox);
            this.panelQRcode.Location = new System.Drawing.Point(449, 89);
            this.panelQRcode.Name = "panelQRcode";
            this.panelQRcode.Size = new System.Drawing.Size(253, 257);
            this.panelQRcode.TabIndex = 12;
            this.panelQRcode.DragDrop += new System.Windows.Forms.DragEventHandler(this.panelQRcode_DragDrop);
            this.panelQRcode.DragEnter += new System.Windows.Forms.DragEventHandler(this.panelQRcode_DragEnter);
            // 
            // AuthorizationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(766, 438);
            this.Controls.Add(this.panelQRcode);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.openQRcodeButton);
            this.Controls.Add(this.scanQRcodeButton);
            this.Controls.Add(this.authorizationButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.passwordTextBox);
            this.Controls.Add(this.loginTextBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "AuthorizationForm";
            this.Text = "Авторизация";
            ((System.ComponentModel.ISupportInitialize)(this.qrcodePictureBox)).EndInit();
            this.panelQRcode.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox loginTextBox;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button authorizationButton;
        private System.Windows.Forms.Button scanQRcodeButton;
        private System.Windows.Forms.PictureBox qrcodePictureBox;
        private System.Windows.Forms.Button openQRcodeButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panelQRcode;
    }
}

