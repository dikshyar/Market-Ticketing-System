using Market_Ticketing_System.User_Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Market_Ticketing_System
{
	public partial class DashboardForm : Form
	{
		public DashboardForm()
		{
			InitializeComponent();
		}

		private void exitToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.Close();
			Application.Exit();
		}

		private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
		{
			AboutForm aboutForm = new AboutForm();
			aboutForm.MdiParent = this;
			aboutForm.Show();
		}

		private void productToolStripMenuItem_Click(object sender, EventArgs e)
		{
			ProductListForm productListform = new ProductListForm();
			productListform.MdiParent = this;
			productListform.Show();
		}

        private void customerToolStripMenuItem_Click(object sender, EventArgs e)
        {
			CustomerListForm customerlistform = new CustomerListForm();
			customerlistform.MdiParent = this;
			customerlistform.Show();
        }
    }
}
