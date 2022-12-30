
namespace UniTez
{
    partial class Danisman_Bilgilerim
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
            this.TxtAd = new System.Windows.Forms.TextBox();
            this.TxtSoyad = new System.Windows.Forms.TextBox();
            this.Txtmail = new System.Windows.Forms.TextBox();
            this.TxtTelefon = new System.Windows.Forms.TextBox();
            this.TxtSifre = new System.Windows.Forms.TextBox();
            this.cbbolum = new System.Windows.Forms.ComboBox();
            this.BtnGüncelle = new System.Windows.Forms.Button();
            this.BtnKapat = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TxtAd
            // 
            this.TxtAd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtAd.Location = new System.Drawing.Point(189, 78);
            this.TxtAd.Name = "TxtAd";
            this.TxtAd.Size = new System.Drawing.Size(267, 26);
            this.TxtAd.TabIndex = 0;
            // 
            // TxtSoyad
            // 
            this.TxtSoyad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtSoyad.Location = new System.Drawing.Point(189, 123);
            this.TxtSoyad.Name = "TxtSoyad";
            this.TxtSoyad.Size = new System.Drawing.Size(267, 26);
            this.TxtSoyad.TabIndex = 23;
            // 
            // Txtmail
            // 
            this.Txtmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Txtmail.Location = new System.Drawing.Point(189, 165);
            this.Txtmail.Name = "Txtmail";
            this.Txtmail.Size = new System.Drawing.Size(267, 26);
            this.Txtmail.TabIndex = 24;
            // 
            // TxtTelefon
            // 
            this.TxtTelefon.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtTelefon.Location = new System.Drawing.Point(189, 211);
            this.TxtTelefon.Name = "TxtTelefon";
            this.TxtTelefon.Size = new System.Drawing.Size(267, 26);
            this.TxtTelefon.TabIndex = 25;
            // 
            // TxtSifre
            // 
            this.TxtSifre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtSifre.Location = new System.Drawing.Point(189, 259);
            this.TxtSifre.Name = "TxtSifre";
            this.TxtSifre.Size = new System.Drawing.Size(267, 26);
            this.TxtSifre.TabIndex = 26;
            // 
            // cbbolum
            // 
            this.cbbolum.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cbbolum.FormattingEnabled = true;
            this.cbbolum.Location = new System.Drawing.Point(189, 307);
            this.cbbolum.Name = "cbbolum";
            this.cbbolum.Size = new System.Drawing.Size(267, 28);
            this.cbbolum.TabIndex = 27;
            // 
            // BtnGüncelle
            // 
            this.BtnGüncelle.Location = new System.Drawing.Point(241, 405);
            this.BtnGüncelle.Name = "BtnGüncelle";
            this.BtnGüncelle.Size = new System.Drawing.Size(169, 33);
            this.BtnGüncelle.TabIndex = 28;
            this.BtnGüncelle.Text = "Bilgileri Güncelle";
            this.BtnGüncelle.UseVisualStyleBackColor = true;
            this.BtnGüncelle.Click += new System.EventHandler(this.BtnGüncelle_Click);
            // 
            // BtnKapat
            // 
            this.BtnKapat.Location = new System.Drawing.Point(588, 2);
            this.BtnKapat.Name = "BtnKapat";
            this.BtnKapat.Size = new System.Drawing.Size(26, 23);
            this.BtnKapat.TabIndex = 57;
            this.BtnKapat.Text = "x";
            this.BtnKapat.UseVisualStyleBackColor = true;
            this.BtnKapat.Click += new System.EventHandler(this.BtnKapat_Click);
            // 
            // Danisman_Bilgilerim
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(616, 554);
            this.Controls.Add(this.BtnKapat);
            this.Controls.Add(this.BtnGüncelle);
            this.Controls.Add(this.cbbolum);
            this.Controls.Add(this.TxtSifre);
            this.Controls.Add(this.TxtTelefon);
            this.Controls.Add(this.Txtmail);
            this.Controls.Add(this.TxtSoyad);
            this.Controls.Add(this.TxtAd);
            this.Name = "Danisman_Bilgilerim";
            this.Text = "Danisman_Bilgilerim";
            this.Load += new System.EventHandler(this.Danisman_Bilgilerim_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtAd;
        private System.Windows.Forms.TextBox TxtSoyad;
        private System.Windows.Forms.TextBox Txtmail;
        private System.Windows.Forms.TextBox TxtTelefon;
        private System.Windows.Forms.TextBox TxtSifre;
        private System.Windows.Forms.ComboBox cbbolum;
        private System.Windows.Forms.Button BtnGüncelle;
        private System.Windows.Forms.Button BtnKapat;
    }
}