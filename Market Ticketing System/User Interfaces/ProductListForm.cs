using Market_Ticketing_System.DataAccess;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Market_Ticketing_System.User_Interfaces
{
	public partial class ProductListForm : Form
	{
		public ProductListForm()
		{
			InitializeComponent();
		}

		private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			//ProductDataLogic productDataLogic = new ProductDataLogic();
			//DataTable dataTable = new DataTable();
			//dataTable = productDataLogic.GetProductList();
			//dataGridViewProductList.DataSource = dataTable;
			int rowIndex = e.RowIndex;
			int productId = int.Parse(dataGridViewProductList.Rows[rowIndex].Cells[0].ToString());
			


		}

		private void ProductListForm_Load(object sender, EventArgs e)
		{
			ProductDataLogic productDataLogic = new ProductDataLogic();
			DataTable dataTable = new DataTable();
			dataTable = productDataLogic.GetProductList();
			dataGridViewProductList.DataSource = dataTable;
			this.ControlBox = false;
		}

		private void Back_Click(object sender, EventArgs e)
		{
			this.Close();
			
		}

		private void Add_Click(object sender, EventArgs e)
		{
			ProductForm productForm = new ProductForm();
			this.Hide();
			productForm.Show();
		}
	}
}
