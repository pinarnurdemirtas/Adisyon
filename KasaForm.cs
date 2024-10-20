using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace AdisyonUygulamasi
{
	public partial class KasaForm : Form
	{
		private MySqlConnection connection;

		public KasaForm()
		{
			InitializeComponent();
			connection = new MySqlConnection("Server=localhost;Database=AdisyonDB;Uid=root;Pwd=7H~:TD8muNk3Zin;");
			LoadTableButtons(); 
		}

		private void LoadTableButtons()
		{
			for (int tableNumber = 1; tableNumber <= 10; tableNumber++) 
			{
				Button btnTable = new Button
				{
					Text = "Masa " + tableNumber,
					Tag = tableNumber,
					Width = 80,
					Height = 40
				};
				btnTable.Click += BtnTable_Click; 
				flowLayoutPanelMasalar.Controls.Add(btnTable); 
			}
		}

		private void BtnTable_Click(object sender, EventArgs e)
		{
			Button clickedButton = sender as Button;
			int selectedTableNumber = (int)clickedButton.Tag;
			LoadOrdersForTable(selectedTableNumber);
		}

		private void LoadOrdersForTable(int tableNumber)
		{
			try
			{
				connection.Open();
				string query = @"SELECT od.OrderDetailID, p.Name AS ProductName, od.Quantity, p.Price, o.TableNumber
                         FROM OrderDetails od 
                         JOIN Orders o ON od.OrderID = o.OrderID 
                         JOIN Products p ON od.ProductID = p.ProductID 
                         WHERE o.TableNumber = @TableNumber 
                         ORDER BY od.OrderDetailID"; 

				MySqlCommand cmd = new MySqlCommand(query, connection);
				cmd.Parameters.AddWithValue("@TableNumber", tableNumber);
				MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
				DataTable dt = new DataTable();
				adapter.Fill(dt);

				if (dt.Rows.Count > 0)
				{
					dgvSiparisler.DataSource = dt;


					dgvSiparisler.Columns["OrderDetailID"].Visible = false; 
					dgvSiparisler.Columns["ProductName"].HeaderText = "Ürün Adı";
					dgvSiparisler.Columns["Quantity"].HeaderText = "Adet";
					dgvSiparisler.Columns["Price"].HeaderText = "Fiyat";
					dgvSiparisler.Columns["TableNumber"].Visible = false;
				}
				else
				{
					dgvSiparisler.DataSource = null; 
					MessageBox.Show("Bu masada hiç sipariş yok.");
				}
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


		private void btnOdemeYap_Click(object sender, EventArgs e)
		{
			if (dgvSiparisler.SelectedRows.Count > 0)
			{
				int selectedTableNumber = (int)dgvSiparisler.Rows[0].Cells["TableNumber"].Value;
				foreach (DataGridViewRow row in dgvSiparisler.SelectedRows)
				{
					int orderDetailID = Convert.ToInt32(row.Cells["OrderDetailID"].Value);
					DeleteOrder(orderDetailID);
				}
				MessageBox.Show("Ödeme yapıldı. Seçilen siparişler silindi.");
				LoadOrdersForTable(selectedTableNumber); 
			}
			else
			{
				MessageBox.Show("Silinecek sipariş seçiniz.");
			}
		}

		private void DeleteOrder(int orderDetailID)
		{
			try
			{
				connection.Open();
				string deleteQuery = "DELETE FROM OrderDetails WHERE OrderDetailID = @OrderDetailID";
				MySqlCommand cmd = new MySqlCommand(deleteQuery, connection);
				cmd.Parameters.AddWithValue("@OrderDetailID", orderDetailID);
				cmd.ExecuteNonQuery();
			}
			catch (Exception ex)
			{
				MessageBox.Show("Silme işlemi sırasında hata: " + ex.Message);
			}
			finally
			{
				connection.Close();
			}
		}
	}
}
