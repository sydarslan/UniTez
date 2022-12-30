
namespace UniTez
{
    partial class Danisman_DevamEdenTezler
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
            this.cbogr2 = new System.Windows.Forms.ComboBox();
            this.cbogr1 = new System.Windows.Forms.ComboBox();
            this.labelid = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbdurum = new System.Windows.Forms.ComboBox();
            this.Btnguncelle = new System.Windows.Forms.Button();
            this.datebaslangic = new System.Windows.Forms.DateTimePicker();
            this.datadevamtez = new System.Windows.Forms.DataGridView();
            this.txtanahtar = new System.Windows.Forms.RichTextBox();
            this.txtozet = new System.Windows.Forms.RichTextBox();
            this.cmtur = new System.Windows.Forms.ComboBox();
            this.Txttezadi = new System.Windows.Forms.TextBox();
            this.cbdil = new System.Windows.Forms.ComboBox();
            this.dateBitis = new System.Windows.Forms.DateTimePicker();
            this.danismanid = new System.Windows.Forms.Label();
            this.BtnKapat = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.datadevamtez)).BeginInit();
            this.SuspendLayout();
            // 
            // cbogr2
            // 
            this.cbogr2.FormattingEnabled = true;
            this.cbogr2.Location = new System.Drawing.Point(284, 217);
            this.cbogr2.Name = "cbogr2";
            this.cbogr2.Size = new System.Drawing.Size(217, 21);
            this.cbogr2.TabIndex = 52;
            // 
            // cbogr1
            // 
            this.cbogr1.FormattingEnabled = true;
            this.cbogr1.Location = new System.Drawing.Point(17, 217);
            this.cbogr1.Name = "cbogr1";
            this.cbogr1.Size = new System.Drawing.Size(217, 21);
            this.cbogr1.TabIndex = 51;
            // 
            // labelid
            // 
            this.labelid.AutoSize = true;
            this.labelid.Location = new System.Drawing.Point(485, 7);
            this.labelid.Name = "labelid";
            this.labelid.Size = new System.Drawing.Size(29, 13);
            this.labelid.TabIndex = 50;
            this.labelid.Text = "tezid";
            this.labelid.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Location = new System.Drawing.Point(507, 176);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 16);
            this.label1.TabIndex = 49;
            this.label1.Text = "-> Tez Bitiş Tarihi";
            // 
            // cbdurum
            // 
            this.cbdurum.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cbdurum.FormattingEnabled = true;
            this.cbdurum.Location = new System.Drawing.Point(17, 129);
            this.cbdurum.Name = "cbdurum";
            this.cbdurum.Size = new System.Drawing.Size(484, 26);
            this.cbdurum.TabIndex = 48;
            // 
            // Btnguncelle
            // 
            this.Btnguncelle.AutoEllipsis = true;
            this.Btnguncelle.BackColor = System.Drawing.Color.LightYellow;
            this.Btnguncelle.Font = new System.Drawing.Font("Courier New", 10F);
            this.Btnguncelle.Location = new System.Drawing.Point(518, 343);
            this.Btnguncelle.Name = "Btnguncelle";
            this.Btnguncelle.Size = new System.Drawing.Size(86, 29);
            this.Btnguncelle.TabIndex = 47;
            this.Btnguncelle.Text = "Güncelle";
            this.Btnguncelle.UseVisualStyleBackColor = false;
            this.Btnguncelle.Click += new System.EventHandler(this.Btnguncelle_Click);
            // 
            // datebaslangic
            // 
            this.datebaslangic.CalendarFont = new System.Drawing.Font("Courier New", 8.25F);
            this.datebaslangic.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.datebaslangic.Location = new System.Drawing.Point(17, 172);
            this.datebaslangic.Name = "datebaslangic";
            this.datebaslangic.Size = new System.Drawing.Size(217, 24);
            this.datebaslangic.TabIndex = 46;
            this.datebaslangic.Value = new System.DateTime(2022, 11, 27, 0, 0, 0, 0);
            // 
            // datadevamtez
            // 
            this.datadevamtez.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(243)))), ((int)(((byte)(239)))));
            this.datadevamtez.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datadevamtez.Location = new System.Drawing.Point(10, 378);
            this.datadevamtez.Name = "datadevamtez";
            this.datadevamtez.Size = new System.Drawing.Size(594, 164);
            this.datadevamtez.TabIndex = 37;
            this.datadevamtez.SelectionChanged += new System.EventHandler(this.datadevamtez_SelectionChanged);
            // 
            // txtanahtar
            // 
            this.txtanahtar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtanahtar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtanahtar.Location = new System.Drawing.Point(284, 258);
            this.txtanahtar.Name = "txtanahtar";
            this.txtanahtar.Size = new System.Drawing.Size(217, 75);
            this.txtanahtar.TabIndex = 45;
            this.txtanahtar.Text = "";
            // 
            // txtozet
            // 
            this.txtozet.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtozet.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtozet.Location = new System.Drawing.Point(17, 258);
            this.txtozet.Name = "txtozet";
            this.txtozet.Size = new System.Drawing.Size(217, 75);
            this.txtozet.TabIndex = 44;
            this.txtozet.Text = "";
            // 
            // cmtur
            // 
            this.cmtur.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmtur.FormattingEnabled = true;
            this.cmtur.Location = new System.Drawing.Point(284, 84);
            this.cmtur.Name = "cmtur";
            this.cmtur.Size = new System.Drawing.Size(217, 26);
            this.cmtur.TabIndex = 43;
            // 
            // Txttezadi
            // 
            this.Txttezadi.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Txttezadi.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Txttezadi.Location = new System.Drawing.Point(17, 36);
            this.Txttezadi.Name = "Txttezadi";
            this.Txttezadi.Size = new System.Drawing.Size(484, 24);
            this.Txttezadi.TabIndex = 38;
            // 
            // cbdil
            // 
            this.cbdil.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cbdil.FormattingEnabled = true;
            this.cbdil.Location = new System.Drawing.Point(17, 84);
            this.cbdil.Name = "cbdil";
            this.cbdil.Size = new System.Drawing.Size(217, 26);
            this.cbdil.TabIndex = 42;
            // 
            // dateBitis
            // 
            this.dateBitis.CalendarFont = new System.Drawing.Font("Courier New", 8.25F);
            this.dateBitis.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dateBitis.Location = new System.Drawing.Point(284, 172);
            this.dateBitis.Name = "dateBitis";
            this.dateBitis.Size = new System.Drawing.Size(217, 24);
            this.dateBitis.TabIndex = 53;
            this.dateBitis.Value = new System.DateTime(2022, 11, 27, 0, 0, 0, 0);
            // 
            // danismanid
            // 
            this.danismanid.AutoSize = true;
            this.danismanid.Location = new System.Drawing.Point(520, 7);
            this.danismanid.Name = "danismanid";
            this.danismanid.Size = new System.Drawing.Size(60, 13);
            this.danismanid.TabIndex = 54;
            this.danismanid.Text = "danismanid";
            this.danismanid.Visible = false;
            // 
            // BtnKapat
            // 
            this.BtnKapat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnKapat.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(243)))), ((int)(((byte)(239)))));
            this.BtnKapat.Location = new System.Drawing.Point(586, 2);
            this.BtnKapat.Name = "BtnKapat";
            this.BtnKapat.Size = new System.Drawing.Size(26, 23);
            this.BtnKapat.TabIndex = 55;
            this.BtnKapat.Text = "x";
            this.BtnKapat.UseVisualStyleBackColor = true;
            this.BtnKapat.Click += new System.EventHandler(this.BtnKapat_Click);
            // 
            // Danisman_DevamEdenTezler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(616, 554);
            this.Controls.Add(this.BtnKapat);
            this.Controls.Add(this.danismanid);
            this.Controls.Add(this.dateBitis);
            this.Controls.Add(this.cbogr2);
            this.Controls.Add(this.cbogr1);
            this.Controls.Add(this.labelid);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbdurum);
            this.Controls.Add(this.Btnguncelle);
            this.Controls.Add(this.datebaslangic);
            this.Controls.Add(this.datadevamtez);
            this.Controls.Add(this.txtanahtar);
            this.Controls.Add(this.txtozet);
            this.Controls.Add(this.cmtur);
            this.Controls.Add(this.cbdil);
            this.Controls.Add(this.Txttezadi);
            this.Name = "Danisman_DevamEdenTezler";
            this.Text = "Danisman_DevamEdenTezler";
            this.Load += new System.EventHandler(this.Danisman_DevamEdenTezler_Load);
            ((System.ComponentModel.ISupportInitialize)(this.datadevamtez)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbogr2;
        private System.Windows.Forms.ComboBox cbogr1;
        private System.Windows.Forms.Label labelid;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbdurum;
        private System.Windows.Forms.Button Btnguncelle;
        private System.Windows.Forms.DateTimePicker datebaslangic;
        private System.Windows.Forms.DataGridView datadevamtez;
        private System.Windows.Forms.RichTextBox txtanahtar;
        private System.Windows.Forms.RichTextBox txtozet;
        private System.Windows.Forms.ComboBox cmtur;
        private System.Windows.Forms.TextBox Txttezadi;
        private System.Windows.Forms.ComboBox cbdil;
        private System.Windows.Forms.DateTimePicker dateBitis;
        public System.Windows.Forms.Label danismanid;
        private System.Windows.Forms.Button BtnKapat;
    }
}