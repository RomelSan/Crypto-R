using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.IO;
using System.Security;
using System.Security.Cryptography;

namespace Crypto_R
{
    public partial class Form1 : Form
    {
        //Globals
        public static string global_fileName { get; set; }
        public static string global_password { get; set; }

        public Form1()
        {
            InitializeComponent();
            global_fileName = "";
            global_password = "";
        }

        #region Crypto Functions
        public byte[] AES_Encrypt(byte[] bytesToBeEncrypted, byte[] passwordBytes)
        {
            byte[] encryptedBytes = null;

            byte[] saltBytes = new byte[] { 3, 6, 9, 12, 3, 6, 9, 12 }; // 8 bytes Salt (range from 0 to 255)

            using (MemoryStream ms = new MemoryStream())
            {
                using (RijndaelManaged AES = new RijndaelManaged())
                {
                    AES.KeySize = 256; // The minimum size of the key is 128 bits, and the maximum size is 256 bits.
                    AES.BlockSize = 128; // 128 bits AES Standard

                    var key = new Rfc2898DeriveBytes(passwordBytes, saltBytes, 1000); //Implements password-based key derivation functionality, PBKDF2, by using a pseudo-random number generator based on HMACSHA1.
                    AES.Key = key.GetBytes(AES.KeySize / 8);
                    AES.IV = key.GetBytes(AES.BlockSize / 8);

                    AES.Mode = CipherMode.CBC;

                    using (var cs = new CryptoStream(ms, AES.CreateEncryptor(), CryptoStreamMode.Write))
                    {
                        cs.Write(bytesToBeEncrypted, 0, bytesToBeEncrypted.Length);
                        cs.Close();
                    }
                    encryptedBytes = ms.ToArray();
                }
            }

            return encryptedBytes;
        }

        public byte[] AES_Decrypt(byte[] bytesToBeDecrypted, byte[] passwordBytes)
        {
            byte[] decryptedBytes = null;

            byte[] saltBytes = new byte[] { 3, 6, 9, 12, 3, 6, 9, 12 }; // 8 bytes Salt (range from 0 to 255)

            using (MemoryStream ms = new MemoryStream())
            {
                using (RijndaelManaged AES = new RijndaelManaged())
                {
                    AES.KeySize = 256;
                    AES.BlockSize = 128;

                    var key = new Rfc2898DeriveBytes(passwordBytes, saltBytes, 1000);
                    AES.Key = key.GetBytes(AES.KeySize / 8);
                    AES.IV = key.GetBytes(AES.BlockSize / 8);

                    AES.Mode = CipherMode.CBC;

                    using (var cs = new CryptoStream(ms, AES.CreateDecryptor(), CryptoStreamMode.Write))
                    {
                        cs.Write(bytesToBeDecrypted, 0, bytesToBeDecrypted.Length);
                        cs.Close();
                    }
                    decryptedBytes = ms.ToArray();
                }
            }

            return decryptedBytes;
        }
        #endregion
        #region File Crypto Function
        private string file_encrypt(string file_name, string password)
        {
            try
            {
                byte[] bytesToBeEncrypted = File.ReadAllBytes(file_name);
                byte[] passwordBytes = Encoding.UTF8.GetBytes(password);
                passwordBytes = SHA256.Create().ComputeHash(passwordBytes);
                byte[] bytesEncrypted = AES_Encrypt(bytesToBeEncrypted, passwordBytes);
                string encrypted_file = file_name;
                File.WriteAllBytes(encrypted_file, bytesEncrypted);
                return "OK";
            }

            catch
            {
                return "NO OK";
            }
        }
        private string file_decrypt(string file_name, string password)
        {
            try
            {
                byte[] bytesToBeDecrypted = File.ReadAllBytes(file_name);
                byte[] passwordBytes = Encoding.UTF8.GetBytes(password);
                passwordBytes = SHA256.Create().ComputeHash(passwordBytes);
                byte[] bytesDecrypted = AES_Decrypt(bytesToBeDecrypted, passwordBytes);
                File.WriteAllBytes(file_name, bytesDecrypted);
                return "OK";
            }

            catch
            {
                return "NO OK";
            }
        }
            
        #endregion

        private void checkBox1_keyView_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1_keyView.Checked)
            {
                textBox1_key.PasswordChar = '\0';
            }
            if (!checkBox1_keyView.Checked)
            {
                textBox1_key.PasswordChar = '*';
            }
        }

        private void button_fileOpen_Click(object sender, EventArgs e)
        {
            DialogResult result = openFileDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                global_fileName = openFileDialog1.FileName;
            }
        }

        private void button_encrypt_Click(object sender, EventArgs e)
        {
            global_password = textBox1_key.Text;
            if (global_password.Length < 5)
            {
                MessageBox.Show("Please Type a Password with more than 4 Chars", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            else if (global_fileName != "")
            {
                string file_result = file_encrypt(global_fileName,global_password);

                if (file_result == "OK")
                {
                    global_fileName = "";
                    MessageBox.Show("Encryption OK", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                else { MessageBox.Show("Encryption Failed", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            }

            else
            {
                MessageBox.Show("Please Select a File to Encrypt", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void button_decrypt_Click(object sender, EventArgs e)
        {
            global_password = textBox1_key.Text;
            if (global_password.Length < 5)
            {
                MessageBox.Show("Please Type a Password with more than 4 Chars", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            else if (global_fileName != "")
            {
                string file_result = file_decrypt(global_fileName, global_password);

                if (file_result == "OK")
                {
                    MessageBox.Show("Decryption OK", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                else { MessageBox.Show("Decryption Failed", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            }

            else
            {
                MessageBox.Show("Please Select a File to Decrypt", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
