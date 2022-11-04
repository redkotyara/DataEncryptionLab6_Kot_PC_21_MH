namespace DataEncryptionLab6_Kot_PC_21_MH
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button_fileKey_out = new System.Windows.Forms.Button();
            this.text_fileKey_out = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.checkBox_hand = new System.Windows.Forms.CheckBox();
            this.textBox_Key = new System.Windows.Forms.TextBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_password = new System.Windows.Forms.TextBox();
            this.checkBox_viewPassWord = new System.Windows.Forms.CheckBox();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label_fileOpen = new System.Windows.Forms.Label();
            this.button_fileSave = new System.Windows.Forms.Button();
            this.label_fileSave = new System.Windows.Forms.Label();
            this.button_fileOpen = new System.Windows.Forms.Button();
            this.button_fileCipher = new System.Windows.Forms.Button();
            this.imageList_XOR = new System.Windows.Forms.ImageList(this.components);
            this.label_fileCipher = new System.Windows.Forms.Label();
            this.comboBox_keyLength_byte = new System.Windows.Forms.ComboBox();
            this.label_bits = new System.Windows.Forms.Label();
            this.label_time = new System.Windows.Forms.Label();
            this.button_OK = new System.Windows.Forms.Button();
            this.imageList_KeyGen = new System.Windows.Forms.ImageList(this.components);
            this.radioButton_keyGen = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.radioButton_passWord = new System.Windows.Forms.RadioButton();
            this.linkLabel_author = new System.Windows.Forms.LinkLabel();
            this.label4 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Location = new System.Drawing.Point(31, 34);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(757, 130);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(749, 104);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Файл з ключем";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button_fileKey_out);
            this.groupBox2.Controls.Add(this.text_fileKey_out);
            this.groupBox2.Location = new System.Drawing.Point(24, 25);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(566, 50);
            this.groupBox2.TabIndex = 17;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Шлях до файлу";
            // 
            // button_fileKey_out
            // 
            this.button_fileKey_out.Location = new System.Drawing.Point(475, 17);
            this.button_fileKey_out.Name = "button_fileKey_out";
            this.button_fileKey_out.Size = new System.Drawing.Size(75, 23);
            this.button_fileKey_out.TabIndex = 1;
            this.button_fileKey_out.Text = "...";
            this.button_fileKey_out.UseVisualStyleBackColor = true;
            this.button_fileKey_out.Click += new System.EventHandler(this.button_fileKey_out_Click);
            // 
            // text_fileKey_out
            // 
            this.text_fileKey_out.Location = new System.Drawing.Point(14, 17);
            this.text_fileKey_out.Name = "text_fileKey_out";
            this.text_fileKey_out.Size = new System.Drawing.Size(429, 20);
            this.text_fileKey_out.TabIndex = 2;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.groupBox3);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(749, 104);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Ключ у HEX форматы";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.checkBox_hand);
            this.groupBox3.Controls.Add(this.textBox_Key);
            this.groupBox3.Location = new System.Drawing.Point(58, 20);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(413, 54);
            this.groupBox3.TabIndex = 17;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Ключ (HEX формат)";
            // 
            // checkBox_hand
            // 
            this.checkBox_hand.Image = global::DataEncryptionLab6_Kot_PC_21_MH.Properties.Resources.whole_hand_24;
            this.checkBox_hand.Location = new System.Drawing.Point(299, 15);
            this.checkBox_hand.Name = "checkBox_hand";
            this.checkBox_hand.Size = new System.Drawing.Size(81, 24);
            this.checkBox_hand.TabIndex = 10;
            this.checkBox_hand.UseVisualStyleBackColor = true;
            this.checkBox_hand.CheckedChanged += new System.EventHandler(this.checkBox_hand_CheckedChanged);
            // 
            // textBox_Key
            // 
            this.textBox_Key.Location = new System.Drawing.Point(16, 17);
            this.textBox_Key.Name = "textBox_Key";
            this.textBox_Key.ReadOnly = true;
            this.textBox_Key.Size = new System.Drawing.Size(261, 20);
            this.textBox_Key.TabIndex = 9;
            this.textBox_Key.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_Key_KeyPress);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.groupBox4);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(749, 104);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Власний пароль";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label3);
            this.groupBox4.Controls.Add(this.textBox_password);
            this.groupBox4.Controls.Add(this.checkBox_viewPassWord);
            this.groupBox4.Location = new System.Drawing.Point(56, 18);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(578, 70);
            this.groupBox4.TabIndex = 17;
            this.groupBox4.TabStop = false;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(6, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(146, 36);
            this.label3.TabIndex = 13;
            this.label3.Text = "Придумайте свій пароль\r\n і запишіть сюди";
            // 
            // textBox_password
            // 
            this.textBox_password.Location = new System.Drawing.Point(175, 29);
            this.textBox_password.Name = "textBox_password";
            this.textBox_password.PasswordChar = '*';
            this.textBox_password.Size = new System.Drawing.Size(251, 20);
            this.textBox_password.TabIndex = 12;
            // 
            // checkBox_viewPassWord
            // 
            this.checkBox_viewPassWord.Image = global::DataEncryptionLab6_Kot_PC_21_MH.Properties.Resources.eye_3_24;
            this.checkBox_viewPassWord.Location = new System.Drawing.Point(461, 27);
            this.checkBox_viewPassWord.Name = "checkBox_viewPassWord";
            this.checkBox_viewPassWord.Size = new System.Drawing.Size(55, 25);
            this.checkBox_viewPassWord.TabIndex = 11;
            this.checkBox_viewPassWord.UseVisualStyleBackColor = true;
            this.checkBox_viewPassWord.CheckedChanged += new System.EventHandler(this.checkBox_viewPassWord_CheckedChanged);
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.label7);
            this.tabPage4.Controls.Add(this.label6);
            this.tabPage4.Controls.Add(this.label5);
            this.tabPage4.Controls.Add(this.label_fileOpen);
            this.tabPage4.Controls.Add(this.button_fileSave);
            this.tabPage4.Controls.Add(this.label_fileSave);
            this.tabPage4.Controls.Add(this.button_fileOpen);
            this.tabPage4.Controls.Add(this.button_fileCipher);
            this.tabPage4.Controls.Add(this.label_fileCipher);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(749, 104);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Файл XOR ключ";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(17, 19);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(99, 35);
            this.label7.TabIndex = 18;
            this.label7.Text = "1.\r\n    Відкрити файл\r\n";
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(417, 19);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 36);
            this.label6.TabIndex = 18;
            this.label6.Text = "3.\r\n    Зберегти файл";
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(215, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 33);
            this.label5.TabIndex = 18;
            this.label5.Text = "2.\r\n    Шифрування";
            // 
            // label_fileOpen
            // 
            this.label_fileOpen.ForeColor = System.Drawing.Color.Red;
            this.label_fileOpen.Location = new System.Drawing.Point(43, 54);
            this.label_fileOpen.Name = "label_fileOpen";
            this.label_fileOpen.Size = new System.Drawing.Size(54, 15);
            this.label_fileOpen.TabIndex = 13;
            this.label_fileOpen.Text = "(немає)";
            // 
            // button_fileSave
            // 
            this.button_fileSave.Image = global::DataEncryptionLab6_Kot_PC_21_MH.Properties.Resources.save_file;
            this.button_fileSave.Location = new System.Drawing.Point(523, 12);
            this.button_fileSave.Name = "button_fileSave";
            this.button_fileSave.Size = new System.Drawing.Size(104, 86);
            this.button_fileSave.TabIndex = 20;
            this.button_fileSave.UseVisualStyleBackColor = true;
            this.button_fileSave.Click += new System.EventHandler(this.button_fileSave_Click);
            // 
            // label_fileSave
            // 
            this.label_fileSave.ForeColor = System.Drawing.Color.Red;
            this.label_fileSave.Location = new System.Drawing.Point(448, 54);
            this.label_fileSave.Name = "label_fileSave";
            this.label_fileSave.Size = new System.Drawing.Size(48, 23);
            this.label_fileSave.TabIndex = 15;
            this.label_fileSave.Text = "(немає)";
            // 
            // button_fileOpen
            // 
            this.button_fileOpen.Image = global::DataEncryptionLab6_Kot_PC_21_MH.Properties.Resources.open_file;
            this.button_fileOpen.Location = new System.Drawing.Point(113, 6);
            this.button_fileOpen.Name = "button_fileOpen";
            this.button_fileOpen.Size = new System.Drawing.Size(85, 82);
            this.button_fileOpen.TabIndex = 18;
            this.button_fileOpen.UseVisualStyleBackColor = true;
            this.button_fileOpen.Click += new System.EventHandler(this.button_fileOpen_Click);
            // 
            // button_fileCipher
            // 
            this.button_fileCipher.ImageIndex = 0;
            this.button_fileCipher.ImageList = this.imageList_XOR;
            this.button_fileCipher.Location = new System.Drawing.Point(296, 14);
            this.button_fileCipher.Name = "button_fileCipher";
            this.button_fileCipher.Size = new System.Drawing.Size(112, 66);
            this.button_fileCipher.TabIndex = 19;
            this.button_fileCipher.UseVisualStyleBackColor = true;
            this.button_fileCipher.Click += new System.EventHandler(this.button_fileCipher_Click);
            // 
            // imageList_XOR
            // 
            this.imageList_XOR.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList_XOR.ImageStream")));
            this.imageList_XOR.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList_XOR.Images.SetKeyName(0, "yellow-xor.png");
            this.imageList_XOR.Images.SetKeyName(1, "green-xor.png");
            // 
            // label_fileCipher
            // 
            this.label_fileCipher.ForeColor = System.Drawing.Color.Red;
            this.label_fileCipher.Location = new System.Drawing.Point(232, 54);
            this.label_fileCipher.Name = "label_fileCipher";
            this.label_fileCipher.Size = new System.Drawing.Size(58, 23);
            this.label_fileCipher.TabIndex = 14;
            this.label_fileCipher.Text = "(немає)";
            // 
            // comboBox_keyLength_byte
            // 
            this.comboBox_keyLength_byte.FormattingEnabled = true;
            this.comboBox_keyLength_byte.Items.AddRange(new object[] { "8", "16", "24", "32", "12500000" });
            this.comboBox_keyLength_byte.Location = new System.Drawing.Point(158, 36);
            this.comboBox_keyLength_byte.Name = "comboBox_keyLength_byte";
            this.comboBox_keyLength_byte.Size = new System.Drawing.Size(88, 21);
            this.comboBox_keyLength_byte.TabIndex = 3;
            this.comboBox_keyLength_byte.TextChanged += new System.EventHandler(this.comboBox_keyLength_byte_TextChanged);
            this.comboBox_keyLength_byte.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.comboBox_keyLength_byte_KeyPress);
            // 
            // label_bits
            // 
            this.label_bits.Location = new System.Drawing.Point(158, 81);
            this.label_bits.Name = "label_bits";
            this.label_bits.Size = new System.Drawing.Size(100, 23);
            this.label_bits.TabIndex = 4;
            // 
            // label_time
            // 
            this.label_time.Location = new System.Drawing.Point(525, 312);
            this.label_time.Name = "label_time";
            this.label_time.Size = new System.Drawing.Size(168, 23);
            this.label_time.TabIndex = 5;
            this.label_time.Text = "00:00:00";
            // 
            // button_OK
            // 
            this.button_OK.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button_OK.ImageIndex = 0;
            this.button_OK.ImageList = this.imageList_KeyGen;
            this.button_OK.Location = new System.Drawing.Point(59, 303);
            this.button_OK.Name = "button_OK";
            this.button_OK.Size = new System.Drawing.Size(252, 32);
            this.button_OK.TabIndex = 6;
            this.button_OK.Text = "Згенерувати ключ";
            this.button_OK.UseVisualStyleBackColor = true;
            this.button_OK.Click += new System.EventHandler(this.button_OK_Click);
            // 
            // imageList_KeyGen
            // 
            this.imageList_KeyGen.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList_KeyGen.ImageStream")));
            this.imageList_KeyGen.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList_KeyGen.Images.SetKeyName(0, "key-xxl (1).png");
            this.imageList_KeyGen.Images.SetKeyName(1, "key-24.png");
            // 
            // radioButton_keyGen
            // 
            this.radioButton_keyGen.Location = new System.Drawing.Point(479, 34);
            this.radioButton_keyGen.Name = "radioButton_keyGen";
            this.radioButton_keyGen.Size = new System.Drawing.Size(202, 36);
            this.radioButton_keyGen.TabIndex = 7;
            this.radioButton_keyGen.TabStop = true;
            this.radioButton_keyGen.Text = "Ключ з криптографічного генератора псевдовипадкових послідовностей";
            this.radioButton_keyGen.UseVisualStyleBackColor = true;
            this.radioButton_keyGen.CheckedChanged += new System.EventHandler(this.radioButton_keyGen_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.radioButton_passWord);
            this.groupBox1.Controls.Add(this.radioButton_keyGen);
            this.groupBox1.Controls.Add(this.comboBox_keyLength_byte);
            this.groupBox1.Controls.Add(this.label_bits);
            this.groupBox1.Location = new System.Drawing.Point(37, 170);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(747, 127);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ключ";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(24, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 23);
            this.label2.TabIndex = 10;
            this.label2.Text = "Довжина ключа (біти):";
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(15, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 23);
            this.label1.TabIndex = 9;
            this.label1.Text = "Довжина ключа (байти):";
            // 
            // radioButton_passWord
            // 
            this.radioButton_passWord.Location = new System.Drawing.Point(479, 76);
            this.radioButton_passWord.Name = "radioButton_passWord";
            this.radioButton_passWord.Size = new System.Drawing.Size(202, 45);
            this.radioButton_passWord.TabIndex = 8;
            this.radioButton_passWord.TabStop = true;
            this.radioButton_passWord.Text = "Ключ генерується розширенням пароля";
            this.radioButton_passWord.UseVisualStyleBackColor = true;
            this.radioButton_passWord.CheckedChanged += new System.EventHandler(this.radioButton_passWord_CheckedChanged);
            // 
            // linkLabel_author
            // 
            this.linkLabel_author.Location = new System.Drawing.Point(673, 20);
            this.linkLabel_author.Name = "linkLabel_author";
            this.linkLabel_author.Size = new System.Drawing.Size(100, 23);
            this.linkLabel_author.TabIndex = 16;
            this.linkLabel_author.TabStop = true;
            this.linkLabel_author.Text = "Автор";
            this.linkLabel_author.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel_author_LinkClicked);
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(331, 312);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(180, 23);
            this.label4.TabIndex = 17;
            this.label4.Text = "Тривалість розрахунків (мін.:сек.)";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1039, 626);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.linkLabel_author);
            this.Controls.Add(this.button_OK);
            this.Controls.Add(this.label_time);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.ImageList imageList_KeyGen;
        private System.Windows.Forms.ImageList imageList_XOR;

        private System.Windows.Forms.Label label7;

        private System.Windows.Forms.Label label6;

        private System.Windows.Forms.Label label5;

        private System.Windows.Forms.Button button_fileSave;

        private System.Windows.Forms.Button button_fileCipher;

        private System.Windows.Forms.Button button_fileOpen;

        private System.Windows.Forms.Label label4;

        private System.Windows.Forms.Label label3;

        private System.Windows.Forms.GroupBox groupBox4;

        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox textBox_password;

        private System.Windows.Forms.Label label2;

        private System.Windows.Forms.Label label1;

        private System.Windows.Forms.GroupBox groupBox2;

        private System.Windows.Forms.Label label_fileOpen;
        private System.Windows.Forms.Label label_fileCipher;
        private System.Windows.Forms.LinkLabel linkLabel_author;

        private System.Windows.Forms.Label label_fileSave;

        private System.Windows.Forms.CheckBox checkBox_hand;
        private System.Windows.Forms.CheckBox checkBox_viewPassWord;

        private System.Windows.Forms.TextBox textBox_Key;

        private System.Windows.Forms.TextBox textBox1;

        private System.Windows.Forms.RadioButton radioButton_passWord;

        private System.Windows.Forms.GroupBox groupBox1;

        private System.Windows.Forms.RadioButton radioButton_keyGen;

        private System.Windows.Forms.Label label_bits;
        private System.Windows.Forms.Label label_time;
        private System.Windows.Forms.Button button_OK;

        private System.Windows.Forms.Button button_fileKey_out;
        private System.Windows.Forms.TextBox text_fileKey_out;
        private System.Windows.Forms.ComboBox comboBox_keyLength_byte;

        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;

        #endregion
    }
}