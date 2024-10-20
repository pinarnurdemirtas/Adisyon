namespace AdisyonUygulamasi
{
	partial class KasaForm
	{
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.DataGridView dgvSiparisler;
		private System.Windows.Forms.Button btnOdemeYap;
		private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelMasalar;

		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		private void InitializeComponent()
		{
			this.dgvSiparisler = new System.Windows.Forms.DataGridView();
			this.btnOdemeYap = new System.Windows.Forms.Button();
			this.flowLayoutPanelMasalar = new System.Windows.Forms.FlowLayoutPanel();
			((System.ComponentModel.ISupportInitialize)(this.dgvSiparisler)).BeginInit();
			this.SuspendLayout();

			// 
			// flowLayoutPanelMasalar
			// 
			this.flowLayoutPanelMasalar.Location = new System.Drawing.Point(12, 12);
			this.flowLayoutPanelMasalar.Name = "flowLayoutPanelMasalar";
			this.flowLayoutPanelMasalar.Size = new System.Drawing.Size(450, 100);
			this.flowLayoutPanelMasalar.TabIndex = 0;

			// 
			// dgvSiparisler
			// 
			this.dgvSiparisler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvSiparisler.Location = new System.Drawing.Point(12, 120);
			this.dgvSiparisler.Name = "dgvSiparisler";
			this.dgvSiparisler.Size = new System.Drawing.Size(450, 200);
			this.dgvSiparisler.TabIndex = 1;
			this.dgvSiparisler.AllowUserToAddRows = false;


			// 
			// btnOdemeYap
			// 
			this.btnOdemeYap.Location = new System.Drawing.Point(12, 330);
			this.btnOdemeYap.Name = "btnOdemeYap";
			this.btnOdemeYap.Size = new System.Drawing.Size(450, 30);
			this.btnOdemeYap.TabIndex = 2;
			this.btnOdemeYap.Text = "Ödeme Yap";
			this.btnOdemeYap.UseVisualStyleBackColor = true;
			this.btnOdemeYap.Click += new System.EventHandler(this.btnOdemeYap_Click);

			// 
			// KasaForm
			// 
			this.ClientSize = new System.Drawing.Size(480, 370);
			this.Controls.Add(this.btnOdemeYap);
			this.Controls.Add(this.dgvSiparisler);
			this.Controls.Add(this.flowLayoutPanelMasalar);
			this.Name = "KasaForm";
			this.Text = "Kasa - Siparişler ve Ödeme";
			((System.ComponentModel.ISupportInitialize)(this.dgvSiparisler)).EndInit();
			this.ResumeLayout(false);
		}
	}
}
