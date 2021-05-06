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
    public partial class Customeraddform : Form
    {
        public Customeraddform()
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
        public int customerId;


        
        private void buttonsave_Click(object sender, EventArgs e)
        {
            CustomerDataLogic customerDataLogic = new CustomerDataLogic();
            customerName = textBoxcustomername.Text.Trim();
            phoneno = textBoxphonenumber.Text.Trim();
            fax = textBoxfax.Text.Trim();
            email = textBoxemail.Text.Trim();
            address = textBoxaddress.Text.Trim();
            string dropdownvalue = comboBoxIsactive.SelectedValue.ToString();
            isActive = dropdownvalue == "0" ? false : true;
            adminname = textBoxcontactpersonnameadmin.Text.Trim();
            adminemail = textBoxcontactpersonemailadmin.Text.Trim();
            adminphone = textBoxcontactpersonphoneadmin.Text.Trim();
            adminmobile = textBoxcontactpersonmobileadmin.Text.Trim();
            ITname = textBoxcontactpersonnameit.Text.Trim();
            ITmobile = textBoxcontactpersonmobileit.Text.Trim();
            ITemail = textBoxcontactpersonemailit.Text.Trim();
            ITphone = textBoxcontactpersonphoneit.Text.Trim();
            bool result = customerDataLogic.AddCustomer(customerName, phoneno, fax, email, address, isActive, adminname, adminemail, adminphone, adminmobile, ITname, ITmobile, ITemail, ITphone, isSystemGenerated);
            if (result == true)
            {​​​​​​​​
                MessageBox.Show("Success!");
                CustomerListForm customerListForm = new CustomerListForm();
                this.Hide();
                customerListForm.Show();
            }​​​​​​​​
            else
            {​​​​​​​​
                MessageBox.Show("Error!");
            }
        }

        private void Customeraddform_Load_1(object sender, EventArgs e)
        {
            List<DropDownActivity> dropDownActivities = new List<DropDownActivity>();
            dropDownActivities.Add(new DropDownActivity()
            {​​​​​​​​
                Value = 1,
                Text = "Is Active"
            }​​​​​​​​);
            dropDownActivities.Add(new DropDownActivity()
            {​​​​​​​​
                Value = 0,
                Text = "Not Active"
            }​​​​​​​​);
            comboBoxIsactive.DataSource = dropDownActivities;
            comboBoxIsactive.DisplayMember = "Text";
            comboBoxIsactive.ValueMember = "Value";
            textBoxcustomername.Text = customerName;
            textBoxphonenumber.Text = phoneno;
            textBoxfax.Text = fax;
            textBoxemail.Text = email;
            textBoxaddress.Text = address;
            textBoxcontactpersonnameadmin.Text = adminname;
            textBoxcontactpersonemailadmin.Text = adminemail;
            textBoxcontactpersonphoneadmin.Text = adminphone;
            textBoxcontactpersonmobileadmin.Text = adminmobile;
            textBoxcontactpersonnameit.Text = ITname;
            textBoxcontactpersonmobileit.Text = ITmobile;
            textBoxcontactpersonemailit.Text = ITemail;
            textBoxcontactpersonphoneit.Text = ITphone;


            if (!string.IsNullOrEmpty(customerName))
            {​​​​​​​​
                buttonsave.Enabled = false;
            }​​​​​​​​
            else
            {​​​​​​​​
                buttonupdate.Enabled = false;
            }​​​​​​​​
        }

        private void buttonupdate_Click(object sender, EventArgs e)
        {
            CustomerDataLogic customerDataLogic = new CustomerDataLogic();
            customerName = textBoxcustomername.Text.Trim();
            phoneno = textBoxcustomername.Text.Trim();
            fax = textBoxfax.Text.Trim();
            email = textBoxemail.Text.Trim();
            address = textBoxaddress.Text.Trim();
            string dropdownvalue = comboBoxIsactive.SelectedValue.ToString();
            isActive = dropdownvalue == "0" ? false : true;
            adminname = textBoxcontactpersonnameadmin.Text.Trim();
            adminemail = textBoxcontactpersonemailadmin.Text.Trim();
            adminphone = textBoxcontactpersonphoneadmin.Text.Trim();
            adminmobile = textBoxcontactpersonmobileadmin.Text.Trim();
            ITname = textBoxcontactpersonnameit.Text.Trim();
            ITmobile = textBoxcontactpersonmobileit.Text.Trim();
            ITemail = textBoxcontactpersonemailit.Text.Trim();
            ITphone = textBoxcontactpersonphoneit.Text.Trim();
            bool result = customerDataLogic.UpdateCustomer(customerId, customerName, phoneno, fax, email, address, isActive, adminname, adminemail, adminphone, adminmobile, ITname, ITmobile, ITemail, ITphone, isSystemGenerated);
            if (result == true)
            {​​​​​​​​
                MessageBox.Show("Success!");
                CustomerListForm customerListForm = new CustomerListForm();
                this.Hide();
                customerListForm.Show();
            }​​​​​​​​
            else
            {​​​​​​​​
                MessageBox.Show("Error!");
            }​​​​​​​​
        }
    }
}
