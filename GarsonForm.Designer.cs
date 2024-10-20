namespace AdisyonUygulamasi
{
	partial class GarsonForm
	{
		private System.Windows.Forms.Label lblMasaNo;
		private System.Windows.Forms.TextBox txtMasaNo;
		private System.Windows.Forms.Label lblUrunAdi;
		private System.Windows.Forms.TextBox txtUrunAdi;
		private System.Windows.Forms.Label lblAdet;
		private System.Windows.Forms.NumericUpDown nudAdet;
		private System.Windows.Forms.Button btnKaydet;
		private System.Windows.Forms.DataGridView dgvSiparisler;

		private void InitializeComponent()
		{
			this.lblMasaNo = new System.Windows.Forms.Label();
			this.txtMasaNo = new System.Windows.Forms.TextBox();
			this.lblUrunAdi = new System.Windows.Forms.Label();
			this.txtUrunAdi = new System.Windows.Forms.TextBox();
			this.lblAdet = new System.Windows.Forms.Label();
			this.nudAdet = new System.Windows.Forms.NumericUpDown();
			this.btnKaydet = new System.Windows.Forms.Button();
			this.dgvSiparisler = new System.Windows.Forms.DataGridView();

			((System.ComponentModel.ISupportInitialize)(this.nudAdet)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dgvSiparisler)).BeginInit();

			// 
			// lblMasaNo
			// 
			this.lblMasaNo.AutoSize = true;
			this.lblMasaNo.Location = new System.Drawing.Point(12, 15);
			this.lblMasaNo.Name = "lblMasaNo";
			this.lblMasaNo.Size = new System.Drawing.Size(55, 13);
			this.lblMasaNo.TabIndex = 0;
			this.lblMasaNo.Text = "Masa No:";

			// 
			// txtMasaNo
			// 
			this.txtMasaNo.Location = new System.Drawing.Point(80, 12);
			this.txtMasaNo.Name = "txtMasaNo";
			this.txtMasaNo.Size = new System.Drawing.Size(100, 20);
			this.txtMasaNo.TabIndex = 1;

			// 
			// lblUrunAdi
			// 
			this.lblUrunAdi.AutoSize = true;
			this.lblUrunAdi.Location = new System.Drawing.Point(12, 50);
			this.lblUrunAdi.Name = "lblUrunAdi";
			this.lblUrunAdi.Size = new System.Drawing.Size(54, 13);
			this.lblUrunAdi.TabIndex = 2;
			this.lblUrunAdi.Text = "Ürün Adı:";

			// 
			// txtUrunAdi
			// 
			this.txtUrunAdi.Location = new System.Drawing.Point(80, 47);
			this.txtUrunAdi.Name = "txtUrunAdi";
			this.txtUrunAdi.Size = new System.Drawing.Size(150, 20);
			this.txtUrunAdi.TabIndex = 3;

			// 
			// lblAdet
			// 
			this.lblAdet.AutoSize = true;
			this.lblAdet.Location = new System.Drawing.Point(12, 85);
			this.lblAdet.Name = "lblAdet";
			this.lblAdet.Size = new System.Drawing.Size(32, 13);
			this.lblAdet.TabIndex = 4;
			this.lblAdet.Text = "Adet:";

			// 
			// nudAdet
			// 
			this.nudAdet.Location = new System.Drawing.Point(80, 83);
			this.nudAdet.Minimum = new decimal(new int[] {
			1,
			0,
			0,
			0});
			this.nudAdet.Name = "nudAdet";
			this.nudAdet.Size = new System.Drawing.Size(50, 20);
			this.nudAdet.TabIndex = 5;
			this.nudAdet.Value = new decimal(new int[] {
			1,
			0,
			0,
			0});

			// 
			// btnKaydet
			// 
			this.btnKaydet.Location = new System.Drawing.Point(80, 120);
			this.btnKaydet.Name = "btnKaydet";
			this.btnKaydet.Size = new System.Drawing.Size(100, 30);
			this.btnKaydet.TabIndex = 6;
			this.btnKaydet.Text = "Sipariş Kaydet";
			this.btnKaydet.UseVisualStyleBackColor = true;
			this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);

			// 
			// dgvSiparisler
			// 
			this.dgvSiparisler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvSiparisler.Location = new System.Drawing.Point(12, 170);
			this.dgvSiparisler.Name = "dgvSiparisler";
			this.dgvSiparisler.Size = new System.Drawing.Size(350, 150);
			this.dgvSiparisler.TabIndex = 7;

			// 
			// GarsonForm
			// 
			this.ClientSize = new System.Drawing.Size(380, 350);
			this.Controls.Add(this.dgvSiparisler);
			this.Controls.Add(this.btnKaydet);
			this.Controls.Add(this.nudAdet);
			this.Controls.Add(this.lblAdet);
			this.Controls.Add(this.txtUrunAdi);
			this.Controls.Add(this.lblUrunAdi);
			this.Controls.Add(this.txtMasaNo);
			this.Controls.Add(this.lblMasaNo);
			this.Name = "GarsonForm";
			this.Text = "Garson - Sipariş Girişi";

			((System.ComponentModel.ISupportInitialize)(this.nudAdet)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dgvSiparisler)).EndInit();
		}
	}
}
