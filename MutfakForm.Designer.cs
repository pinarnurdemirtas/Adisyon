namespace AdisyonUygulamasi
{
	partial class MutfakForm
	{
		private System.Windows.Forms.DataGridView dgvSiparisler;

		private void InitializeComponent()
		{
			this.dgvSiparisler = new System.Windows.Forms.DataGridView();
			((System.ComponentModel.ISupportInitialize)(this.dgvSiparisler)).BeginInit();
			this.SuspendLayout();

			// 
			// dgvSiparisler
			// 
			this.dgvSiparisler.AllowUserToAddRows = false;
			this.dgvSiparisler.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dgvSiparisler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvSiparisler.Location = new System.Drawing.Point(12, 12);
			this.dgvSiparisler.Name = "dgvSiparisler";
			this.dgvSiparisler.RowHeadersWidth = 51;
			this.dgvSiparisler.Size = new System.Drawing.Size(776, 426);
			this.dgvSiparisler.TabIndex = 0;
			this.dgvSiparisler.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSiparisler_CellContentClick);

			// 
			// MutfakForm
			// 
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.dgvSiparisler);
			this.Name = "MutfakForm";
			this.Text = "Mutfak Siparişleri";
			((System.ComponentModel.ISupportInitialize)(this.dgvSiparisler)).EndInit();
			this.ResumeLayout(false);
		}
	}
}
