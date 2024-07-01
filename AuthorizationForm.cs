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
using MessagingToolkit.QRCode.Codec;
using MessagingToolkit.QRCode.Codec.Data;

namespace QR_code
{
    public partial class AuthorizationForm : Form
    {
        string sqlCon = @"Data Source = (local); Initial Catalog = QR-code; Integrated Security = True";
        public AuthorizationForm()
        {
            InitializeComponent();
        }

        // Авторизация по логину и паролю
        private void authorizationButton_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(sqlCon);
            con.Open();

            // Проверка данных об аккаунте в базе данных, и последующей авторизацией
            // При неправильном вводе данных выводиться ошибка
            if (loginTextBox.Text == "" || passwordTextBox.Text == "") MessageBox.Show("Неправильный логин или пароль");
            else
            {
                SqlCommand comUser = new SqlCommand($"Select login, password, id_account from Accounts where login = '{loginTextBox.Text}'", con);
                SqlDataReader drUser = comUser.ExecuteReader();
                drUser.Read();
                if (drUser.HasRows)
                {
                    if (passwordTextBox.Text == drUser.GetString(1))
                    {
                        UserForm newForm = new UserForm(sqlCon, drUser.GetInt32(2));
                        drUser.Close();
                        con.Close();
                        this.Hide();
                        newForm.ShowDialog();
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Неправильный логин или пароль");
                        drUser.Close();
                        con.Close();
                    }
                }
                else
                {
                    MessageBox.Show("Неправильный логин или пароль");
                    drUser.Close();
                    con.Close();
                }
            }
        }

        // Вставка QR-кода с помощью выбора его в каталоге файлов
        private void openQRcodeButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog load = new OpenFileDialog();
            if (load.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                qrcodePictureBox.ImageLocation = load.FileName;
            }
        }

        // Авторизация по QR-коду
        private void scanQRcodeButton_Click(object sender, EventArgs e)
        {
            // Сканируем QR-код
            QRCodeDecoder decoder = new QRCodeDecoder();
            bool Recognition = false;
            string qrCodeKey = "";
            // Проверка изображения на наличие в нём QR-кода
            try
            {
                qrcodePictureBox.BackColor = Color.White;
                qrCodeKey = decoder.Decode(new QRCodeBitmapImage(qrcodePictureBox.Image as Bitmap));
                Recognition = true;
            }
            catch
            {
                MessageBox.Show("Не получилось сканировать QR-код");
            }
            if (Recognition == true)
            {
                SqlConnection con = new SqlConnection(sqlCon);
                con.Open();
                // Получение время сервека
                SqlCommand createTime = new SqlCommand("Select GETDATE()", con);
                SqlDataReader drTime = createTime.ExecuteReader();
                drTime.Read();
                DateTime serverTime = drTime.GetDateTime(0);
                drTime.Close();

                // Нахождение совпадений вставленного QR-кода, с тем, что есть в базе данных,
                // при отсутвии подобного или его "просроченности" - вывод ошибки"
                SqlCommand comQRuser = new SqlCommand($"Select authorizationKey, createDate, id_account from QRcodes where authorizationKey = '{qrCodeKey}'", con);
                SqlDataReader drQRuser = comQRuser.ExecuteReader();
                drQRuser.Read();
                if (drQRuser.HasRows)
                {
                    if (serverTime < drQRuser.GetDateTime(1).AddMinutes(1))
                    {
                        UserForm newForm = new UserForm(sqlCon, drQRuser.GetInt32(2));
                        drQRuser.Close();
                        con.Close();
                        this.Hide();
                        newForm.ShowDialog();
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("QR-код не действителен");
                        drQRuser.Close();
                        con.Close();
                    }
                }
                else
                {
                    MessageBox.Show("QR-код не действителен");
                    drQRuser.Close();
                    con.Close();
                }
            }
        }

        // Вставка QR-кода с помощью Drag-and-drop
        private void panelQRcode_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.All;
        }
        private void panelQRcode_DragDrop(object sender, DragEventArgs e)
        {
            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
            qrcodePictureBox.Image = Image.FromFile(files[0]);
        }
    }
}
