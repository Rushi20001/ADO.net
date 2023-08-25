using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace ADO.net
{
    public class Program
    {
        static void Main(string[] args)
        {
           productType productType = new productType();
            productType.UpdateProductType();
            productType.DeleteProductType();
            productType.InsertProductType();
            productType.RetreiveProductType();

            Console.ReadKey();
           
        }
        
        public class productType
        {
            public void InsertProductType()
            {
                // Create connection string and assing to class
                SqlConnection sqlConnetion = new SqlConnection(ConfigurationManager.ConnectionStrings["sqlConnection"].ToString());

                // Generate Query
                string query = "Insert into ProductType values ('books')";
                // string query = "insertlookuptype";
                //Create Command
                SqlCommand cmd = new SqlCommand(query, sqlConnetion);
                //cmd.CommandType = System.Data.CommandType.StoredProcedure;
                //cmd.Parameters.Add("@lookupTypename", SqlDbType.VarChar).Value = "Added By SP";
                sqlConnetion.Open();
                int rowaffected = cmd.ExecuteNonQuery();

                sqlConnetion.Close();
            }
            public void RetreiveProductType()
            {
                SqlConnection sqlConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["sqlconnection"].ToString());
                string query = "select top 1 TypeName from ProductType";
                SqlCommand cmd = new SqlCommand(query, sqlConnection);
                sqlConnection.Open();
                string row = Convert.ToString(cmd.ExecuteScalar());
                sqlConnection.Close();
            }
            public void UpdateProductType()
            {
                SqlConnection sqlConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["sqlconnection"].ToString());
                string query = "update ProductType set TypeName='home appliances' where ProductTypeId=106";
                SqlCommand cmd = new SqlCommand(query, sqlConnection);
                sqlConnection.Open();
                int row = cmd.ExecuteNonQuery();
                sqlConnection.Close();
            }
            public void DeleteProductType()
            {
                SqlConnection sqlConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["sqlConnection"].ToString());
                string query = "delete from ProductType where ProductTypeId=108 ";
                SqlCommand cmd = new SqlCommand(query, sqlConnection);
                sqlConnection.Open();
                int row = cmd.ExecuteNonQuery();
                sqlConnection.Close();
                if (row > 0)
                {
                    Console.WriteLine("record deleted");
                }
            }
        }
            
