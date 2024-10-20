namespace AdisyonUygulamasi
{
	partial class Form1
	{
		private System.Windows.Forms.Button btnGarson;
		private System.Windows.Forms.Button btnMutfak;
		private System.Windows.Forms.Button btnKasa;

		private void InitializeComponent()
		{
			this.btnGarson = new System.Windows.Forms.Button();
			this.btnMutfak = new System.Windows.Forms.Button();
			this.btnKasa = new System.Windows.Forms.Button();

			// 
			// btnGarson
			// 
			this.btnGarson.Location = new System.Drawing.Point(50, 50);
			this.btnGarson.Name = "btnGarson";
			this.btnGarson.Size = new System.Drawing.Size(100, 50);
			this.btnGarson.TabIndex = 0;
			this.btnGarson.Text = "Garson";
			this.btnGarson.UseVisualStyleBackColor = true;
			this.btnGarson.Click += new System.EventHandler(this.btnGarson_Click);

			// 
			// btnMutfak
			// 
			this.btnMutfak.Location = new System.Drawing.Point(200, 50);
			this.btnMutfak.Name = "btnMutfak";
			this.btnMutfak.Size = new System.Drawing.Size(100, 50);
			this.btnMutfak.TabIndex = 1;
			this.btnMutfak.Text = "Mutfak";
			this.btnMutfak.UseVisualStyleBackColor = true;
			this.btnMutfak.Click += new System.EventHandler(this.btnMutfak_Click);

			// 
			// btnKasa
			// 
			this.btnKasa.Location = new System.Drawing.Point(350, 50);
			this.btnKasa.Name = "btnKasa";
			this.btnKasa.Size = new System.Drawing.Size(100, 50);
			this.btnKasa.TabIndex = 2;
			this.btnKasa.Text = "Kasa";
			this.btnKasa.UseVisualStyleBackColor = true;
			this.btnKasa.Click += new System.EventHandler(this.btnKasa_Click);

			// 
			// Form1
			// 
			this.ClientSize = new System.Drawing.Size(500, 150);
			this.Controls.Add(this.btnGarson);
			this.Controls.Add(this.btnMutfak);
			this.Controls.Add(this.btnKasa);
			this.Name = "Form1";
			this.Text = "Adisyon Uygulaması";
		}
	}
}
