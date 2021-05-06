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
    public partial class CustomerListForm : Form
    {
        public CustomerListForm()
        {
            InitializeComponent();
        }
        public string customerName = string.Empty;
        public string phoneno = string.Empty;
        public string fax = string.Empty;
        public string email = string.Empty;
        public string address = string.Empty;
        public string adminname = string.Empty;
        public string adminemail = string.Empty;
        public string adminphone = string.Empty;
        public string adminmobile = string.Empty;
        public string ITname = string.Empty;
        public string ITmobile = string.Empty;
        public string ITemail = string.Empty;
        public string ITphone = string.Empty;
        public bool isActive = true;
        public bool isSystemGenerated = false;

        private void customerlistform_Load(object sender, EventArgs e)
        {
            CustomerLogicData customerLogicData = new CustomerLogicData();
            DataTable dataTable = new DataTable();
            dataTable = customerLogicData.GetCustomerList();
            dataGridViewCustomerList.DataSource = dataTable;
            this.ControlBox = false;
        }

        private void buttonback_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonadd_Click(object sender, EventArgs e)
        {
            Customeraddform customeraddform = new Customeraddform();
            this.Hide();
            customeraddform.Show();
        }

        private void dataGridViewCustomerList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void dataGridViewCustomerList_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int rowIndex = e.RowIndex;
            int customerId = int.Parse(dataGridViewCustomerList.Rows[rowIndex].Cells[0].Value.ToString());
            CustomerDataLogic customerDataLogic = new CustomerDataLogic();
            bool result = customerDataLogic.GetCustomerInfo(customerId, out customerName, out phoneno, out fax, out email, out address, out isActive, out adminname, out adminemail, out adminphone, out adminmobile, out ITname, out ITmobile, out ITemail, out ITphone, out isSystemGenerated);
            if (result == true)
            {
                Customeraddform customerAddForm = new Customeraddform()
                {
                    MdiParent = this.Parent.FindForm()
                };
                customerAddForm.customerName = customerName;
                customerAddForm.phoneno = phoneno;
                customerAddForm.fax = fax;
                customerAddForm.email = email;
                customerAddForm.address = address;
                customerAddForm.isActive = isActive;
                customerAddForm.adminname = adminname;
                customerAddForm.adminemail = adminemail;
                customerAddForm.adminphone = adminphone;
                customerAddForm.adminmobile = adminmobile;
                customerAddForm.ITname = ITname;
                customerAddForm.ITmobile = ITmobile;
                customerAddForm.ITemail = ITemail;
                customerAddForm.ITphone = ITphone;
                customerAddForm.isSystemGenerated = isSystemGenerated;
                customerAddForm.customerId = customerId;
                this.Hide();
                customerAddForm.Show();
            }
            else
            {
                MessageBox.Show("No Valid Information Found!", "Error!");
            }
        }
    }
}
