using Market_Ticketing_System.DataAccess;
using Market_Ticketing_System.Helper;
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
	public partial class ProductForm : Form
	{
		public ProductForm()
		{
			InitializeComponent();
		}

		private string productName = string.Empty;
		private string productDescription = string.Empty;
		private bool isActive = true;
		private bool isSystemGenerated = false;
		private void ProductListCancelButton_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void ProductListSaveButton_Click(object sender, EventArgs e)
		{
			ProductDataLogic productDataLogic = new ProductDataLogic();
			productName = textBoxProductName.Text.Trim();
			productDescription = richTextBoxDescription.Text.Trim();
			string dropdownvalue = ProductListActivity.SelectedValue.ToString();
			isActive = dropdownvalue == "0" ? false : true;
			bool result = productDataLogic.AddProduct(productName, productDescription, isActive, isSystemGenerated);
			if (result==true)
			{
				MessageBox.Show("Success!Success!");
				ProductListForm productListForm = new ProductListForm();
				this.Hide();
				productListForm.Show();
			}
			else
			{
				MessageBox.Show("Error!Error!");
			}
		}

		private void ProductFormActivityList_SelectedIndexChanged(object sender, EventArgs e)
		{
			/*
			List<DropDownActivity> dropDownActivities = new List<DropDownActivity>();
			dropDownActivities.Add(new DropDownActivity()
			{
				Value = 1,
				Text="Is Active"
			});
			dropDownActivities.Add(new DropDownActivity()
			{
				Value = 0,
				Text = "Not Active"
			});

			ProductListActivity.DataSource = dropDownActivities;
			ProductListActivity.DisplayMember = "Text";
			ProductListActivity.ValueMember = "Value"; 

			*/

		}

		private void ProductForm_Load(object sender, EventArgs e)
		{
			List<DropDownActivity> dropDownActivities = new List<DropDownActivity>();
			dropDownActivities.Add(new DropDownActivity()
			{
				Value = 1,
				Text = "Yes"
			});
			dropDownActivities.Add(new DropDownActivity()
			{
				Value = 0,
				Text = "No"
			});

			ProductListActivity.DataSource = dropDownActivities;
			ProductListActivity.DisplayMember = "Text";
			ProductListActivity.ValueMember = "Value";


		}

		private void textBoxProductName_TextChanged(object sender, EventArgs e)
		{

		} 
	}
}
