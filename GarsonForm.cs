using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace AdisyonUygulamasi
{
	public partial class GarsonForm : Form
	{
		private MySqlConnection connection;

		public GarsonForm()
		{
			InitializeComponent();
			

			connection = new MySqlConnection("Server=localhost;Database=AdisyonDB;Uid=root;Pwd=7H~:TD8muNk3Zin;");
			dgvSiparisler.AllowUserToAddRows = false; 
			dgvSiparisler.AutoGenerateColumns = false; 
			InitializeDataGridView();
		}

	

		private void InitializeDataGridView()
		{
		

			DataGridViewTextBoxColumn column1 = new DataGridViewTextBoxColumn();
			column1.HeaderText = "Ürün Adı";
			column1.DataPropertyName = "Name"; 
			dgvSiparisler.Columns.Add(column1);

		

			DataGridViewTextBoxColumn column2 = new DataGridViewTextBoxColumn();
			column2.HeaderText = "Adet";
			column2.DataPropertyName = "Quantity"; 
			dgvSiparisler.Columns.Add(column2);
		}

		

		private void btnKaydet_Click(object sender, EventArgs e)
		{
			if (string.IsNullOrEmpty(txtMasaNo.Text))
			{
				MessageBox.Show("Lütfen masa numarasını girin.");
				return;
			}

			int masaNo;
			if (int.TryParse(txtMasaNo.Text, out masaNo))
			{
				string urunAdi = txtUrunAdi.Text;
				int adet = (int)nudAdet.Value;

				if (string.IsNullOrEmpty(urunAdi) || adet <= 0)
				{
					MessageBox.Show("Lütfen geçerli bir ürün ve adet girin.");
					return;
				}


				SaveOrder(masaNo, urunAdi, adet);
				ClearOrderInputs();
				LoadOrdersForTable(masaNo);
			}
			else
			{
				MessageBox.Show("Geçerli bir masa numarası girin.");
			}
		}

	
		private void SaveOrder(int masaNo, string urunAdi, int adet)
		{
			try
			{
				connection.Open();

				
				string queryProduct = "SELECT ProductID FROM Products WHERE LOWER(Name) = LOWER(@urunAdi)";
				MySqlCommand cmdProduct = new MySqlCommand(queryProduct, connection);
				cmdProduct.Parameters.AddWithValue("@urunAdi", urunAdi);

				object productIdObj = cmdProduct.ExecuteScalar();
				if (productIdObj == null)
				{
					MessageBox.Show("Bu ürün veritabanında bulunamadı.");
					return;
				}

				int productId = Convert.ToInt32(productIdObj);


				string queryOrder = "INSERT INTO Orders (CustomerID, OrderDate, TableNumber) VALUES (NULL, NOW(), @masaNo); SELECT LAST_INSERT_ID();";
				MySqlCommand cmdOrder = new MySqlCommand(queryOrder, connection);
				cmdOrder.Parameters.AddWithValue("@masaNo", masaNo);
				int orderId = Convert.ToInt32(cmdOrder.ExecuteScalar());


				string queryOrderDetail = "INSERT INTO OrderDetails (OrderID, ProductID, Quantity) VALUES (@orderId, @productId, @quantity)";
				MySqlCommand cmdOrderDetail = new MySqlCommand(queryOrderDetail, connection);
				cmdOrderDetail.Parameters.AddWithValue("@orderId", orderId);
				cmdOrderDetail.Parameters.AddWithValue("@productId", productId);
				cmdOrderDetail.Parameters.AddWithValue("@quantity", adet);
				cmdOrderDetail.ExecuteNonQuery();

				MessageBox.Show("Sipariş kaydedildi.");
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

		private void ClearOrderInputs()
		{
			txtUrunAdi.Clear();
			nudAdet.Value = 1;
		}

		private void LoadOrdersForTable(int masaNo)
		{
			try
			{
				connection.Open();

				string query = @"SELECT p.Name, od.Quantity 
                                 FROM Orders o 
                                 JOIN OrderDetails od ON o.OrderID = od.OrderID 
                                 JOIN Products p ON od.ProductID = p.ProductID 
                                 WHERE o.TableNumber = @masaNo";
				MySqlCommand cmd = new MySqlCommand(query, connection);
				cmd.Parameters.AddWithValue("@masaNo", masaNo);
				MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
				DataTable dt = new DataTable();
				adapter.Fill(dt);


				if (dt.Rows.Count > 0)
				{
					dgvSiparisler.DataSource = dt;
				}
				else
				{
					dgvSiparisler.DataSource = null;
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
	}
}
