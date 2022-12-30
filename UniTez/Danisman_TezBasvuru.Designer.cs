
namespace UniTez
{
    partial class Danisman_TezBasvuru
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
            this.datagelenbasvurular = new System.Windows.Forms.DataGridView();
            this.txtTezAdi = new System.Windows.Forms.TextBox();
            this.BtnOnay = new System.Windows.Forms.Button();
            this.BtnRed = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.BtnKapat = new System.Windows.Forms.Button();
            this.labeldanismanid = new System.Windows.Forms.Label();
            this.labelogrenci = new System.Windows.Forms.Label();
            this.tezid = new System.Windows.Forms.Label();
            this.labelid = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.datagelenbasvurular)).BeginInit();
            this.SuspendLayout();
            // 
            // datagelenbasvurular
            // 
            this.datagelenbasvurular.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.datagelenbasvurular.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(243)))), ((int)(((byte)(239)))));
            this.datagelenbasvurular.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagelenbasvurular.Location = new System.Drawing.Point(19, 189);
            this.datagelenbasvurular.Name = "datagelenbasvurular";
            this.datagelenbasvurular.Size = new System.Drawing.Size(585, 353);
            this.datagelenbasvurular.TabIndex = 0;
            this.datagelenbasvurular.SelectionChanged += new System.EventHandler(this.datagelenbasvurular_SelectionChanged);
            // 
            // txtTezAdi
            // 
            this.txtTezAdi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtTezAdi.Location = new System.Drawing.Point(108, 82);
            this.txtTezAdi.Name = "txtTezAdi";
            this.txtTezAdi.Size = new System.Drawing.Size(422, 23);
            this.txtTezAdi.TabIndex = 2;
            // 
            // BtnOnay
            // 
            this.BtnOnay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(243)))), ((int)(((byte)(239)))));
            this.BtnOnay.Font = new System.Drawing.Font("Courier New", 8.25F);
            this.BtnOnay.Location = new System.Drawing.Point(197, 127);
            this.BtnOnay.Name = "BtnOnay";
            this.BtnOnay.Size = new System.Drawing.Size(132, 28);
            this.BtnOnay.TabIndex = 3;
            this.BtnOnay.Text = "Başvuruyu Onayla";
            this.BtnOnay.UseVisualStyleBackColor = false;
            this.BtnOnay.Click += new System.EventHandler(this.BtnOnay_Click);
            // 
            // BtnRed
            // 
            this.BtnRed.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(243)))), ((int)(((byte)(239)))));
            this.BtnRed.Font = new System.Drawing.Font("Courier New", 8.25F);
            this.BtnRed.Location = new System.Drawing.Point(358, 127);
            this.BtnRed.Name = "BtnRed";
            this.BtnRed.Size = new System.Drawing.Size(132, 28);
            this.BtnRed.TabIndex = 4;
            this.BtnRed.Text = "Başvuruyu Reddet";
            this.BtnRed.UseVisualStyleBackColor = false;
            this.BtnRed.Click += new System.EventHandler(this.BtnRed_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(105, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(374, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "başvuru reddederse durumu açık olarak kalacak ve başvuru listeden silinecek";
            // 
            // BtnKapat
            // 
            this.BtnKapat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnKapat.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(243)))), ((int)(((byte)(239)))));
            this.BtnKapat.Location = new System.Drawing.Point(587, 3);
            this.BtnKapat.Name = "BtnKapat";
            this.BtnKapat.Size = new System.Drawing.Size(26, 23);
            this.BtnKapat.TabIndex = 56;
            this.BtnKapat.Text = "x";
            this.BtnKapat.UseVisualStyleBackColor = true;
            this.BtnKapat.Click += new System.EventHandler(this.BtnKapat_Click);
            // 
            // labeldanismanid
            // 
            this.labeldanismanid.AutoSize = true;
            this.labeldanismanid.Location = new System.Drawing.Point(522, 29);
            this.labeldanismanid.Name = "labeldanismanid";
            this.labeldanismanid.Size = new System.Drawing.Size(82, 13);
            this.labeldanismanid.TabIndex = 57;
            this.labeldanismanid.Text = "labeldanismanid";
            this.labeldanismanid.Visible = false;
            // 
            // labelogrenci
            // 
            this.labelogrenci.AutoSize = true;
            this.labelogrenci.Location = new System.Drawing.Point(491, 13);
            this.labelogrenci.Name = "labelogrenci";
            this.labelogrenci.Size = new System.Drawing.Size(64, 13);
            this.labelogrenci.TabIndex = 58;
            this.labelogrenci.Text = "labelogrenci";
            this.labelogrenci.Visible = false;
            // 
            // tezid
            // 
            this.tezid.AutoSize = true;
            this.tezid.Location = new System.Drawing.Point(450, 13);
            this.tezid.Name = "tezid";
            this.tezid.Size = new System.Drawing.Size(51, 13);
            this.tezid.TabIndex = 59;
            this.tezid.Text = "labeltezid";
            this.tezid.Visible = false;
            // 
            // labelid
            // 
            this.labelid.AutoSize = true;
            this.labelid.Location = new System.Drawing.Point(568, 65);
            this.labelid.Name = "labelid";
            this.labelid.Size = new System.Drawing.Size(35, 13);
            this.labelid.TabIndex = 60;
            this.labelid.Text = "label1";
            // 
            // Danisman_TezBasvuru
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(616, 554);
            this.Controls.Add(this.labelid);
            this.Controls.Add(this.tezid);
            this.Controls.Add(this.labelogrenci);
            this.Controls.Add(this.labeldanismanid);
            this.Controls.Add(this.BtnKapat);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.BtnRed);
            this.Controls.Add(this.BtnOnay);
            this.Controls.Add(this.txtTezAdi);
            this.Controls.Add(this.datagelenbasvurular);
            this.Name = "Danisman_TezBasvuru";
            this.Text = "Danisman_TezBasvuru";
            this.Load += new System.EventHandler(this.Danisman_TezBasvuru_Load);
            ((System.ComponentModel.ISupportInitialize)(this.datagelenbasvurular)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView datagelenbasvurular;
        private System.Windows.Forms.TextBox txtTezAdi;
        private System.Windows.Forms.Button BtnOnay;
        private System.Windows.Forms.Button BtnRed;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button BtnKapat;
        public System.Windows.Forms.Label labeldanismanid;
        private System.Windows.Forms.Label labelogrenci;
        private System.Windows.Forms.Label tezid;
        private System.Windows.Forms.Label labelid;
    }
}