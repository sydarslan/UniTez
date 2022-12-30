
namespace UniTez
{
    partial class Danisman_TezOneri
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
            this.BtnKapat = new System.Windows.Forms.Button();
            this.dataoneri = new System.Windows.Forms.DataGridView();
            this.BtnRed = new System.Windows.Forms.Button();
            this.BtnOnay = new System.Windows.Forms.Button();
            this.tezid = new System.Windows.Forms.Label();
            this.labeldanismanid = new System.Windows.Forms.Label();
            this.cbogr1 = new System.Windows.Forms.ComboBox();
            this.txtanahtar = new System.Windows.Forms.RichTextBox();
            this.txtozet = new System.Windows.Forms.RichTextBox();
            this.cmtur = new System.Windows.Forms.ComboBox();
            this.cbdil = new System.Windows.Forms.ComboBox();
            this.Txttezadi = new System.Windows.Forms.TextBox();
            this.cbbirim = new System.Windows.Forms.ComboBox();
            this.cbprogram = new System.Windows.Forms.ComboBox();
            this.cmbolum = new System.Windows.Forms.ComboBox();
            this.Btnguncelle = new System.Windows.Forms.Button();
            this.labelbolum = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataoneri)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnKapat
            // 
            this.BtnKapat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnKapat.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(243)))), ((int)(((byte)(239)))));
            this.BtnKapat.Location = new System.Drawing.Point(588, 3);
            this.BtnKapat.Name = "BtnKapat";
            this.BtnKapat.Size = new System.Drawing.Size(26, 23);
            this.BtnKapat.TabIndex = 56;
            this.BtnKapat.Text = "x";
            this.BtnKapat.UseVisualStyleBackColor = true;
            this.BtnKapat.Click += new System.EventHandler(this.BtnKapat_Click);
            // 
            // dataoneri
            // 
            this.dataoneri.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(243)))), ((int)(((byte)(239)))));
            this.dataoneri.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataoneri.Location = new System.Drawing.Point(12, 316);
            this.dataoneri.Name = "dataoneri";
            this.dataoneri.Size = new System.Drawing.Size(592, 226);
            this.dataoneri.TabIndex = 57;
            this.dataoneri.SelectionChanged += new System.EventHandler(this.dataoneri_SelectionChanged);
            // 
            // BtnRed
            // 
            this.BtnRed.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(243)))), ((int)(((byte)(239)))));
            this.BtnRed.Font = new System.Drawing.Font("Courier New", 8.25F);
            this.BtnRed.Location = new System.Drawing.Point(516, 201);
            this.BtnRed.Name = "BtnRed";
            this.BtnRed.Size = new System.Drawing.Size(88, 50);
            this.BtnRed.TabIndex = 60;
            this.BtnRed.Text = "Öneriyi Reddet";
            this.BtnRed.UseVisualStyleBackColor = false;
            // 
            // BtnOnay
            // 
            this.BtnOnay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(243)))), ((int)(((byte)(239)))));
            this.BtnOnay.Font = new System.Drawing.Font("Courier New", 8.25F);
            this.BtnOnay.Location = new System.Drawing.Point(516, 146);
            this.BtnOnay.Name = "BtnOnay";
            this.BtnOnay.Size = new System.Drawing.Size(88, 47);
            this.BtnOnay.TabIndex = 59;
            this.BtnOnay.Text = "Öneriyi Onayla";
            this.BtnOnay.UseVisualStyleBackColor = false;
            this.BtnOnay.Click += new System.EventHandler(this.BtnOnay_Click);
            // 
            // tezid
            // 
            this.tezid.AutoSize = true;
            this.tezid.Location = new System.Drawing.Point(522, 12);
            this.tezid.Name = "tezid";
            this.tezid.Size = new System.Drawing.Size(51, 13);
            this.tezid.TabIndex = 63;
            this.tezid.Text = "labeltezid";
            this.tezid.Visible = false;
            // 
            // labeldanismanid
            // 
            this.labeldanismanid.AutoSize = true;
            this.labeldanismanid.Location = new System.Drawing.Point(522, 29);
            this.labeldanismanid.Name = "labeldanismanid";
            this.labeldanismanid.Size = new System.Drawing.Size(82, 13);
            this.labeldanismanid.TabIndex = 61;
            this.labeldanismanid.Text = "labeldanismanid";
            this.labeldanismanid.Visible = false;
            // 
            // cbogr1
            // 
            this.cbogr1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cbogr1.FormattingEnabled = true;
            this.cbogr1.Location = new System.Drawing.Point(12, 176);
            this.cbogr1.Name = "cbogr1";
            this.cbogr1.Size = new System.Drawing.Size(484, 26);
            this.cbogr1.TabIndex = 74;
            // 
            // txtanahtar
            // 
            this.txtanahtar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtanahtar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtanahtar.Location = new System.Drawing.Point(279, 214);
            this.txtanahtar.Name = "txtanahtar";
            this.txtanahtar.Size = new System.Drawing.Size(217, 75);
            this.txtanahtar.TabIndex = 71;
            this.txtanahtar.Text = "";
            // 
            // txtozet
            // 
            this.txtozet.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtozet.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtozet.Location = new System.Drawing.Point(12, 214);
            this.txtozet.Name = "txtozet";
            this.txtozet.Size = new System.Drawing.Size(217, 75);
            this.txtozet.TabIndex = 70;
            this.txtozet.Text = "";
            // 
            // cmtur
            // 
            this.cmtur.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmtur.FormattingEnabled = true;
            this.cmtur.Location = new System.Drawing.Point(279, 133);
            this.cmtur.Name = "cmtur";
            this.cmtur.Size = new System.Drawing.Size(217, 26);
            this.cmtur.TabIndex = 69;
            // 
            // cbdil
            // 
            this.cbdil.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cbdil.FormattingEnabled = true;
            this.cbdil.Location = new System.Drawing.Point(12, 133);
            this.cbdil.Name = "cbdil";
            this.cbdil.Size = new System.Drawing.Size(217, 26);
            this.cbdil.TabIndex = 68;
            // 
            // Txttezadi
            // 
            this.Txttezadi.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Txttezadi.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Txttezadi.Location = new System.Drawing.Point(12, 12);
            this.Txttezadi.Name = "Txttezadi";
            this.Txttezadi.Size = new System.Drawing.Size(484, 24);
            this.Txttezadi.TabIndex = 64;
            // 
            // cbbirim
            // 
            this.cbbirim.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cbbirim.FormattingEnabled = true;
            this.cbbirim.Location = new System.Drawing.Point(12, 48);
            this.cbbirim.Name = "cbbirim";
            this.cbbirim.Size = new System.Drawing.Size(217, 26);
            this.cbbirim.TabIndex = 65;
            this.cbbirim.SelectedIndexChanged += new System.EventHandler(this.cbbirim_SelectedIndexChanged);
            // 
            // cbprogram
            // 
            this.cbprogram.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cbprogram.FormattingEnabled = true;
            this.cbprogram.Location = new System.Drawing.Point(279, 48);
            this.cbprogram.Name = "cbprogram";
            this.cbprogram.Size = new System.Drawing.Size(217, 26);
            this.cbprogram.TabIndex = 66;
            this.cbprogram.SelectedIndexChanged += new System.EventHandler(this.cbprogram_SelectedIndexChanged);
            // 
            // cmbolum
            // 
            this.cmbolum.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbolum.FormattingEnabled = true;
            this.cmbolum.Location = new System.Drawing.Point(12, 90);
            this.cmbolum.Name = "cmbolum";
            this.cmbolum.Size = new System.Drawing.Size(484, 26);
            this.cmbolum.TabIndex = 67;
            // 
            // Btnguncelle
            // 
            this.Btnguncelle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(243)))), ((int)(((byte)(239)))));
            this.Btnguncelle.Font = new System.Drawing.Font("Courier New", 10F);
            this.Btnguncelle.Location = new System.Drawing.Point(518, 281);
            this.Btnguncelle.Name = "Btnguncelle";
            this.Btnguncelle.Size = new System.Drawing.Size(86, 29);
            this.Btnguncelle.TabIndex = 75;
            this.Btnguncelle.Text = "Güncelle";
            this.Btnguncelle.UseVisualStyleBackColor = false;
            this.Btnguncelle.Click += new System.EventHandler(this.Btnguncelle_Click);
            // 
            // labelbolum
            // 
            this.labelbolum.AutoSize = true;
            this.labelbolum.Location = new System.Drawing.Point(525, 46);
            this.labelbolum.Name = "labelbolum";
            this.labelbolum.Size = new System.Drawing.Size(57, 13);
            this.labelbolum.TabIndex = 76;
            this.labelbolum.Text = "labelbolum";
            this.labelbolum.Visible = false;
            // 
            // Danisman_TezOneri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(616, 554);
            this.Controls.Add(this.labelbolum);
            this.Controls.Add(this.Btnguncelle);
            this.Controls.Add(this.cbogr1);
            this.Controls.Add(this.txtanahtar);
            this.Controls.Add(this.txtozet);
            this.Controls.Add(this.cmtur);
            this.Controls.Add(this.cbdil);
            this.Controls.Add(this.Txttezadi);
            this.Controls.Add(this.cbbirim);
            this.Controls.Add(this.cbprogram);
            this.Controls.Add(this.cmbolum);
            this.Controls.Add(this.tezid);
            this.Controls.Add(this.labeldanismanid);
            this.Controls.Add(this.BtnRed);
            this.Controls.Add(this.BtnOnay);
            this.Controls.Add(this.dataoneri);
            this.Controls.Add(this.BtnKapat);
            this.Name = "Danisman_TezOneri";
            this.Text = "Danisman_TezOneri";
            this.Load += new System.EventHandler(this.Danisman_TezOneri_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataoneri)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnKapat;
        private System.Windows.Forms.DataGridView dataoneri;
        private System.Windows.Forms.Button BtnRed;
        private System.Windows.Forms.Button BtnOnay;
        private System.Windows.Forms.Label tezid;
        public System.Windows.Forms.Label labeldanismanid;
        private System.Windows.Forms.ComboBox cbogr1;
        private System.Windows.Forms.RichTextBox txtanahtar;
        private System.Windows.Forms.RichTextBox txtozet;
        private System.Windows.Forms.ComboBox cmtur;
        private System.Windows.Forms.ComboBox cbdil;
        private System.Windows.Forms.TextBox Txttezadi;
        private System.Windows.Forms.ComboBox cbbirim;
        private System.Windows.Forms.ComboBox cbprogram;
        private System.Windows.Forms.ComboBox cmbolum;
        private System.Windows.Forms.Button Btnguncelle;
        private System.Windows.Forms.Label labelbolum;
    }
}