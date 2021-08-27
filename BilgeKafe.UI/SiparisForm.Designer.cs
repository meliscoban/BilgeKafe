
namespace BilgeKafe.UI
{
    partial class SiparisForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnDetayEkle = new System.Windows.Forms.Button();
            this.dgvSiparisDetaylari = new System.Windows.Forms.DataGridView();
            this.nudAdet = new System.Windows.Forms.NumericUpDown();
            this.cboUrun = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cboMasaNo = new System.Windows.Forms.ComboBox();
            this.btnMasaTasi = new System.Windows.Forms.Button();
            this.lblMasaNo = new System.Windows.Forms.Label();
            this.btnSiparisTutar = new System.Windows.Forms.Button();
            this.btnOdemeAl = new System.Windows.Forms.Button();
            this.btnAnaSayfa = new System.Windows.Forms.Button();
            this.lblOdemeTutari = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSiparisDetaylari)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudAdet)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ürün";
            // 
            // btnDetayEkle
            // 
            this.btnDetayEkle.Location = new System.Drawing.Point(364, 31);
            this.btnDetayEkle.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnDetayEkle.Name = "btnDetayEkle";
            this.btnDetayEkle.Size = new System.Drawing.Size(127, 28);
            this.btnDetayEkle.TabIndex = 1;
            this.btnDetayEkle.Text = "EKLE";
            this.btnDetayEkle.UseVisualStyleBackColor = true;
            // 
            // dgvSiparisDetaylari
            // 
            this.dgvSiparisDetaylari.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvSiparisDetaylari.BackgroundColor = System.Drawing.Color.White;
            this.dgvSiparisDetaylari.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSiparisDetaylari.Location = new System.Drawing.Point(17, 71);
            this.dgvSiparisDetaylari.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvSiparisDetaylari.Name = "dgvSiparisDetaylari";
            this.dgvSiparisDetaylari.Size = new System.Drawing.Size(474, 476);
            this.dgvSiparisDetaylari.TabIndex = 2;
            // 
            // nudAdet
            // 
            this.nudAdet.Location = new System.Drawing.Point(241, 33);
            this.nudAdet.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.nudAdet.Name = "nudAdet";
            this.nudAdet.Size = new System.Drawing.Size(105, 28);
            this.nudAdet.TabIndex = 3;
            // 
            // cboUrun
            // 
            this.cboUrun.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboUrun.FormattingEnabled = true;
            this.cboUrun.Location = new System.Drawing.Point(17, 34);
            this.cboUrun.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cboUrun.Name = "cboUrun";
            this.cboUrun.Size = new System.Drawing.Size(203, 27);
            this.cboUrun.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(237, 9);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 19);
            this.label2.TabIndex = 5;
            this.label2.Text = "Adet";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(513, 9);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 19);
            this.label3.TabIndex = 6;
            this.label3.Text = "Masa No:";
            // 
            // cboMasaNo
            // 
            this.cboMasaNo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cboMasaNo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboMasaNo.FormattingEnabled = true;
            this.cboMasaNo.Location = new System.Drawing.Point(517, 33);
            this.cboMasaNo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cboMasaNo.Name = "cboMasaNo";
            this.cboMasaNo.Size = new System.Drawing.Size(120, 27);
            this.cboMasaNo.TabIndex = 7;
            // 
            // btnMasaTasi
            // 
            this.btnMasaTasi.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMasaTasi.Location = new System.Drawing.Point(645, 33);
            this.btnMasaTasi.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnMasaTasi.Name = "btnMasaTasi";
            this.btnMasaTasi.Size = new System.Drawing.Size(127, 28);
            this.btnMasaTasi.TabIndex = 8;
            this.btnMasaTasi.Text = "TAŞI";
            this.btnMasaTasi.UseVisualStyleBackColor = true;
            // 
            // lblMasaNo
            // 
            this.lblMasaNo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblMasaNo.BackColor = System.Drawing.Color.Khaki;
            this.lblMasaNo.Font = new System.Drawing.Font("Microsoft New Tai Lue", 80F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblMasaNo.ForeColor = System.Drawing.Color.Black;
            this.lblMasaNo.Location = new System.Drawing.Point(517, 71);
            this.lblMasaNo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMasaNo.Name = "lblMasaNo";
            this.lblMasaNo.Size = new System.Drawing.Size(254, 194);
            this.lblMasaNo.TabIndex = 9;
            this.lblMasaNo.Text = "03";
            this.lblMasaNo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnSiparisTutar
            // 
            this.btnSiparisTutar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSiparisTutar.BackColor = System.Drawing.Color.PeachPuff;
            this.btnSiparisTutar.Location = new System.Drawing.Point(517, 392);
            this.btnSiparisTutar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSiparisTutar.Name = "btnSiparisTutar";
            this.btnSiparisTutar.Size = new System.Drawing.Size(124, 75);
            this.btnSiparisTutar.TabIndex = 10;
            this.btnSiparisTutar.Text = "SİPARİŞ İPTAL";
            this.btnSiparisTutar.UseVisualStyleBackColor = false;
            // 
            // btnOdemeAl
            // 
            this.btnOdemeAl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOdemeAl.BackColor = System.Drawing.Color.PowderBlue;
            this.btnOdemeAl.Location = new System.Drawing.Point(648, 392);
            this.btnOdemeAl.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnOdemeAl.Name = "btnOdemeAl";
            this.btnOdemeAl.Size = new System.Drawing.Size(124, 75);
            this.btnOdemeAl.TabIndex = 11;
            this.btnOdemeAl.Text = "ÖDEME AL";
            this.btnOdemeAl.UseVisualStyleBackColor = false;
            // 
            // btnAnaSayfa
            // 
            this.btnAnaSayfa.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAnaSayfa.BackColor = System.Drawing.Color.Thistle;
            this.btnAnaSayfa.Location = new System.Drawing.Point(518, 472);
            this.btnAnaSayfa.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAnaSayfa.Name = "btnAnaSayfa";
            this.btnAnaSayfa.Size = new System.Drawing.Size(254, 75);
            this.btnAnaSayfa.TabIndex = 12;
            this.btnAnaSayfa.Text = "ANA SAYFAYA DÖN";
            this.btnAnaSayfa.UseVisualStyleBackColor = false;
            // 
            // lblOdemeTutari
            // 
            this.lblOdemeTutari.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblOdemeTutari.AutoSize = true;
            this.lblOdemeTutari.Font = new System.Drawing.Font("Microsoft New Tai Lue", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblOdemeTutari.Location = new System.Drawing.Point(685, 323);
            this.lblOdemeTutari.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblOdemeTutari.Name = "lblOdemeTutari";
            this.lblOdemeTutari.Size = new System.Drawing.Size(32, 19);
            this.lblOdemeTutari.TabIndex = 13;
            this.lblOdemeTutari.Text = "0 ₺";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft New Tai Lue", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(567, 323);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(110, 19);
            this.label6.TabIndex = 14;
            this.label6.Text = "Ödeme Tutarı";
            // 
            // SiparisForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lblOdemeTutari);
            this.Controls.Add(this.btnAnaSayfa);
            this.Controls.Add(this.btnOdemeAl);
            this.Controls.Add(this.btnSiparisTutar);
            this.Controls.Add(this.lblMasaNo);
            this.Controls.Add(this.btnMasaTasi);
            this.Controls.Add(this.cboMasaNo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cboUrun);
            this.Controls.Add(this.nudAdet);
            this.Controls.Add(this.dgvSiparisDetaylari);
            this.Controls.Add(this.btnDetayEkle);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft New Tai Lue", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "SiparisForm";
            this.Text = "Masa 3";
            ((System.ComponentModel.ISupportInitialize)(this.dgvSiparisDetaylari)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudAdet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnDetayEkle;
        private System.Windows.Forms.DataGridView dgvSiparisDetaylari;
        private System.Windows.Forms.NumericUpDown nudAdet;
        private System.Windows.Forms.ComboBox cboUrun;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cboMasaNo;
        private System.Windows.Forms.Button btnMasaTasi;
        private System.Windows.Forms.Label lblMasaNo;
        private System.Windows.Forms.Button btnSiparisTutar;
        private System.Windows.Forms.Button btnOdemeAl;
        private System.Windows.Forms.Button btnAnaSayfa;
        private System.Windows.Forms.Label lblOdemeTutari;
        private System.Windows.Forms.Label label6;
    }
}