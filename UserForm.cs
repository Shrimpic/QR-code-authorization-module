using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Drawing.Imaging;
using MessagingToolkit.QRCode.Codec;
using MessagingToolkit.QRCode.Codec.Data;
using System.IO;

namespace QR_code
{
    public partial class UserForm : Form
    {
        string sqlCon;
        int dbID_account;
        public UserForm(string sqlCon, int dbID_account)
        {
            InitializeComponent();
            this.sqlCon = sqlCon;
            this.dbID_account = dbID_account;
            userIDtext.Text = $"ID пользователя: {dbID_account}";
        }

        // Создание QR-кода
        private void createQRcodeButton_Click(object sender, EventArgs e)
        {
            string keyCode = GetKey();
            SqlConnection con = new SqlConnection(sqlCon);
            con.Open();

            // Генерация ключа авторизации и QR-кода на его основе
            QRCodeEncoder encoder = new QRCodeEncoder();
            encoder.QRCodeForegroundColor = Color.DodgerBlue;
            Bitmap qrcode = encoder.Encode(keyCode);
            qrcodePictureBox.Image = qrcode as Image;

            // Удаление старых QR-кодов при их наличии
            SqlCommand comDelete = new SqlCommand($"Delete from QRcodes where id_account = '{dbID_account}'", con);
            SqlDataReader drDelete = comDelete.ExecuteReader();
            drDelete.Read();
            drDelete.Close();

            // Заносим данные о созданном QR-коде (дата создания, привязанный аккаунт и ключ авторизации)
            SqlCommand createTime = new SqlCommand("Select GETDATE()", con);
            SqlDataReader drTime = createTime.ExecuteReader();
            drTime.Read();
            SqlCommand cmd = new SqlCommand("Insert into QRcodes values(@authorizationKey, @createDate, @id_account)", con);
            cmd.Parameters.AddWithValue("@createDate", drTime.GetDateTime(0));
            drTime.Close();
            cmd.Parameters.AddWithValue("@authorizationKey", keyCode);
            cmd.Parameters.AddWithValue("@id_account", dbID_account);
            cmd.ExecuteNonQuery();
            con.Close();
            saveQRcodeButton.Visible = true;
        }

        // Алгоритм создания ключа авторизации для QR-кода
        public string GetKey(int x = 64)
        {
            string key = "";
            var r = new Random();
            while (key.Length < x)
            {
                Char c = (char)r.Next(33, 125);
                if (Char.IsLetterOrDigit(c))
                    key += c;
            }
            return key;
        }

        // Сохранение QR-кода
        private void saveQRcodeButton_Click(object sender, EventArgs e)
        {
            try
            {
                SaveFileDialog save = new SaveFileDialog();
                save.Filter = "PNG|*.png|JPEG|*.jpg|GIF|*.gif|BMP|*.bmp";
                if (save.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    qrcodePictureBox.Image.Save(save.FileName);
                }
            }
            catch
            {
                MessageBox.Show("Не получилось сохранить QR-код");
            } 
        }

        // Кнопка выхода из аккаунта
        private void exitButton_Click(object sender, EventArgs e)
        {
            AuthorizationForm newForm = new AuthorizationForm();
            this.Hide();
            newForm.ShowDialog();
            this.Close();
        }
    }
}
