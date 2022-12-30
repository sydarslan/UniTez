
namespace UniTez
{
    partial class Ogr_BitirmeTezim
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
            this.datatezim = new System.Windows.Forms.DataGridView();
            this.labelogr = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.datatezim)).BeginInit();
            this.SuspendLayout();
            // 
            // datatezim
            // 
            this.datatezim.AllowUserToAddRows = false;
            this.datatezim.AllowUserToDeleteRows = false;
            this.datatezim.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(243)))), ((int)(((byte)(239)))));
            this.datatezim.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datatezim.Location = new System.Drawing.Point(12, 176);
            this.datatezim.Name = "datatezim";
            this.datatezim.ReadOnly = true;
            this.datatezim.Size = new System.Drawing.Size(593, 292);
            this.datatezim.TabIndex = 0;
            // 
            // labelogr
            // 
            this.labelogr.AutoSize = true;
            this.labelogr.Location = new System.Drawing.Point(569, 13);
            this.labelogr.Name = "labelogr";
            this.labelogr.Size = new System.Drawing.Size(44, 13);
            this.labelogr.TabIndex = 1;
            this.labelogr.Text = "labelogr";
            this.labelogr.Visible = false;
            // 
            // Ogr_BitirmeTezim
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(247)))), ((int)(((byte)(238)))));
            this.ClientSize = new System.Drawing.Size(617, 554);
            this.Controls.Add(this.labelogr);
            this.Controls.Add(this.datatezim);
            this.Name = "Ogr_BitirmeTezim";
            this.Text = "Ogr_BitirmeTezim";
            this.Load += new System.EventHandler(this.Ogr_BitirmeTezim_Load);
            ((System.ComponentModel.ISupportInitialize)(this.datatezim)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView datatezim;
        private System.Windows.Forms.Label labelogr;
    }
}