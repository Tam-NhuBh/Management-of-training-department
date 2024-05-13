using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Model
{
    public class COURSE
    {
        my_db mydb = new my_db();

        public bool insertCourse(int id, string courseName,int kihoc, int hourseNumber, string decription)
        {
            SqlCommand cmd = new SqlCommand("INSERT INTO Course (Id, Label,Semester, Hours_number, description)" + "VALUES (@id, @name,@smt,@hrs,@dscr)", mydb.getConnection);
            cmd.Parameters.Add("@id", SqlDbType.Int).Value = id;
            cmd.Parameters.Add("@name", SqlDbType.VarChar).Value = courseName;
            cmd.Parameters.Add("@smt", SqlDbType.Int).Value = kihoc;
            cmd.Parameters.Add("@hrs", SqlDbType.Int).Value = hourseNumber;
            cmd.Parameters.Add("@dscr", SqlDbType.NVarChar).Value = decription;
            mydb.openConnection();
            if (cmd.ExecuteNonQuery() == 1)
            {
                mydb.closeConnection();
                return true;

            }
            else
            {
                mydb.closeConnection();
                return false;

            }
        }
        public bool CheckCourseName(string courseName, int semester, int IdCourse)
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM Course WHERE Label = @cName And Semester = @sem And Id <> @cId", mydb.getConnection);
            cmd.Parameters.Add("@sem", SqlDbType.Int).Value = semester;
            cmd.Parameters.Add("@cName", SqlDbType.VarChar).Value = courseName;
            cmd.Parameters.Add("@cId", SqlDbType.Int).Value = IdCourse;
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable table = new DataTable();
            adapter.Fill(table);
            if (table.Rows.Count > 0)
            {
                //this course name already exists
                mydb.closeConnection();
                return false;
                
            }
            else
            {
                mydb.closeConnection();
                return true;
                

            }


        }
        public bool CheckIDCourse( int idCourse)
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM Course WHERE  Id = @cid", mydb.getConnection);
            cmd.Parameters.Add("@cid", SqlDbType.Int).Value = idCourse;


            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable table = new DataTable();
            adapter.Fill(table);
            if (table.Rows.Count > 0)
            {
                //this course name already exists
                mydb.closeConnection();
                return false;

            }
            else
            {
                mydb.closeConnection();
                return true;


            }


        }
        internal object getAllCoursebyTeacher(int idTeacher)
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM Course where idTeacher = @idteach", mydb.getConnection);
            cmd.Parameters.Add("@idteach", SqlDbType.Int).Value = idTeacher;

            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }

        

        // function to remove course by id
        public bool deleteCourse(int courseId)
        {
            
            SqlCommand command = new SqlCommand("Delete from Course Where Id =@cid", mydb.getConnection);
            command.Parameters.Add("@cid", SqlDbType.Int).Value = courseId;
            mydb.openConnection();
            if (command.ExecuteNonQuery() == 1)
            {
                mydb.closeConnection();
                return true;
                
            }
            else
            {
                mydb.closeConnection();
                return false;
                
            }
        }

        

        public DataTable getAllCourse(string commend = "SELECT * FROM Course")
        {
            SqlCommand cmd = new SqlCommand(commend, mydb.getConnection);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }
        public DataTable getAllCoursebySemester(int kihoc)
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM Course where Semester = @cSemester", mydb.getConnection);
            cmd.Parameters.Add("@cSemester", SqlDbType.Int).Value = kihoc;

            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }
        public DataTable getAllCourseTeacherbySemester(int kihoc)
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM Course where Semester = @cSemester and idTeacher is null", mydb.getConnection);
            cmd.Parameters.Add("@cSemester", SqlDbType.Int).Value = kihoc;

            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }
        public DataTable getCourseById(int courseID)
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM Course where Id = @cid", mydb.getConnection);
            cmd.Parameters.Add("@cid", SqlDbType.Int).Value = courseID;
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }
        public DataTable getCourseByName(string courseName)
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM Course where Label  = @cName", mydb.getConnection);
            cmd.Parameters.Add("@cName", SqlDbType.VarChar).Value = courseName;
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }
        public string getNamebyIDCourse(string idCourse)
        {
            SqlCommand cmd = new SqlCommand("SELECT Label FROM Course where Id  = @cId", mydb.getConnection);
            cmd.Parameters.Add("@cId", SqlDbType.Int).Value = idCourse;
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable table = new DataTable();
            adapter.Fill(table);
            string name = table.Rows[0][0].ToString();
            return name;
        }
        public int getCourseIDByNameAndSemester(string courseName, int semester)
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM Course where Label  = @cName and Semester = @sem", mydb.getConnection);
            cmd.Parameters.Add("@cName", SqlDbType.VarChar).Value = courseName;
            cmd.Parameters.Add("@sem", SqlDbType.Int).Value = semester;
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable table = new DataTable();
            adapter.Fill(table);
            int id = -1;
            if (table.Rows.Count > 0)
            {
                id = (int)table.Rows[0][0];
                return id;
            }
            else
            {
                return id;
            }
            
            
        }
        public bool UpdateCourse(int id, string courseName,int kihoc, int hourseNumber, string decription)
        {
            
            SqlCommand cmd = new SqlCommand("UPDATE Course SET  Label = @name,Semester = @smt ,  Hours_number =@hrs, description = @dscr WHERE Id = @id", mydb.getConnection);
            cmd.Parameters.Add("@id", SqlDbType.Int).Value = id;
            cmd.Parameters.Add("@name", SqlDbType.VarChar).Value = courseName;
            cmd.Parameters.Add("@smt", SqlDbType.Int).Value = kihoc;
            cmd.Parameters.Add("@hrs", SqlDbType.Int).Value = hourseNumber;
            cmd.Parameters.Add("@dscr", SqlDbType.NVarChar).Value = decription;
            mydb.openConnection();
            if (cmd.ExecuteNonQuery() ==  1)
            {
                return true;
                mydb.closeConnection();
            }
            else
            {
                return false;
                mydb.closeConnection();
            }


            
        }
        internal DataTable getAllSemester()
        {
            SqlCommand cmd = new SqlCommand("SELECT Course.Semester FROM Course Group by Course.Semester ", mydb.getConnection);

            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable table = new DataTable();
            adapter.Fill(table);

            return table;
        }
        internal DataTable getAllSemesterbyTeach(int idTeacher)
        {
            SqlCommand cmd = new SqlCommand("SELECT Course.Semester FROM Course Where Course.idTeacher =@idtech  Group by Course.Semester ", mydb.getConnection);
            cmd.Parameters.Add("@idtech", SqlDbType.Int).Value = idTeacher;
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }

        internal object getAllCoursebySemesterOfTeach(int idTeacher, int semester)
        {
            SqlCommand cmd = new SqlCommand("SELECT Course.Label, Course.Id FROM Course Where Course.idTeacher = @idTech and Course.Semester = @semes  ", mydb.getConnection);
            cmd.Parameters.Add("@idTech", SqlDbType.Int).Value = idTeacher;
            cmd.Parameters.Add("@semes", SqlDbType.Int).Value = semester;
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable table = new DataTable();
            adapter.Fill(table);

            return table;
        }
    }
}
