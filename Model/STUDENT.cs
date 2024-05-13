using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using WindowsFormsApp1.Model;
namespace WindowsFormsApp1
{
    public class STUDENT
    {
        my_db mydb = new my_db();
        COURSE course = new COURSE();
        public bool insertStudent(int id, string fname, string lname, DateTime bdate, string gender, string phone, string address, MemoryStream picture, string[] listcourse = null) // 
        {
            //INSERT INTO GeekTable1(Id1, Name1, City1)
            //OUTPUT inserted.Id1, inserted.Name1, inserted.City1
            //INTO GeekTable2
            //VALUES(1, 'Komal', 'Delhi'), (2, 'Khushi', 'Noida')
            //GO

            //khai báo một transaction
            

            SqlCommand command = new SqlCommand("INSERT INTO Student (Id, FirstName, LastName, BirthDate, Gender, Phone, Address, Picture)" + "VALUES (@id, @fn,@ln,@bdt, @gdr, @phn, @adrs, @pic)", mydb.getConnection);
            command.Parameters.Add("@id", SqlDbType.Int).Value = id;
            command.Parameters.Add("@fn", SqlDbType.NVarChar).Value = fname;
            command.Parameters.Add("@ln", SqlDbType.NVarChar).Value = lname;
            command.Parameters.Add("@bdt", SqlDbType.DateTime).Value = bdate;
            command.Parameters.Add("@gdr", SqlDbType.NChar).Value = gender;
            command.Parameters.Add("@phn", SqlDbType.NChar).Value = phone;
            command.Parameters.Add("@adrs", SqlDbType.NVarChar).Value = address;
            command.Parameters.Add("@pic", SqlDbType.Image).Value = picture.ToArray();
            mydb.openConnection();
            SqlTransaction transaction;
            transaction = mydb.getConnection.BeginTransaction();
            command.Transaction = transaction;

            if ((command.ExecuteNonQuery() == 1))
            {
                // Course
                if(listcourse != null)
                {
                    if (listcourse[0] != "")
                    {
                        for (int i = 0; i < listcourse.Length; i++)
                        {
                            SqlCommand commandScore = new SqlCommand("INSERT INTO Score (IdStudent, IdCourse)" + "VALUES (@idStu, @ci)", mydb.getConnection);
                            commandScore.Parameters.Add("@idStu", SqlDbType.Int).Value = id;

                            commandScore.Parameters.Add("@ci", SqlDbType.Int).Value = listcourse[i];
                            commandScore.Transaction = transaction;
                            if (commandScore.ExecuteNonQuery() != 1)
                            {
                                transaction.Rollback();
                                mydb.closeConnection();
                                return false;


                            }

                        }
                    }
                }
                
                
                transaction.Commit();
                
                mydb.closeConnection();

                return true;
            }
            else
            {
                transaction.Rollback();
                mydb.closeConnection();
                return false;
            }


            





        }
        
        internal bool CheckexistbyId(int id)
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM Student WHERE Id = @id", mydb.getConnection);
            cmd.Parameters.Add("@id", SqlDbType.Int).Value = id;


            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable table = new DataTable();
            adapter.Fill(table);
            if (table.Rows.Count > 0)
            {
                mydb.closeConnection();
                //this course name already exists
                return false;
                
            }
            else
            {

                mydb.closeConnection();
                return true;
                
            }
        }

        public DataTable getStudent(SqlCommand command)
        {
            command.Connection = mydb.getConnection;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }
        // function to Update
        public bool updateStudent(int Id, string fname, string lname, DateTime bdate, string gender, string phone, string address, MemoryStream picture)
        {
            SqlCommand command = new SqlCommand("UPDATE Student SET Id = @id,  FirstName = @fn, LastName =@ln, BirthDate = @bdt, Gender =@gdr, Phone =@phn, Address =@adrs, Picture =@pic WHERE Id = @id", mydb.getConnection);
            command.Parameters.Add("@id", SqlDbType.Int).Value = Id;
            command.Parameters.Add("@fn", SqlDbType.NVarChar).Value = fname;
            command.Parameters.Add("@ln", SqlDbType.NVarChar).Value = lname;
            command.Parameters.Add("@bdt", SqlDbType.DateTime).Value = bdate;
            command.Parameters.Add("@gdr", SqlDbType.NChar).Value = gender;
            command.Parameters.Add("@phn", SqlDbType.NChar).Value = phone;
            command.Parameters.Add("@adrs", SqlDbType.NVarChar).Value = address;
            command.Parameters.Add("@pic", SqlDbType.Image).Value = picture.ToArray();
            mydb.openConnection();
            if ((command.ExecuteNonQuery() == 1))
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
        // function to delete Student
        public bool deteleStudent(int id)
        {
            SqlCommand command = new SqlCommand("Delete from Student Where Id =@sid", mydb.getConnection);
            command.Parameters.Add("@sid", SqlDbType.Int).Value = id;

            mydb.openConnection();
            if ((command.ExecuteNonQuery() == 1))
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
        public string execCount(string query)
        {
            SqlCommand cmd = new SqlCommand(query, mydb.getConnection);
            mydb.openConnection();
            string count = cmd.ExecuteScalar().ToString();
            mydb.closeConnection();
            return count;
        }
        //đếm tổng sinh viên
        public string toTalStudent()
        {
            return execCount("SELECT COUNT(*) FROM Student");
        }
        //đếm tổng sv nam
        public string maleStudent()
        {
            return execCount("SELECT COUNT(*) FROM Student where gender = 'male'");
        }
        //đếm tổng sv nữ
        public string femaleStudent()
        {
            return execCount("SELECT COUNT(*) FROM dbo.Student where gender = 'female'");
        }
    }
}
