using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataEncryptionLab6_Kot_PC_21_MH
{
    public partial class Form1 : Form
    {
        private byte[] fileArray = Array.Empty<byte>();
        private byte[] randomArray = Array.Empty<byte>();
        private byte[] resultArray = Array.Empty<byte>();
        
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox_keyLength_byte.SelectedItem = "8";
            checkBox_viewPassWord.Checked = false;
        }

        private void button_fileKey_out_Click(object sender, EventArgs e)
        {
            var saveFileDialog = new SaveFileDialog
            {
                FileName = "MyKey",
                Filter = "Усі файли (*.*)|*.*|Текстові файли (*.txt)|*.txt",
                FilterIndex = 2,
                CreatePrompt = true,
                OverwritePrompt = true,
                RestoreDirectory = true
            };

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                text_fileKey_out.Text = saveFileDialog.FileName;

                try
                {
                    var pathSaveFile = text_fileKey_out.Text;
                    randomArray = File.ReadAllBytes(pathSaveFile);
                    textBox_Key.Text = stringHEX(randomArray);
                    comboBox_keyLength_byte.Text = randomArray.Length.ToString();
                }
                catch (Exception)
                {
                    randomArray = Array.Empty<byte>();
                    File.Create(text_fileKey_out.Text);
                }
            }
        }

        private string stringHEX(byte[] randomArray) => BitConverter.ToString(randomArray).Replace("-", "");

        private byte[] StringToByteArray(string textHEX)
        {
            var len = textHEX.Length;

            if (len % 2 == 1)
            {
                textHEX = $"0{textHEX}";
                textBox_Key.Text = textHEX;
                len++;
            }

            var len_half = len / 2;
            var bs = new byte[len_half];

            for (var i = 0; i != len_half; i++)
            {
                bs[i] = (byte)Int32.Parse(textHEX.Substring(i * 2, 2), System.Globalization.NumberStyles.HexNumber);
            }

            return bs;
        }

        private void button_OK_Click(object sender, EventArgs e)
        {
            var pathFileKey = text_fileKey_out.Text;

            DateTime timeStart;
            DateTime timeFinish;
            TimeSpan timeAll;

            if (pathFileKey == "")
            {
                MessageBox.Show("Вкажіть шлях до файлу з ключем", "Помилка в text_fileKey_out", MessageBoxButtons.OK, MessageBoxIcon.Information);
                text_fileKey_out.Focus();
                return;
            }

            if (!File.Exists(pathFileKey))
            {
                MessageBox.Show("Файл з ключом не існує, створіть файл", "Помилка файлу з ключем", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                button_fileKey_out.Focus();
                return;
            }

            Cursor = Cursors.WaitCursor;
            Application.DoEvents();
            
            timeStart = DateTime.Now;

            if (radioButton_keyGen.Checked)
            {
                randomArray = KeyGen.generator_Key(Int32.Parse(comboBox_keyLength_byte.Text));
            }

            if (radioButton_passWord.Checked)
            {
                var pass = new PassWordGen(textBox_password.Text, comboBox_keyLength_byte.Text);
                randomArray = pass.Result;
            }
            
            File.WriteAllBytes(pathFileKey, randomArray);
            textBox_Key.Text = stringHEX(randomArray);
            
            timeFinish = DateTime.Now;
            timeAll = timeFinish - timeStart;
            label_time.Text = timeAll.ToString(@"hh\:mm\:ss");
            
            Cursor = Cursors.Default;
            SystemSounds.Hand.Play();
        }

        private string ToDigitString(BitArray array)
        {
            var builder = new StringBuilder();
            foreach (var bit in array.Cast<bool>())
            {
                builder.Append(bit ? "1" : "");
            }

            return builder.ToString();
        }


        private void comboBox_keyLength_byte_TextChanged(object sender, EventArgs e)
        {
            var str = comboBox_keyLength_byte.Text;

            if (str != "")
            {
                label_bits.Text = Convert.ToString(Convert.ToInt32(str) * 8);
            }
        }


        private void checkBox_hand_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_hand.Checked)
            {
                textBox_Key.ReadOnly = false;
            }
            else
            {
                textBox_Key.ReadOnly = true;
                var pathKeyFile = text_fileKey_out.Text;
                if (pathKeyFile == "")
                {
                    MessageBox.Show("Вкажіть шлях до файлу з ключем", "Помилка в textBox_fileKey", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    checkBox_hand.Checked = true;
                    tabControl1.SelectedIndex = 0;
                    text_fileKey_out.Focus();
                    return;
                }

                if (!File.Exists(pathKeyFile))
                {
                    MessageBox.Show("Файл з ключем не існує, створіть файл", "Помилка файлу з ключем", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    checkBox_hand.Checked = true;
                    tabControl1.SelectedIndex = 0;
                    button_fileKey_out.Focus();
                    return;
                }

                randomArray = StringToByteArray(textBox_Key.Text);
                
                File.WriteAllBytes(pathKeyFile, randomArray);
            }
        }

        private void textBox_Key_KeyPress(object sender, KeyPressEventArgs e)
        {
            var c = e.KeyChar;
            
            if (!((c >= '0' && c <= '9') || (c >= 'A' && c <= 'F') || (c >= 'a' && c <= 'f') ||
                 (c >= 'a' && c <= 'f') || c == (char)Keys.Back))
            {
                e.Handled = true;
            }

        }

        private void comboBox_keyLength_byte_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsControl(e.KeyChar) && !Char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void button_fileOpen_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Filter = "Всі файли (*.*)|*.*|Текстові файли (*.txt)|*.txt",
                FilterIndex = 2,
                RestoreDirectory = true,
            };
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                var pathFileLoad = openFileDialog.FileName;
                this.fileArray = File.ReadAllBytes(pathFileLoad);
                label_fileOpen.Text = "файл";
                label_fileOpen.ForeColor = Color.Green;
                label_fileCipher.Text = "(нема)";
                label_fileCipher.ForeColor = Color.Red;
                label_fileSave.Text = "(нема)";
                label_fileSave.ForeColor = Color.Red;
                SystemSounds.Beep.Play();
            }
            
            Cursor = Cursors.Default;
        }

        private void button_fileCipher_Click(object sender, EventArgs e)
        {
            var lenFile = fileArray.Length;
            if (lenFile == 0)
            {
                MessageBox.Show("Щось не те з файлом", "Застереження", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            var lenKey = randomArray.Length;
            if (lenKey == 0)
            {
                MessageBox.Show("Щось не те з ключем", "Застереження", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            Cursor = Cursors.WaitCursor;
            resultArray = new byte[lenFile];

            for (var i = 0; i < lenKey; i++)
            {
                resultArray[i] = (byte)(fileArray[i] ^ randomArray[i % lenKey]);
            }
            
            label_fileCipher.Text = "файл";
            label_fileCipher.ForeColor = Color.Green;
            label_fileSave.Text = "(нема)";
            label_fileSave.ForeColor = Color.Red;
            SystemSounds.Beep.Play();
            Cursor = Cursors.Default;
        }

        private void button_fileSave_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            
            var saveFileDialog = new SaveFileDialog
            {
                FileName = "Файл після шифрування",
                Filter = "Всі файли (*.*)|*.*|Текстові файли (*.txt)|*.txt",
                FilterIndex = 2,
                CreatePrompt = true,
                OverwritePrompt = true,
                RestoreDirectory = true
            };
            
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                var pathKeySave = saveFileDialog.FileName;
                File.WriteAllBytes(pathKeySave, resultArray);
                if (resultArray.Length == 0)
                {
                    MessageBox.Show("Щось не те з шифруванням" +
                                    Environment.NewLine
                                    + "файл створено, але його розмір" + "\r\n"
                                    + "0 байт",
                        "Застереження",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                    Cursor = Cursors.Default;
                    return;
                }
                label_fileSave.Text = "файл";
                label_fileSave.ForeColor = Color.Green;
                SystemSounds.Beep.Play();
            }
            
            Cursor = Cursors.Default;
        }

        private void radioButton_keyGen_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton_keyGen.Checked)
            {
                button_OK.ImageIndex = 0;
                button_fileCipher.ImageIndex = 0;
                textBox_password.ForeColor = SystemColors.WindowText;
            }
        }


        private void radioButton_passWord_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton_passWord.Checked)
            {
                button_OK.ImageIndex = 1;
                button_fileCipher.ImageIndex = 1;
                textBox_password.ForeColor = Color.DarkGreen;
            }
        }

        private void linkLabel_author_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show("Кот Максим, РС-21мн", "Автор", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }


        private void checkBox_viewPassWord_CheckedChanged(object sender, EventArgs e)
        {
            textBox_password.PasswordChar = checkBox_viewPassWord.Checked ? '\0' : '*';
        }
    }
}