namespace Crypto_R
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1_pass = new System.Windows.Forms.Label();
            this.textBox1_key = new System.Windows.Forms.TextBox();
            this.checkBox1_keyView = new System.Windows.Forms.CheckBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.button_decrypt = new System.Windows.Forms.Button();
            this.button_encrypt = new System.Windows.Forms.Button();
            this.button_fileOpen = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1_pass
            // 
            this.label1_pass.AutoSize = true;
            this.label1_pass.Location = new System.Drawing.Point(9, 32);
            this.label1_pass.Name = "label1_pass";
            this.label1_pass.Size = new System.Drawing.Size(82, 18);
            this.label1_pass.TabIndex = 0;
            this.label1_pass.Text = "Password:";
            // 
            // textBox1_key
            // 
            this.textBox1_key.Location = new System.Drawing.Point(11, 60);
            this.textBox1_key.MaxLength = 64;
            this.textBox1_key.Name = "textBox1_key";
            this.textBox1_key.PasswordChar = '*';
            this.textBox1_key.Size = new System.Drawing.Size(489, 26);
            this.textBox1_key.TabIndex = 1;
            // 
            // checkBox1_keyView
            // 
            this.checkBox1_keyView.AutoSize = true;
            this.checkBox1_keyView.Location = new System.Drawing.Point(12, 92);
            this.checkBox1_keyView.Name = "checkBox1_keyView";
            this.checkBox1_keyView.Size = new System.Drawing.Size(136, 22);
            this.checkBox1_keyView.TabIndex = 2;
            this.checkBox1_keyView.Text = "View Password";
            this.checkBox1_keyView.UseVisualStyleBackColor = true;
            this.checkBox1_keyView.CheckedChanged += new System.EventHandler(this.checkBox1_keyView_CheckedChanged);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.Filter = "All files|*.*";
            this.openFileDialog1.ReadOnlyChecked = true;
            this.openFileDialog1.Title = "Choose a File";
            // 
            // button_decrypt
            // 
            this.button_decrypt.BackColor = System.Drawing.Color.Transparent;
            this.button_decrypt.FlatAppearance.BorderSize = 0;
            this.button_decrypt.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.button_decrypt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_decrypt.Image = global::Crypto_R.Properties.Resources.Documents64x64;
            this.button_decrypt.Location = new System.Drawing.Point(363, 141);
            this.button_decrypt.Name = "button_decrypt";
            this.button_decrypt.Size = new System.Drawing.Size(137, 74);
            this.button_decrypt.TabIndex = 4;
            this.button_decrypt.Text = "Decrypt";
            this.button_decrypt.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button_decrypt.UseVisualStyleBackColor = false;
            this.button_decrypt.Click += new System.EventHandler(this.button_decrypt_Click);
            // 
            // button_encrypt
            // 
            this.button_encrypt.BackColor = System.Drawing.Color.Transparent;
            this.button_encrypt.FlatAppearance.BorderSize = 0;
            this.button_encrypt.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.button_encrypt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_encrypt.Image = global::Crypto_R.Properties.Resources.Lock64x64;
            this.button_encrypt.Location = new System.Drawing.Point(188, 141);
            this.button_encrypt.Name = "button_encrypt";
            this.button_encrypt.Size = new System.Drawing.Size(136, 74);
            this.button_encrypt.TabIndex = 3;
            this.button_encrypt.Text = "Encrypt";
            this.button_encrypt.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button_encrypt.UseVisualStyleBackColor = false;
            this.button_encrypt.Click += new System.EventHandler(this.button_encrypt_Click);
            // 
            // button_fileOpen
            // 
            this.button_fileOpen.BackColor = System.Drawing.Color.Transparent;
            this.button_fileOpen.FlatAppearance.BorderSize = 0;
            this.button_fileOpen.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.button_fileOpen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_fileOpen.Image = global::Crypto_R.Properties.Resources.OpenFolder64x64;
            this.button_fileOpen.Location = new System.Drawing.Point(10, 141);
            this.button_fileOpen.Name = "button_fileOpen";
            this.button_fileOpen.Size = new System.Drawing.Size(151, 74);
            this.button_fileOpen.TabIndex = 5;
            this.button_fileOpen.Text = "Open File";
            this.button_fileOpen.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button_fileOpen.UseVisualStyleBackColor = false;
            this.button_fileOpen.Click += new System.EventHandler(this.button_fileOpen_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(513, 256);
            this.Controls.Add(this.button_fileOpen);
            this.Controls.Add(this.button_decrypt);
            this.Controls.Add(this.button_encrypt);
            this.Controls.Add(this.checkBox1_keyView);
            this.Controls.Add(this.textBox1_key);
            this.Controls.Add(this.label1_pass);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Crypto-R";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1_pass;
        private System.Windows.Forms.TextBox textBox1_key;
        private System.Windows.Forms.CheckBox checkBox1_keyView;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button button_encrypt;
        private System.Windows.Forms.Button button_decrypt;
        private System.Windows.Forms.Button button_fileOpen;
    }
}

