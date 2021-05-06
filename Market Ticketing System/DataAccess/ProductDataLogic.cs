using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Market_Ticketing_System.DataAccess
{
	public class ProductDataLogic
	{
		public DataTable GetProductList()
		{
			DataTable dataTable = new DataTable();

			try
			{
				using (SqlConnection connection = new SqlConnection(Helper.Helper.ConnectionString))
				{
					//Write Select QUERY
					string query = $"SELECT [ProjectId] ,[ProjectTitle] ,[ProjectDescription] ,[IsSystemGenerated] ,[IsActive] FROM Product ORDER BY ProjectId DESC";
					//create sql Command using query above and connection above
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
		public bool AddProduct(string productName, string description, bool isActive, bool isSystemGenerated)//Passing input
		{
			using (SqlConnection connection = new SqlConnection(Helper.Helper.ConnectionString))
			{
				//Write Select QUERY
				string query = $"INSERT INTO [dbo].[Product] ([IsSystemGenerated], [IsActive], [ProjectTitle], [ProjectDescription])" +
							   $"VALUES" +
							   $"(@IsSystemGenerated, @IsActive, @ProjectTitle, @ProjectDescription)";
				SqlCommand sqlCommand = new SqlCommand(query, connection);
				sqlCommand.Parameters.AddWithValue("@IsSystemGenerated", isSystemGenerated);
				sqlCommand.Parameters.AddWithValue("@IsActive", isActive);
				sqlCommand.Parameters.AddWithValue("ProjectTitle", productName);
				sqlCommand.Parameters.AddWithValue("@ProjectDescription", description);
				connection.Open();
				rows = sqlCommand.ExecuteNonQuery();
				connection.Close();
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

