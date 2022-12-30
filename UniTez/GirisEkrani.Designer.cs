
namespace UniTez
{
    partial class GirisEkrani
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GirisEkrani));
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.LinkSifremiUnuttum = new System.Windows.Forms.LinkLabel();
            this.LinkUyeol = new System.Windows.Forms.LinkLabel();
            this.BtnGirisYap = new System.Windows.Forms.Button();
            this.TxtGirisSifre = new System.Windows.Forms.TextBox();
            this.TxtGirisMail = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Courier New", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(30, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(318, 31);
            this.label1.TabIndex = 1;
            this.label1.Text = "UniTez Giriş Ekranı";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(213)))), ((int)(((byte)(175)))));
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.LinkSifremiUnuttum);
            this.panel1.Controls.Add(this.LinkUyeol);
            this.panel1.Controls.Add(this.BtnGirisYap);
            this.panel1.Controls.Add(this.TxtGirisSifre);
            this.panel1.Controls.Add(this.TxtGirisMail);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(262, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(360, 461);
            this.panel1.TabIndex = 3;
            // 
            // LinkSifremiUnuttum
            // 
            this.LinkSifremiUnuttum.AutoSize = true;
            this.LinkSifremiUnuttum.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(213)))), ((int)(((byte)(175)))));
            this.LinkSifremiUnuttum.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Bold);
            this.LinkSifremiUnuttum.LinkColor = System.Drawing.Color.DarkSalmon;
            this.LinkSifremiUnuttum.Location = new System.Drawing.Point(40, 286);
            this.LinkSifremiUnuttum.Name = "LinkSifremiUnuttum";
            this.LinkSifremiUnuttum.Size = new System.Drawing.Size(112, 14);
            this.LinkSifremiUnuttum.TabIndex = 9;
            this.LinkSifremiUnuttum.TabStop = true;
            this.LinkSifremiUnuttum.Text = "şifremi unuttum";
            // 
            // LinkUyeol
            // 
            this.LinkUyeol.AutoSize = true;
            this.LinkUyeol.DisabledLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(82)))), ((int)(((byte)(84)))));
            this.LinkUyeol.Font = new System.Drawing.Font("Courier New", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.LinkUyeol.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(82)))), ((int)(((byte)(84)))));
            this.LinkUyeol.Location = new System.Drawing.Point(97, 389);
            this.LinkUyeol.Name = "LinkUyeol";
            this.LinkUyeol.Size = new System.Drawing.Size(203, 14);
            this.LinkUyeol.TabIndex = 8;
            this.LinkUyeol.TabStop = true;
            this.LinkUyeol.Text = "* Üye Değil Misiniz? Üye Ol.";
            this.LinkUyeol.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.LinkUyeol.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkUyeol_LinkClicked);
            // 
            // BtnGirisYap
            // 
            this.BtnGirisYap.AutoEllipsis = true;
            this.BtnGirisYap.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.BtnGirisYap.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnGirisYap.Location = new System.Drawing.Point(133, 332);
            this.BtnGirisYap.Name = "BtnGirisYap";
            this.BtnGirisYap.Size = new System.Drawing.Size(112, 36);
            this.BtnGirisYap.TabIndex = 7;
            this.BtnGirisYap.Text = "Giriş Yap";
            this.BtnGirisYap.UseVisualStyleBackColor = false;
            this.BtnGirisYap.Click += new System.EventHandler(this.BtnGirisYap_Click);
            // 
            // TxtGirisSifre
            // 
            this.TxtGirisSifre.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtGirisSifre.Location = new System.Drawing.Point(36, 243);
            this.TxtGirisSifre.Name = "TxtGirisSifre";
            this.TxtGirisSifre.PasswordChar = '*';
            this.TxtGirisSifre.Size = new System.Drawing.Size(294, 27);
            this.TxtGirisSifre.TabIndex = 6;
            this.TxtGirisSifre.Enter += new System.EventHandler(this.TxtGirisSifre_Enter);
            this.TxtGirisSifre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtGirisSifre_KeyPress);
            // 
            // TxtGirisMail
            // 
            this.TxtGirisMail.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtGirisMail.ForeColor = System.Drawing.SystemColors.WindowText;
            this.TxtGirisMail.Location = new System.Drawing.Point(36, 164);
            this.TxtGirisMail.Name = "TxtGirisMail";
            this.TxtGirisMail.Size = new System.Drawing.Size(294, 27);
            this.TxtGirisMail.TabIndex = 5;
            this.TxtGirisMail.Enter += new System.EventHandler(this.TxtGirisMail_Enter);
            this.TxtGirisMail.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtGirisMail_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Courier New", 10F);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label3.Location = new System.Drawing.Point(33, 223);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Şifre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Courier New", 10F);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(33, 144);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Email";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(265, 461);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Courier New", 19F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label4.Location = new System.Drawing.Point(84, 59);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(189, 30);
            this.label4.TabIndex = 10;
            this.label4.Text = "HOŞGELDİNİZ";
            // 
            // GirisEkrani
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(622, 461);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.Name = "GirisEkrani";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GirisEkrani";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.LinkLabel LinkSifremiUnuttum;
        private System.Windows.Forms.LinkLabel LinkUyeol;
        private System.Windows.Forms.Button BtnGirisYap;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        public System.Windows.Forms.TextBox TxtGirisSifre;
        public System.Windows.Forms.TextBox TxtGirisMail;
        private System.Windows.Forms.Label label4;
    }
}

