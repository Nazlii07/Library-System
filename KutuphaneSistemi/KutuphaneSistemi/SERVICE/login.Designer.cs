namespace KutuphaneSistemi.SERVICE
{
    partial class login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(login));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.üyeDeğilmisiniz = new System.Windows.Forms.LinkLabel();
            this.txtKullaniciAdi = new System.Windows.Forms.Label();
            this.txtSifre = new System.Windows.Forms.Label();
            this.girisButton = new System.Windows.Forms.Button();
            this.kullaniciBox = new System.Windows.Forms.TextBox();
            this.girisYapTB = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(261, 23);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(295, 233);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // üyeDeğilmisiniz
            // 
            this.üyeDeğilmisiniz.AutoSize = true;
            this.üyeDeğilmisiniz.LinkColor = System.Drawing.Color.Black;
            this.üyeDeğilmisiniz.Location = new System.Drawing.Point(340, 454);
            this.üyeDeğilmisiniz.Name = "üyeDeğilmisiniz";
            this.üyeDeğilmisiniz.Size = new System.Drawing.Size(117, 16);
            this.üyeDeğilmisiniz.TabIndex = 1;
            this.üyeDeğilmisiniz.TabStop = true;
            this.üyeDeğilmisiniz.Text = "Üye Değil Misiniz?";
            this.üyeDeğilmisiniz.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.üyeDeğilmisiniz_LinkClicked);
            // 
            // txtKullaniciAdi
            // 
            this.txtKullaniciAdi.AutoSize = true;
            this.txtKullaniciAdi.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtKullaniciAdi.Location = new System.Drawing.Point(176, 290);
            this.txtKullaniciAdi.Name = "txtKullaniciAdi";
            this.txtKullaniciAdi.Size = new System.Drawing.Size(123, 23);
            this.txtKullaniciAdi.TabIndex = 2;
            this.txtKullaniciAdi.Text = "Kullanıcı Adı:";
            // 
            // txtSifre
            // 
            this.txtSifre.AutoSize = true;
            this.txtSifre.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtSifre.Location = new System.Drawing.Point(197, 353);
            this.txtSifre.Name = "txtSifre";
            this.txtSifre.Size = new System.Drawing.Size(63, 23);
            this.txtSifre.TabIndex = 3;
            this.txtSifre.Text = "Şifre: ";
            // 
            // girisButton
            // 
            this.girisButton.Location = new System.Drawing.Point(358, 411);
            this.girisButton.Name = "girisButton";
            this.girisButton.Size = new System.Drawing.Size(75, 27);
            this.girisButton.TabIndex = 4;
            this.girisButton.Text = "Giriş Yap";
            this.girisButton.UseVisualStyleBackColor = true;
            this.girisButton.Click += new System.EventHandler(this.girisButton_Click);
            // 
            // kullaniciBox
            // 
            this.kullaniciBox.BackColor = System.Drawing.Color.White;
            this.kullaniciBox.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kullaniciBox.Location = new System.Drawing.Point(322, 290);
            this.kullaniciBox.Name = "kullaniciBox";
            this.kullaniciBox.Size = new System.Drawing.Size(164, 34);
            this.kullaniciBox.TabIndex = 5;
            this.kullaniciBox.TextChanged += new System.EventHandler(this.kullanicAdiTB_TextChanged);
            // 
            // girisYapTB
            // 
            this.girisYapTB.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.girisYapTB.Location = new System.Drawing.Point(322, 353);
            this.girisYapTB.Name = "girisYapTB";
            this.girisYapTB.Size = new System.Drawing.Size(164, 34);
            this.girisYapTB.TabIndex = 6;
            // 
            // login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(800, 512);
            this.Controls.Add(this.girisYapTB);
            this.Controls.Add(this.kullaniciBox);
            this.Controls.Add(this.girisButton);
            this.Controls.Add(this.txtSifre);
            this.Controls.Add(this.txtKullaniciAdi);
            this.Controls.Add(this.üyeDeğilmisiniz);
            this.Controls.Add(this.pictureBox1);
            this.Name = "login";
            this.Text = "login";
            this.Load += new System.EventHandler(this.login_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.LinkLabel üyeDeğilmisiniz;
        private System.Windows.Forms.Label txtKullaniciAdi;
        private System.Windows.Forms.Label txtSifre;
        private System.Windows.Forms.Button girisButton;
        private System.Windows.Forms.TextBox kullaniciBox;
        private System.Windows.Forms.TextBox girisYapTB;
    }
}