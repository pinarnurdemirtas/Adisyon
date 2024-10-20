using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace AdisyonUygulamasi
{
	public partial class MutfakForm : Form
	{
		private MySqlConnection connection;

		public MutfakForm()
		{
			InitializeComponent();
			connection = new MySqlConnection("Server=localhost;Database=AdisyonDB;Uid=root;Pwd=7H~:TD8muNk3Zin;");
			LoadOrders(); 

		}

		private void LoadOrders()
		{
			try
			{
				connection.Open();
				string query = @"SELECT od.OrderDetailID, o.TableNumber, p.Name AS ProductName, od.Quantity 
                                 FROM OrderDetails od 
                                 JOIN Orders o ON od.OrderID = o.OrderID 
                                 JOIN Products p ON od.ProductID = p.ProductID 
                                 WHERE od.Quantity > 0 
                                 ORDER BY o.TableNumber";

				MySqlCommand cmd = new MySqlCommand(query, connection);
				MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
				DataTable dt = new DataTable();
				adapter.Fill(dt);
				dgvSiparisler.DataSource = dt;


				dgvSiparisler.Columns["TableNumber"].HeaderText = "Masa Numarası";
				dgvSiparisler.Columns["ProductName"].HeaderText = "Ürün Adı";
				dgvSiparisler.Columns["Quantity"].HeaderText = "Adet";

				

				dgvSiparisler.Columns["OrderDetailID"].Visible = false;

				

				DataGridViewButtonColumn btnColumn = new DataGridViewButtonColumn();
				btnColumn.HeaderText = "Gönder";
				btnColumn.Name = "Gönder";
				btnColumn.Text = "Gönderildi";
				btnColumn.UseColumnTextForButtonValue = true;
				dgvSiparisler.Columns.Add(btnColumn);
			}
			catch (Exception ex)
			{
				MessageBox.Show("Hata: " + ex.Message);
			}
			finally
			{
				connection.Close();
			}
		}

		private void dgvSiparisler_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			if (e.ColumnIndex == dgvSiparisler.Columns["Gönder"].Index)
			{
				if (e.RowIndex >= 0 && e.RowIndex < dgvSiparisler.Rows.Count)
				{
				

					int orderDetailID = Convert.ToInt32(dgvSiparisler.Rows[e.RowIndex].Cells["OrderDetailID"].Value);

				

					dgvSiparisler.Rows.RemoveAt(e.RowIndex);


				}
			}
		}
	}
}
