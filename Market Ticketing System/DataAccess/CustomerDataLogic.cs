using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Market_Ticketing_System.User_Interfaces
{
    class CustomerDataLogic
    {
        public DataTable GetCustomerList()
        {
            DataTable dataTable = new DataTable();

            try
            {
                using (SqlConnection connection = new SqlConnection(Helper.Helper.ConnectionString))
                {
                    //Write Select QUERY 
                    string query = $"SELECT [CustomerId], [CustomerName], [PhoneNumber], [Fax], [Email], [ContactPersonNameAdmin], [ContactPersonEmailAdmin], [ContactPersonPhoneAdmin], [ContactPersonMobileAdmin], [ContactPersonNameIT], [ContactPersonMobileIT], [ContactPersonEmailIT], [ContactPersonPhoneIT], [Address], [IsActive], [IsSystemGenerated] FROM Customer ORDER BY [CustomerId] ASC";
                    //create sql Command using above and connection above 
                    SqlCommand sqlcommand = new SqlCommand(query, connection);
                    //create a sql data adapter 
                    SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlcommand);
                    //Connection Open 
                    connection.Open();
                    //use adapter to fill the table 
                    sqlDataAdapter.Fill(dataTable);
                    //close the connection 
                    connection.Close();
                    return dataTable;

                }
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }
        
        public bool AddCustomer(string customerName, string phoneno, string fax, string email, string address, bool isActive, string adminname, string adminemail, string adminphone, string adminmobile, string ITname, string ITmobile, string ITemail, string ITphone, bool isSystemGenerated)
        {
            using (SqlConnection connection = new SqlConnection(Helper.Helper.ConnectionString))
            {​​​​
                //Write Select QUERY
                string query = $"INSERT INTO [dbo].[Customer] ([CustomerName], [PhoneNumber], [Fax], [Email], [ContactPersonNameAdmin], [ContactPersonEmailAdmin], [ContactPersonPhoneAdmin], [ContactPersonMobileAdmin], [ContactPersonNameIT], [ContactPersonMobileIT], [ContactPersonEmailIT], [ContactPersonPhoneIT], [Address], [IsActive], [IsSystemGenerated])" +
                $"VALUES" +
                $"(@CustomerName ,@PhoneNumber ,@Fax ,@Email ,@ContactPersonNameAdmin ,@ContactPersonEmailAdmin ,@ContactPersonPhoneAdmin ,@ContactPersonMobileAdmin ,@ContactPersonNameIT ,@ContatPersonMobileIT, @ContactPersonEmailIT ,@ContactPersonPhoneIT ,@Address ,@IsActive ,@IsSystemGenerated)";
                SqlCommand sqlCommand = new SqlCommand(query, connection);
                sqlCommand.Parameters.AddWithValue("@CustomerName", customerName);
                sqlCommand.Parameters.AddWithValue("@PhoneNumber", phoneno);
                sqlCommand.Parameters.AddWithValue("@Fax", fax);
                sqlCommand.Parameters.AddWithValue("@Email", email);
                sqlCommand.Parameters.AddWithValue("@Address", address);
                sqlCommand.Parameters.AddWithValue("@IsActive", isActive);
                sqlCommand.Parameters.AddWithValue("@ContactPersonNameAdmin ", adminname);
                sqlCommand.Parameters.AddWithValue("@ContactPersonEmailAdmin", adminemail);
                sqlCommand.Parameters.AddWithValue("@ContactPersonPhoneAdmin", adminphone);
                sqlCommand.Parameters.AddWithValue("@ContactPersonMobileAdmin", adminmobile);
                sqlCommand.Parameters.AddWithValue("@ContactPersonNameIT", ITname);
                sqlCommand.Parameters.AddWithValue("@ContatPersonMobileIT", ITmobile);
                sqlCommand.Parameters.AddWithValue("@ContactPersonPhoneIT", ITphone);
                sqlCommand.Parameters.AddWithValue("@ContactPersonEmailIT", ITemail);
                sqlCommand.Parameters.AddWithValue("@IsSystemGenerated", isSystemGenerated);
                connection.Open();
                int rows = sqlCommand.ExecuteNonQuery();
                connection.Close();
                if (rows == 1)
                {​​​​
                    return true;
                }​​​​
                else
                {​​​​
                    return false;
                }​​​​
            }​​​​
        }

        public bool GetCustomerInfo(int customerId, out string customerName, out string phoneno, out string fax, out string email, out string address, out bool isActive, out string adminname, out string adminemail, out string adminphone, out string adminmobile, out string ITname, out string ITmobile, out string ITemail, out string ITphone, out bool isSystemGenerated)
        {
            //string _customerName, _phoneno, _fax, _email, _address, _isActive, _adminname, _adminemail, _adminphone, _adminmobile, _ITname, _ITmobile, _ITemail, _ITphone, _isSystemGenerated;
            DataTable dataTable = new DataTable();
            try
            {
                using (SqlConnection connection = new SqlConnection(Helper.Helper.ConnectionString))
                {
                    string query = $"SELECT  [CustomerId], [CustomerName], [PhoneNumber], [Fax], [Email], [ContactPersonNameAdmin], [ContactPersonEmailAdmin], [ContactPersonPhoneAdmin], [ContactPersonMobileAdmin], [ContactPersonNameIT], [ContactPersonMobileIT], [ContactPersonEmailIT], [ContactPersonPhoneIT], [Address], [IsActive], [IsSystemGenerated]" +
                                   $"FROM Customer Where CustomerId=@customerId";
                    SqlCommand sqlcommand = new SqlCommand(query, connection);
                    sqlcommand.Parameters.AddWithValue("@customerId", customerId);
                    SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlcommand);
                    connection.Open();
                    sqlDataAdapter.Fill(dataTable);
                    connection.Close();



                    if (dataTable.Rows.Count == 1)
                    {
                        customerName = dataTable.Rows[0]["CustomerName"].ToString();
                        phoneno = dataTable.Rows[0]["PhoneNumber"].ToString();
                        fax = dataTable.Rows[0]["Fax"].ToString();
                        email = dataTable.Rows[0]["E-mail"].ToString();
                        address = dataTable.Rows[0]["Address"].ToString();
                        isActive = bool.Parse(dataTable.Rows[0]["IsActive"].ToString());
                        adminname = dataTable.Rows[0]["ContactPersonNameAdmin"].ToString();
                        adminemail = dataTable.Rows[0]["ContactPersonEmailAdmin"].ToString();
                        adminphone = dataTable.Rows[0]["ContactPersonPhoneAdmin."].ToString();
                        adminmobile = dataTable.Rows[0]["ContactPersonMobileAdmin."].ToString();
                        ITname = dataTable.Rows[0]["ContactPersonNameIT"].ToString();
                        ITmobile = dataTable.Rows[0]["ContactPersonMobileIT."].ToString();
                        ITemail = dataTable.Rows[0]["ContactPersonEmailIT"].ToString();
                        ITphone = dataTable.Rows[0]["ContactPersonPhoneIT."].ToString();
                        isSystemGenerated = bool.Parse(dataTable.Rows[0]["IsSystemGenerated"].ToString());
                        return true;
                    }
                    else
                    {
                        customerName = string.Empty;
                        phoneno = string.Empty;
                        fax = string.Empty;
                        email = string.Empty;
                        address = string.Empty;
                        isActive = false;
                        adminname = string.Empty;
                        adminemail = string.Empty;
                        adminphone = string.Empty;
                        adminmobile = string.Empty;
                        ITname = string.Empty;
                        ITmobile = string.Empty;
                        ITemail = string.Empty;
                        ITphone = string.Empty;
                        isSystemGenerated = false;
                        return false;
                    }
                }
            }
            catch (Exception ex)
            {



                throw ex;
            }
        }



        public bool UpdateCustomer(int customerId, string customerName, string phoneno, string fax, string email, string address, bool isActive, string adminname, string adminemail, string adminphone, string adminmobile, string ITname, string ITmobile, string ITemail, string ITphone, bool isSystemGenerated)
        {
            using (SqlConnection sqlconnection = new SqlConnection(Helper.Helper.ConnectionString))
            {
                string query = $"Update [dbo].[Customer] Set [CustomerName]=@CustomerName ,[PhoneNumber]=@PhoneNumber ,[Fax]=@Fax ,[E-mail]=@Email ,[IsActive]=@IsActive ,[ContactPersonNameAdmin]=@AdminName ,[ContactPersonEmailAdmin]=@AdminEmail ,[ContactPersonPhoneAdmin]=@AdminPhone ,[ContactPersonMobileAdmin]=@AdminMobile ," +
                    $"[ContactPersonNameIT]=@ITName ,[ContactPersonMobileIT]=@ITMobile ,[ContactPersonEmailIT]=@ITEmail ,[ContactPersonPhoneIT]=@ITPhone ,[Address]=@Address ,[IsSystemGenerated]=@IsSystemGenerated Where CustomerId=@customerId";
                SqlCommand sqlCommand = new SqlCommand(query, sqlconnection);
                sqlCommand.Parameters.AddWithValue("@CustomerName", customerName);
                sqlCommand.Parameters.AddWithValue("@PhoneNumber", phoneno);
                sqlCommand.Parameters.AddWithValue("@Fax", fax);
                sqlCommand.Parameters.AddWithValue("@Email", email);
                sqlCommand.Parameters.AddWithValue("@Address", address);
                sqlCommand.Parameters.AddWithValue("@IsActive", isActive);
                sqlCommand.Parameters.AddWithValue("@ContactPersonNameAdmin", adminname);
                sqlCommand.Parameters.AddWithValue("@ContactPersonEmailAdmin", adminemail);
                sqlCommand.Parameters.AddWithValue("@ContactPersonPhoneAdmin", adminphone);
                sqlCommand.Parameters.AddWithValue("@ContactPersonMobileAdmin", adminmobile);
                sqlCommand.Parameters.AddWithValue("@ContactPersonNameIT", ITname);
                sqlCommand.Parameters.AddWithValue("@ContactPersonMobileIT", ITmobile);
                sqlCommand.Parameters.AddWithValue("@ContactPersonEmailIT", ITemail);
                sqlCommand.Parameters.AddWithValue("@ContactPersonPhoneIT", ITphone);
                sqlCommand.Parameters.AddWithValue("@IsSystemGenerated", isSystemGenerated);
                sqlCommand.Parameters.AddWithValue("@customerId", customerId);
                sqlconnection.Open();
                int rows = sqlCommand.ExecuteNonQuery();
                sqlconnection.Close();
                if (rows == 1)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }
    }
}
