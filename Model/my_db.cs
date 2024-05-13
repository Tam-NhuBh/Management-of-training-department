using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace WindowsFormsApp1
{
    class my_db
    {
        SqlConnection con = new SqlConnection(@"Data Source=(localdb)\ProjectsV13;Initial Catalog=myDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
       //get the connection
            public SqlConnection getConnection
            {
                get
                {
                    return con;
                }
            }
        //open the connection
        public void openConnection()
        {
            if ((con.State == ConnectionState.Closed))
            {
                con.Open();
            }    
        }

        internal bool checkResById(string idUser)
        {
            SqlCommand command = new SqlCommand("SELECT * FROM login WHERE login.Id = @uid ", con);

            command.Parameters.Add("@uid", SqlDbType.Int).Value = idUser;



            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            if ((table.Rows.Count > 0))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        internal bool checkEmail(string email)
        {
            SqlCommand command = new SqlCommand("SELECT * FROM login WHERE login.Email = @email ", con);

            command.Parameters.Add("@email", SqlDbType.VarChar).Value = email;



            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            if ((table.Rows.Count > 0))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        internal bool checkUserName(string userName)
        {
            SqlCommand command = new SqlCommand("SELECT * FROM login WHERE login.Username = @uid ", con);

            command.Parameters.Add("@uid", SqlDbType.VarChar).Value = userName;



            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            if ((table.Rows.Count > 0))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        //close the connection
        public void closeConnection()
        {
            if((con.State == ConnectionState.Open))
            {
                con.Close();
            }    
        }
    }
}
