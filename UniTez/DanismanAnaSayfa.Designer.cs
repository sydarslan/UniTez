
namespace UniTez
{
    partial class DanismanAnaSayfa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DanismanAnaSayfa));
            this.tezBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.uniTezDataSet1 = new UniTez.UniTezDataSet1();
            this.tezTableAdapter = new UniTez.UniTezDataSet1TableAdapters.TezTableAdapter();
            this.panelChildForm = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.labeltezsayisi = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.labeldevamtezsayisi = new System.Windows.Forms.Label();
            this.panelmenu = new System.Windows.Forms.Panel();
            this.panelalt = new System.Windows.Forms.Panel();
            this.BtnBilgilerim = new System.Windows.Forms.Button();
            this.BtnTezOnerileri = new System.Windows.Forms.Button();
            this.BtnTezBasvurulari = new System.Windows.Forms.Button();
            this.BtnDevamEdenTezler = new System.Windows.Forms.Button();
            this.BtnOlusmusTez = new System.Windows.Forms.Button();
            this.BtnTezOlustur = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.labeldanismansoyad = new System.Windows.Forms.Label();
            this.labeldanismanbolum = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.labeldanismanad = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.tezBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uniTezDataSet1)).BeginInit();
            this.panelChildForm.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panelmenu.SuspendLayout();
            this.panelalt.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tezBindingSource
            // 
            this.tezBindingSource.DataMember = "Tez";
            this.tezBindingSource.DataSource = this.uniTezDataSet1;
            // 
            // uniTezDataSet1
            // 
            this.uniTezDataSet1.DataSetName = "UniTezDataSet1";
            this.uniTezDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tezTableAdapter
            // 
            this.tezTableAdapter.ClearBeforeFill = true;
            // 
            // panelChildForm
            // 
            this.panelChildForm.AutoScroll = true;
            this.panelChildForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(247)))), ((int)(((byte)(238)))));
            this.panelChildForm.Controls.Add(this.panel3);
            this.panelChildForm.Controls.Add(this.panel1);
            this.panelChildForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelChildForm.Location = new System.Drawing.Point(214, 0);
            this.panelChildForm.Name = "panelChildForm";
            this.panelChildForm.Size = new System.Drawing.Size(632, 593);
            this.panelChildForm.TabIndex = 2;
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.labeltezsayisi);
            this.panel3.Location = new System.Drawing.Point(41, 22);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(211, 153);
            this.panel3.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Courier New", 8.25F);
            this.label1.Location = new System.Drawing.Point(13, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(168, 14);
            this.label1.TabIndex = 2;
            this.label1.Text = "Oluşturulmuş Tez Sayısı";
            // 
            // labeltezsayisi
            // 
            this.labeltezsayisi.AutoSize = true;
            this.labeltezsayisi.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labeltezsayisi.Location = new System.Drawing.Point(87, 81);
            this.labeltezsayisi.Name = "labeltezsayisi";
            this.labeltezsayisi.Size = new System.Drawing.Size(16, 16);
            this.labeltezsayisi.TabIndex = 1;
            this.labeltezsayisi.Text = "s";
            this.labeltezsayisi.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.labeldevamtezsayisi);
            this.panel1.Location = new System.Drawing.Point(331, 22);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(232, 153);
            this.panel1.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Courier New", 8.25F);
            this.label2.Location = new System.Drawing.Point(29, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(154, 14);
            this.label2.TabIndex = 3;
            this.label2.Text = "Devam Eden Tez Sayısı";
            // 
            // labeldevamtezsayisi
            // 
            this.labeldevamtezsayisi.AutoSize = true;
            this.labeldevamtezsayisi.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labeldevamtezsayisi.Location = new System.Drawing.Point(109, 81);
            this.labeldevamtezsayisi.Name = "labeldevamtezsayisi";
            this.labeldevamtezsayisi.Size = new System.Drawing.Size(16, 13);
            this.labeldevamtezsayisi.TabIndex = 1;
            this.labeldevamtezsayisi.Text = "D";
            // 
            // panelmenu
            // 
            this.panelmenu.AutoScroll = true;
            this.panelmenu.BackColor = System.Drawing.Color.LightSteelBlue;
            this.panelmenu.Controls.Add(this.panelalt);
            this.panelmenu.Controls.Add(this.panel2);
            this.panelmenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelmenu.Location = new System.Drawing.Point(0, 0);
            this.panelmenu.Name = "panelmenu";
            this.panelmenu.Size = new System.Drawing.Size(214, 593);
            this.panelmenu.TabIndex = 0;
            // 
            // panelalt
            // 
            this.panelalt.BackColor = System.Drawing.Color.LightSteelBlue;
            this.panelalt.Controls.Add(this.BtnBilgilerim);
            this.panelalt.Controls.Add(this.BtnTezOnerileri);
            this.panelalt.Controls.Add(this.BtnTezBasvurulari);
            this.panelalt.Controls.Add(this.BtnDevamEdenTezler);
            this.panelalt.Controls.Add(this.BtnOlusmusTez);
            this.panelalt.Controls.Add(this.BtnTezOlustur);
            this.panelalt.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelalt.Location = new System.Drawing.Point(0, 104);
            this.panelalt.Name = "panelalt";
            this.panelalt.Size = new System.Drawing.Size(214, 445);
            this.panelalt.TabIndex = 2;
            // 
            // BtnBilgilerim
            // 
            this.BtnBilgilerim.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnBilgilerim.FlatAppearance.BorderSize = 0;
            this.BtnBilgilerim.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnBilgilerim.Font = new System.Drawing.Font("Courier New", 8.25F);
            this.BtnBilgilerim.Location = new System.Drawing.Point(0, 295);
            this.BtnBilgilerim.Name = "BtnBilgilerim";
            this.BtnBilgilerim.Size = new System.Drawing.Size(214, 61);
            this.BtnBilgilerim.TabIndex = 12;
            this.BtnBilgilerim.Text = "BİLGİLERİM";
            this.BtnBilgilerim.UseVisualStyleBackColor = true;
            this.BtnBilgilerim.Click += new System.EventHandler(this.BtnBilgilerim_Click);
            // 
            // BtnTezOnerileri
            // 
            this.BtnTezOnerileri.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnTezOnerileri.FlatAppearance.BorderSize = 0;
            this.BtnTezOnerileri.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnTezOnerileri.Font = new System.Drawing.Font("Courier New", 8.25F);
            this.BtnTezOnerileri.Location = new System.Drawing.Point(0, 236);
            this.BtnTezOnerileri.Name = "BtnTezOnerileri";
            this.BtnTezOnerileri.Size = new System.Drawing.Size(214, 59);
            this.BtnTezOnerileri.TabIndex = 10;
            this.BtnTezOnerileri.Text = "TEZ ÖNERİLERİ";
            this.BtnTezOnerileri.UseVisualStyleBackColor = true;
            this.BtnTezOnerileri.Click += new System.EventHandler(this.BtnTezOnerileri_Click);
            // 
            // BtnTezBasvurulari
            // 
            this.BtnTezBasvurulari.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnTezBasvurulari.FlatAppearance.BorderSize = 0;
            this.BtnTezBasvurulari.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnTezBasvurulari.Font = new System.Drawing.Font("Courier New", 8.25F);
            this.BtnTezBasvurulari.Location = new System.Drawing.Point(0, 177);
            this.BtnTezBasvurulari.Name = "BtnTezBasvurulari";
            this.BtnTezBasvurulari.Size = new System.Drawing.Size(214, 59);
            this.BtnTezBasvurulari.TabIndex = 9;
            this.BtnTezBasvurulari.Text = "TEZ BAŞVURULARI";
            this.BtnTezBasvurulari.UseVisualStyleBackColor = true;
            this.BtnTezBasvurulari.Click += new System.EventHandler(this.BtnTezBasvurulari_Click);
            // 
            // BtnDevamEdenTezler
            // 
            this.BtnDevamEdenTezler.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnDevamEdenTezler.FlatAppearance.BorderSize = 0;
            this.BtnDevamEdenTezler.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnDevamEdenTezler.Font = new System.Drawing.Font("Courier New", 8.25F);
            this.BtnDevamEdenTezler.Location = new System.Drawing.Point(0, 118);
            this.BtnDevamEdenTezler.Name = "BtnDevamEdenTezler";
            this.BtnDevamEdenTezler.Size = new System.Drawing.Size(214, 59);
            this.BtnDevamEdenTezler.TabIndex = 8;
            this.BtnDevamEdenTezler.Text = "DEVAM EDEN TEZLER";
            this.BtnDevamEdenTezler.UseVisualStyleBackColor = true;
            this.BtnDevamEdenTezler.Click += new System.EventHandler(this.BtnDevamEdenTezler_Click);
            // 
            // BtnOlusmusTez
            // 
            this.BtnOlusmusTez.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnOlusmusTez.FlatAppearance.BorderSize = 0;
            this.BtnOlusmusTez.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnOlusmusTez.Font = new System.Drawing.Font("Courier New", 8.25F);
            this.BtnOlusmusTez.Location = new System.Drawing.Point(0, 59);
            this.BtnOlusmusTez.Name = "BtnOlusmusTez";
            this.BtnOlusmusTez.Size = new System.Drawing.Size(214, 59);
            this.BtnOlusmusTez.TabIndex = 2;
            this.BtnOlusmusTez.Text = "OLUŞTURULMUŞ TEZLER";
            this.BtnOlusmusTez.UseVisualStyleBackColor = true;
            this.BtnOlusmusTez.Click += new System.EventHandler(this.BtnOlusmusTez_Click);
            // 
            // BtnTezOlustur
            // 
            this.BtnTezOlustur.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnTezOlustur.FlatAppearance.BorderSize = 0;
            this.BtnTezOlustur.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnTezOlustur.Font = new System.Drawing.Font("Courier New", 8.25F);
            this.BtnTezOlustur.Location = new System.Drawing.Point(0, 0);
            this.BtnTezOlustur.Name = "BtnTezOlustur";
            this.BtnTezOlustur.Size = new System.Drawing.Size(214, 59);
            this.BtnTezOlustur.TabIndex = 1;
            this.BtnTezOlustur.Text = "TEZ OLUŞTUR";
            this.BtnTezOlustur.UseVisualStyleBackColor = true;
            this.BtnTezOlustur.Click += new System.EventHandler(this.BtnTezOlustur_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.LightSteelBlue;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.labeldanismansoyad);
            this.panel2.Controls.Add(this.labeldanismanbolum);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.labeldanismanad);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(214, 104);
            this.panel2.TabIndex = 1;
            // 
            // labeldanismansoyad
            // 
            this.labeldanismansoyad.AutoSize = true;
            this.labeldanismansoyad.Font = new System.Drawing.Font("Courier New", 8.25F);
            this.labeldanismansoyad.Location = new System.Drawing.Point(69, 44);
            this.labeldanismansoyad.Name = "labeldanismansoyad";
            this.labeldanismansoyad.Size = new System.Drawing.Size(126, 14);
            this.labeldanismansoyad.TabIndex = 3;
            this.labeldanismansoyad.Text = "DanışmanAdıSoyadı";
            // 
            // labeldanismanbolum
            // 
            this.labeldanismanbolum.AutoSize = true;
            this.labeldanismanbolum.Font = new System.Drawing.Font("Courier New", 7F);
            this.labeldanismanbolum.Location = new System.Drawing.Point(3, 72);
            this.labeldanismanbolum.Name = "labeldanismanbolum";
            this.labeldanismanbolum.Size = new System.Drawing.Size(71, 12);
            this.labeldanismanbolum.TabIndex = 2;
            this.labeldanismanbolum.Text = "DanışmBÖLÜM";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(54, 54);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // labeldanismanad
            // 
            this.labeldanismanad.AutoSize = true;
            this.labeldanismanad.Font = new System.Drawing.Font("Courier New", 8.25F);
            this.labeldanismanad.Location = new System.Drawing.Point(69, 21);
            this.labeldanismanad.Name = "labeldanismanad";
            this.labeldanismanad.Size = new System.Drawing.Size(126, 14);
            this.labeldanismanad.TabIndex = 0;
            this.labeldanismanad.Text = "DanışmanAdıSoyadı";
            // 
            // DanismanAnaSayfa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(846, 593);
            this.Controls.Add(this.panelChildForm);
            this.Controls.Add(this.panelmenu);
            this.Name = "DanismanAnaSayfa";
            this.Text = "DanismanAnaSayfa";
            this.Load += new System.EventHandler(this.DanismanAnaSayfa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tezBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uniTezDataSet1)).EndInit();
            this.panelChildForm.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panelmenu.ResumeLayout(false);
            this.panelalt.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private UniTezDataSet1 uniTezDataSet1;
        private System.Windows.Forms.BindingSource tezBindingSource;
        private UniTezDataSet1TableAdapters.TezTableAdapter tezTableAdapter;
        private System.Windows.Forms.Panel panelChildForm;
        private System.Windows.Forms.Panel panelmenu;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label labeldanismanbolum;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label labeltezsayisi;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labeldevamtezsayisi;
        public System.Windows.Forms.Label labeldanismanad;
        public System.Windows.Forms.Label labeldanismansoyad;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panelalt;
        private System.Windows.Forms.Button BtnOlusmusTez;
        private System.Windows.Forms.Button BtnTezOlustur;
        private System.Windows.Forms.Button BtnBilgilerim;
        private System.Windows.Forms.Button BtnTezOnerileri;
        private System.Windows.Forms.Button BtnTezBasvurulari;
        private System.Windows.Forms.Button BtnDevamEdenTezler;
    }
}