using System;
using System.Data;
using System.Data.SqlClient;

namespace ADOModel1
{
    class AdoClass
    {
        static void Main(string[] args)
        {
            AdoClass obj = new AdoClass();
            obj.createtable();
        }
        public void createtable()
        {
            SqlConnection con = null;
            try
            {
                con = new SqlConnection("Data Source=.;Database=sample;Integrated Security=SSPI");
                SqlCommand cmd = new SqlCommand("create table student(id int Primary Key NOT NULL,name Varchar(20) NOT NULL)", con);
                con.Open();
                cmd.ExecuteNonQuery();
                Console.WriteLine("Table Created Successfully");
            }
            catch (Exception e)
            {
                Console.WriteLine("Error Occured" + e);
            }
            finally
            {
                con.Close();
            }
        }
    }
}
