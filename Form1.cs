using System;
using System.Windows.Forms;

namespace AdisyonUygulamasi
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent(); 
		}

		private void btnGarson_Click(object sender, EventArgs e)
		{
			GarsonForm garsonForm = new GarsonForm(); 
			garsonForm.Show();
		}

		private void btnMutfak_Click(object sender, EventArgs e)
		{
			MutfakForm mutfakForm = new MutfakForm(); 
			mutfakForm.Show();
		}

		private void btnKasa_Click(object sender, EventArgs e)
		{
			KasaForm kasaForm = new KasaForm();
			kasaForm.Show();
		}
	}
}
