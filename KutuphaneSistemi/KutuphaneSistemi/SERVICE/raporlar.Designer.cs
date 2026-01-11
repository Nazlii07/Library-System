namespace KutuphaneSistemi.SERVICE
{
    partial class raporlar
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
            this.gbToplamKitap = new System.Windows.Forms.GroupBox();
            this.gbToplamUye = new System.Windows.Forms.GroupBox();
            this.gbEmanet = new System.Windows.Forms.GroupBox();
            this.gbGeciken = new System.Windows.Forms.GroupBox();
            this.SuspendLayout();
            // 
            // gbToplamKitap
            // 
            this.gbToplamKitap.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gbToplamKitap.Location = new System.Drawing.Point(75, 38);
            this.gbToplamKitap.Name = "gbToplamKitap";
            this.gbToplamKitap.Size = new System.Drawing.Size(273, 203);
            this.gbToplamKitap.TabIndex = 0;
            this.gbToplamKitap.TabStop = false;
            this.gbToplamKitap.Text = "Toplam Kitap Sayısı:";
            // 
            // gbToplamUye
            // 
            this.gbToplamUye.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gbToplamUye.Location = new System.Drawing.Point(454, 38);
            this.gbToplamUye.Name = "gbToplamUye";
            this.gbToplamUye.Size = new System.Drawing.Size(273, 203);
            this.gbToplamUye.TabIndex = 0;
            this.gbToplamUye.TabStop = false;
            this.gbToplamUye.Text = "Toplam Üye Sayısı:";
            // 
            // gbEmanet
            // 
            this.gbEmanet.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gbEmanet.Location = new System.Drawing.Point(75, 274);
            this.gbEmanet.Name = "gbEmanet";
            this.gbEmanet.Size = new System.Drawing.Size(273, 193);
            this.gbEmanet.TabIndex = 0;
            this.gbEmanet.TabStop = false;
            this.gbEmanet.Text = "Emanetteki Kitap Sayısı:";
            // 
            // gbGeciken
            // 
            this.gbGeciken.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gbGeciken.Location = new System.Drawing.Point(454, 274);
            this.gbGeciken.Name = "gbGeciken";
            this.gbGeciken.Size = new System.Drawing.Size(273, 193);
            this.gbGeciken.TabIndex = 0;
            this.gbGeciken.TabStop = false;
            this.gbGeciken.Text = "Geciken Kitaplar:";
            // 
            // raporlar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Pink;
            this.ClientSize = new System.Drawing.Size(800, 503);
            this.Controls.Add(this.gbGeciken);
            this.Controls.Add(this.gbEmanet);
            this.Controls.Add(this.gbToplamUye);
            this.Controls.Add(this.gbToplamKitap);
            this.Name = "raporlar";
            this.Text = "raporlar";
            this.Load += new System.EventHandler(this.raporlar_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbToplamKitap;
        private System.Windows.Forms.GroupBox gbToplamUye;
        private System.Windows.Forms.GroupBox gbEmanet;
        private System.Windows.Forms.GroupBox gbGeciken;
    }
}