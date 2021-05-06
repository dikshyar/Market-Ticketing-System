using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Market_Ticketing_System.DataAccess
{
    class CustomerLogicData
    {
        private object isActive;

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
        public bool AddCustomer(string customerName, string phoneno, string fax, string email, string contactPersonNameAdmin, bool contactPersonEmailAdmin, string adminname, string adminemail, string adminphone, string adminmobile, string ITname, string ITmobile, string ITemail, string ITphone, bool isSystemGenerated)

        {​​​​

            using (SqlConnection connection = new SqlConnection(Helper.Helper.ConnectionString))

            {​​​​

                //Write Select QUERY

                string query = $"INSERT INTO [dbo].[Customer] ( [CustomerId], [CustomerName], [PhoneNumber], [Fax], [Email], [ContactPersonNameAdmin], [ContactPersonEmailAdmin], [ContactPersonPhoneAdmin], [ContactPersonMobileAdmin], [ContactPersonNameIT], [ContactPersonMobileIT], [ContactPersonEmailIT], [ContactPersonPhoneIT], [Address], [IsActive], [IsSystemGenerated])" +

                $"VALUES" +

                $"(@CustomerName ,@PhoneNumber ,@Fax ,@Email ,@ContactPersonNameAdmin ,@ContactPersonEmailAdmin ,@ContactPersonPhoneAdmin ,@ContactPersonMobileAdmin ,@ContactPersonNameIT ,@ContatPersonMobileIT, @ContactPersonEmailIT ,@ContactPersonPhoneIT ,@Address ,@IsActive ,@IsSystemGenerated)";

                SqlCommand sqlCommand = new SqlCommand(query, connection);

                sqlCommand.Parameters.AddWithValue("@CustomerName", customerName);

                sqlCommand.Parameters.AddWithValue("@PhoneNumber", phoneno);

                sqlCommand.Parameters.AddWithValue("@Fax", fax);

                sqlCommand.Parameters.AddWithValue("@Email", email);

                sqlCommand.Parameters.AddWithValue("@Address", adminname);

                sqlCommand.Parameters.AddWithValue("@IsActive", isActive);

                sqlCommand.Parameters.AddWithValue("@ContactPersonNameAdmin ", adminname);

                sqlCommand.Parameters.AddWithValue("@ContactPersonEmailAdmin", adminemail);

                sqlCommand.Parameters.AddWithValue("@ContactPersonPhoneAdmin", adminphone);

                sqlCommand.Parameters.AddWithValue("@ContactPersonMobileAdmin", adminmobile);

                sqlCommand.Parameters.AddWithValue("@ContactPersonNameIT", ITname);

                sqlCommand.Parameters.AddWithValue("@ContatPersonMobileIT", ITmobile);

                sqlCommand.Parameters.AddWithValue("@", ITemail);

                sqlCommand.Parameters.AddWithValue("@ITPhone", ITphone);

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

        }​​​​


        
      
    }
}
