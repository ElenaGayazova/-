using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace WinRSA
{
    public partial class FrmMain : Form
    {
        RSACryptoServiceProvider RSA = new RSACryptoServiceProvider();

        RSAParameters privateKey;
        RSAParameters publicKey;

        public FrmMain()
        {
            InitializeComponent();
            // создаём ключи
            privateKey = RSA.ExportParameters(true);
            publicKey = RSA.ExportParameters(false);
        }

        private void btSend1_Click(object sender, EventArgs e)
        {
            byte[] encrypt;
            if (sender == btSend1)
            {
                encrypt = Send(tbMessage1, tbLog1);
                Receive(encrypt, tbLog2);
            }
            else
            {
                encrypt = Send(tbMessage2, tbLog2);
                Receive(encrypt, tbLog1);
            }
        }

        private byte[] Send(TextBox tbMess, TextBox tbLog)
        {
            UnicodeEncoding byteConverter = new UnicodeEncoding();
            string toEncrypt = tbMess.Text;
            string time = DateTime.Now.ToString("s");
            // добавляем в лог исходное сообщение
            tbLog.Text += Environment.NewLine +  $"{time}->:{toEncrypt}";
            // шифруем сообщение в байтах
            byte[] encBytes = RSAEncrypt(byteConverter.GetBytes(toEncrypt), publicKey, false);

            // получаем строковое представление зашифрованного содержимого
            string encrypt = byteConverter.GetString(encBytes);
            // отобраем в логе зашифрованное
            tbLog.Text += Environment.NewLine + $"{time}->(шифр.):{encrypt}";
            return encBytes;
        }
        private string Receive(byte[] encryptedMessage, TextBox tbLog)
        {
            UnicodeEncoding byteConverter = new UnicodeEncoding();
            string time = DateTime.Now.ToString("s");
            string encrypted = byteConverter.GetString(encryptedMessage);

            // добавляем в лог зашифрованное
            tbLog.Text += Environment.NewLine + $"{time}<-(шифр.):{encrypted}";
            // дешефруем с приватным ключом
            byte[] decBytes = RSADecrypt(encryptedMessage, privateKey, false);
            // получаем в виде текста
            string decrypt = byteConverter.GetString(decBytes);
            // отображаем в логе
            tbLog.Text += Environment.NewLine + $"{time}<-:{decrypt}";
            return decrypt;
        }

        static public byte[] RSAEncrypt(byte[] DataToEncrypt, RSAParameters RSAKeyInfo, bool DoOAEPPadding)
        {
            // новый объект типа RSACryptoServiceProvider.
            RSACryptoServiceProvider RSA = new RSACryptoServiceProvider();

            // импорт информации из RSA ключа Import the RSA Key information
            // информацию об открытом ключе
            RSA.ImportParameters(RSAKeyInfo);

            // шифрование
            return RSA.Encrypt(DataToEncrypt, DoOAEPPadding);
        }

        static public byte[] RSADecrypt(byte[] DataToDecrypt, RSAParameters RSAKeyInfo, bool DoOAEPPadding)
        {
            RSACryptoServiceProvider RSA = new RSACryptoServiceProvider();

            // импорт информации из RSA ключа Import the RSA Key information
            // информацию об закрытом ключе
            RSA.ImportParameters(RSAKeyInfo);

            // дешифрация
            return RSA.Decrypt(DataToDecrypt, DoOAEPPadding);
        }

    }
}
