
namespace UniTez
{
    partial class Ogr_TezBasvur
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
            this.datatezacik = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtTezAdi = new System.Windows.Forms.TextBox();
            this.BtnBasvur = new System.Windows.Forms.Button();
            this.labelid = new System.Windows.Forms.Label();
            this.labelogr = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cmdanisman = new System.Windows.Forms.ComboBox();
            this.cbbolum = new System.Windows.Forms.ComboBox();
            this.labelbolum = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.datatezacik)).BeginInit();
            this.SuspendLayout();
            // 
            // datatezacik
            // 
            this.datatezacik.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(225)))), ((int)(((byte)(158)))));
            this.datatezacik.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datatezacik.Location = new System.Drawing.Point(9, 224);
            this.datatezacik.Name = "datatezacik";
            this.datatezacik.Size = new System.Drawing.Size(599, 318);
            this.datatezacik.TabIndex = 0;
            this.datatezacik.SelectionChanged += new System.EventHandler(this.datatezacik_SelectionChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Courier New", 10F);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(64, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tez Adı:";
            // 
            // TxtTezAdi
            // 
            this.TxtTezAdi.Font = new System.Drawing.Font("Courier New", 15F);
            this.TxtTezAdi.Location = new System.Drawing.Point(157, 25);
            this.TxtTezAdi.Name = "TxtTezAdi";
            this.TxtTezAdi.Size = new System.Drawing.Size(390, 30);
            this.TxtTezAdi.TabIndex = 3;
            // 
            // BtnBasvur
            // 
            this.BtnBasvur.AutoEllipsis = true;
            this.BtnBasvur.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(225)))), ((int)(((byte)(158)))));
            this.BtnBasvur.Font = new System.Drawing.Font("Courier New", 8.25F);
            this.BtnBasvur.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BtnBasvur.Location = new System.Drawing.Point(243, 167);
            this.BtnBasvur.Name = "BtnBasvur";
            this.BtnBasvur.Size = new System.Drawing.Size(156, 41);
            this.BtnBasvur.TabIndex = 4;
            this.BtnBasvur.Text = "Başvur";
            this.BtnBasvur.UseVisualStyleBackColor = false;
            this.BtnBasvur.Click += new System.EventHandler(this.BtnBasvur_Click);
            // 
            // labelid
            // 
            this.labelid.AutoSize = true;
            this.labelid.Location = new System.Drawing.Point(12, 137);
            this.labelid.Name = "labelid";
            this.labelid.Size = new System.Drawing.Size(49, 13);
            this.labelid.TabIndex = 5;
            this.labelid.Text = "labetezid";
            this.labelid.Visible = false;
            // 
            // labelogr
            // 
            this.labelogr.AutoSize = true;
            this.labelogr.Location = new System.Drawing.Point(12, 154);
            this.labelogr.Name = "labelogr";
            this.labelogr.Size = new System.Drawing.Size(44, 13);
            this.labelogr.TabIndex = 6;
            this.labelogr.Text = "labelogr";
            this.labelogr.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Courier New", 10F);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label4.Location = new System.Drawing.Point(64, 118);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "Bölüm : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Courier New", 10F);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label3.Location = new System.Drawing.Point(64, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Danışman :";
            // 
            // cmdanisman
            // 
            this.cmdanisman.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmdanisman.FormattingEnabled = true;
            this.cmdanisman.Location = new System.Drawing.Point(157, 65);
            this.cmdanisman.Name = "cmdanisman";
            this.cmdanisman.Size = new System.Drawing.Size(390, 33);
            this.cmdanisman.TabIndex = 11;
            // 
            // cbbolum
            // 
            this.cbbolum.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cbbolum.FormattingEnabled = true;
            this.cbbolum.Location = new System.Drawing.Point(157, 107);
            this.cbbolum.Name = "cbbolum";
            this.cbbolum.Size = new System.Drawing.Size(390, 33);
            this.cbbolum.TabIndex = 12;
            // 
            // labelbolum
            // 
            this.labelbolum.AutoSize = true;
            this.labelbolum.Location = new System.Drawing.Point(4, 167);
            this.labelbolum.Name = "labelbolum";
            this.labelbolum.Size = new System.Drawing.Size(57, 13);
            this.labelbolum.TabIndex = 13;
            this.labelbolum.Text = "labelbolum";
            this.labelbolum.Visible = false;
            // 
            // Ogr_TezBasvur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(247)))), ((int)(((byte)(238)))));
            this.ClientSize = new System.Drawing.Size(617, 554);
            this.Controls.Add(this.labelbolum);
            this.Controls.Add(this.cbbolum);
            this.Controls.Add(this.cmdanisman);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.labelogr);
            this.Controls.Add(this.labelid);
            this.Controls.Add(this.BtnBasvur);
            this.Controls.Add(this.TxtTezAdi);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.datatezacik);
            this.Name = "Ogr_TezBasvur";
            this.Text = "Ogr_TezBasvur";
            this.Load += new System.EventHandler(this.Ogr_TezBasvur_Load);
            ((System.ComponentModel.ISupportInitialize)(this.datatezacik)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView datatezacik;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtTezAdi;
        private System.Windows.Forms.Button BtnBasvur;
        private System.Windows.Forms.Label labelid;
        private System.Windows.Forms.Label labelogr;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmdanisman;
        private System.Windows.Forms.ComboBox cbbolum;
        private System.Windows.Forms.Label labelbolum;
    }
}