using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Model
{
    public class Results
    {
        my_db mydb = new my_db();
        

        internal DataTable getAllScoreInCSemester(int semester, string nameCourse)
        {
            SqlCommand command = new SqlCommand();
            command.Connection = mydb.getConnection;

            command.CommandText = "select kq.IdCourse, kq.Score from Course c, [dbo].[Score] kq where c.Id = kq.IdCourse and c.Label = @name and c.Semester = @sem and kq.Score is not NULL";
            command.Parameters.Add("@sem", SqlDbType.Int).Value = semester;
            command.Parameters.Add("@name", SqlDbType.VarChar).Value = nameCourse;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }
        internal DataTable getAllScore()
        {
            SqlCommand command = new SqlCommand();
            command.Connection = mydb.getConnection;

            command.CommandText = "select kq.IdStudent, kq.IdCourse, kq.Score from  [dbo].[Score] kq where kq.Score is not NULL";

            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }
    }
}