//----------------------------------------------------------------------------------------
public class ProductTable
        {
            public void InsertProductTable()
            {
                SqlConnection sqlConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["sqlconnection"].ToString());
                string query = "insert into ProductTable ( ProductTypeId,ProductName,Amount) values (104,'Laptop',40000)";
                SqlCommand cmd = new SqlCommand(query, sqlConnection);
                sqlConnection.Open();
                int row = cmd.ExecuteNonQuery();
                sqlConnection.Close();
                if (row > 0) { Console.Write("row inserted"); }
            }

            public void UpdateProductTable()
            {
                SqlConnection sqlConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["sqlconnection"].ToString());
                string query = "update producttable set productname='Trousers' where productid=202";
                SqlCommand cmd = new SqlCommand(query, sqlConnection);
                sqlConnection.Open();
                cmd.ExecuteNonQuery();
                sqlConnection.Close();
            }
            public void deleteProductTable()
            {
                SqlConnection sqlConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["sqlconnection"].ToString());
                string query = "delete from ProductTable where productid=207";
                SqlCommand cmd = new SqlCommand(query, sqlConnection);
                sqlConnection.Open();
                cmd.ExecuteNonQuery();
                sqlConnection.Close();
            }
            public void retreiveProductTable()
            {
                SqlConnection sqlConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["sqlconnection"].ToString());
                string query = "select * from Producttable";
                SqlCommand cmd = new SqlCommand(query, sqlConnection);
                sqlConnection.Open();
                //   string a= Convert.ToString(cmd.ExecuteReader());
                SqlDataReader r = cmd.ExecuteReader();

                while (r.Read())
                {
                    Console.WriteLine("Id:" + r["productid"] + " " + "ProductName:" + r["ProductName"] + "   " + "Amount:" + r["amount"]);
                }
                sqlConnection.Close();
            }
        }
       
        //------------------------------------------------------------
        public class CustomerSp
        {
            public void InsertCustomerSp()
            {
                SqlConnection sqlConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["sqlconnection"].ToString());
                string query = "customername";
                SqlCommand cmd = new SqlCommand(query, sqlConnection);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.Add("@customerid", SqlDbType.Int).Value = 0;
                cmd.Parameters.Add("@customername", SqlDbType.VarChar).Value = "naitik";
                cmd.Parameters.Add("@customeradd", SqlDbType.VarChar).Value = "AHD";
                cmd.Parameters.Add("@phone", SqlDbType.VarChar).Value = "878589";
                cmd.Parameters.Add("@walletpoints", SqlDbType.Int).Value = 30;
                cmd.Parameters.Add("@optype", SqlDbType.VarChar).Value = "i";
                sqlConnection.Open();
                int row = cmd.ExecuteNonQuery();
                sqlConnection.Close();
            }
            public void UpdateCustomerSp()
            {
                SqlConnection sqlConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["sqlconnection"].ToString());
                string query = "customername";
                SqlCommand cmd = new SqlCommand(query, sqlConnection);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.Add("@customerid", SqlDbType.Int).Value = 7;
                cmd.Parameters.Add("@customername", SqlDbType.VarChar).Value = "Robert";
                cmd.Parameters.Add("@customeradd", SqlDbType.VarChar).Value = "AHD";
                cmd.Parameters.Add("@phone", SqlDbType.VarChar).Value = "878589";
                cmd.Parameters.Add("@walletpoints", SqlDbType.Int).Value = 30;
                cmd.Parameters.Add("@optype", SqlDbType.VarChar).Value = "u";
                sqlConnection.Open();
                int row = cmd.ExecuteNonQuery();
                sqlConnection.Close();
            }
            public void DeleteCustomerSp()
            {
                SqlConnection sqlConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["sqlconnection"].ToString());
                string delQuery = "customername";
                SqlCommand cmd = new SqlCommand(delQuery, sqlConnection);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.Add("@customerid", SqlDbType.Int).Value = 7;
                cmd.Parameters.Add("@customername", SqlDbType.VarChar).Value = "Robert";
                cmd.Parameters.Add("@customeradd", SqlDbType.VarChar).Value = "AHD";
                cmd.Parameters.Add("@phone", SqlDbType.VarChar).Value = "878589";
                cmd.Parameters.Add("@walletpoints", SqlDbType.Int).Value = 30;
                cmd.Parameters.Add("@optype", SqlDbType.VarChar).Value = "d";
                sqlConnection.Open();
                int row = cmd.ExecuteNonQuery();
                sqlConnection.Close();

            }
            public void GetCustomerSp()
            {
                SqlConnection sqlConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["sqlconnection"].ToString());
                string GetdataQ = "customername";
                SqlCommand cmd = new SqlCommand(GetdataQ, sqlConnection);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.Add("@customerid", SqlDbType.Int).Value = 7;
                cmd.Parameters.Add("@customername", SqlDbType.VarChar).Value = "Robert";
                cmd.Parameters.Add("@customeradd", SqlDbType.VarChar).Value = "AHD";
                cmd.Parameters.Add("@phone", SqlDbType.VarChar).Value = "878589";
                cmd.Parameters.Add("@walletpoints", SqlDbType.Int).Value = 30;
                cmd.Parameters.Add("@optype", SqlDbType.VarChar).Value = "s";
                sqlConnection.Open();
                int row = cmd.ExecuteNonQuery();
                sqlConnection.Close();
            }

        }

        //-----------------------------------------
        public class PaymentMode
        {
              public void InsertPaymentMode()
        {
            SqlConnection sqlConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["sqlconnection"].ToString());
            string query = "insert into paymentmode ( CustomerId,productId,PaymentMethod,PaymentDate,totalbill) values (104,'Laptop',40000)";
            SqlCommand cmd = new SqlCommand(query, sqlConnection);
            sqlConnection.Open();
            int row = cmd.ExecuteNonQuery();
            sqlConnection.Close();
        }
        public void UpdatePaymentMode()
        {
            SqlConnection sqlConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["sqlconnection"].ToString());
            string query = "updatePaymentMode set paymentmethode='Credit card' where paymentmodeid=301";
            SqlCommand cmd = new SqlCommand(query, sqlConnection);
            sqlConnection.Open();
            cmd.ExecuteNonQuery();
            sqlConnection.Close();
        }
        public void DeletePaymentMode()
        {
            SqlConnection sqlConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["sqlconnection"].ToString());
            string query = "delete from PaymentMode where paymentmodeid=319";
            SqlCommand cmd = new SqlCommand(query, sqlConnection);
            sqlConnection.Open();
            cmd.ExecuteNonQuery();
            sqlConnection.Close();
        }

        public void getPaymentmode()
        {
            SqlConnection sqlConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["sqlconnection"].ToString());
            string query = "select top 1 totalbill from Paymentmode";
            SqlCommand cmd = new SqlCommand(query, sqlConnection);
            sqlConnection.Open();
            string row = Convert.ToString(cmd.ExecuteScalar());
            sqlConnection.Close();
        }
    }
      
        //---------------------------------------------------
        public class CartHistory { 
        public void Insertcart()
        {
            SqlConnection sqlConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["sqlconnection"].ToString());
            string query = "insert into CartHistory ( PurchaseDate,paymentmodeID) values (104,'Laptop',40000)";
            SqlCommand cmd = new SqlCommand(query, sqlConnection);
            sqlConnection.Open();
            int row = cmd.ExecuteNonQuery();
            sqlConnection.Close();
        }
        public void Updatecart()
        {
            SqlConnection sqlConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["sqlconnection"].ToString());
            string query = "update CartHistory set PurchaseDate='2023-08-23' where CartId=501";
            SqlCommand cmd = new SqlCommand(query, sqlConnection);
            sqlConnection.Open();
            cmd.ExecuteNonQuery();
            sqlConnection.Close();
        }
        public void Deletecart()
        {
            SqlConnection sqlConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["sqlconnection"].ToString());
            string query = "delete from  CartHistory where CartId=508";
            SqlCommand cmd = new SqlCommand(query, sqlConnection);
            sqlConnection.Open();
            cmd.ExecuteNonQuery();
            sqlConnection.Close();
        }
        public void getCarthistory()
        {
            SqlConnection sqlConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["sqlconnection"].ToString());
            string query = "select * from CartHistory";
            SqlCommand cmd = new SqlCommand(query, sqlConnection);
            sqlConnection.Open();
           
            SqlDataReader r = cmd.ExecuteReader();

            while (r.Read())
            {
                Console.WriteLine("Id:" + r["CartId"] + " " + "PurchaseDate:" + r["PurchaseDate"] + "   " + "paymentmodeID:" + r["paymentmodeID"]);
            }
            sqlConnection.Close();
        }
        }
    }
    
}
  

