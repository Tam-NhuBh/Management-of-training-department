using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace WindowsFormsApp1.Model
{
    internal class SCORE
    {
        my_db mydb = new my_db();
        COURSE course = new COURSE();

        //create a function to insert a new score
        public bool insertScorse(int studentId, int courseId, double score, string description)
        {
            
                SqlCommand cmd = new SqlCommand("INSERT INTO Score (IdStudent, IdCourse, Score, Description)" + "VALUES (@sid, @cid, @s, @dscr)", mydb.getConnection);
                cmd.Parameters.Add("@sid", SqlDbType.Int).Value = studentId;
                cmd.Parameters.Add("@cid", SqlDbType.Int).Value = courseId;
                cmd.Parameters.Add("@s", SqlDbType.Real).Value = score;
                cmd.Parameters.Add("@dscr", SqlDbType.NVarChar).Value = description;
                mydb.openConnection();
                if (cmd.ExecuteNonQuery() == 1)
                {
                    return true;
                }
                else
                {
                    return false;
                }
           
        }

        public bool editScorse(int courseId, int studentId, double score, string des)
        {
            SqlCommand cmd = new SqlCommand("UPDATE Score SET Score.Score = @s, Score.Description = @dscr Where IdCourse =  @cid and  IdStudent = @sid", mydb.getConnection);
            cmd.Parameters.Add("@cid", SqlDbType.Int).Value = courseId;
            cmd.Parameters.Add("@sid", SqlDbType.Int).Value = studentId;
            cmd.Parameters.Add("@s", SqlDbType.Real).Value = score;
            cmd.Parameters.Add("@dscr", SqlDbType.NVarChar).Value = des;

            mydb.openConnection();
            if (cmd.ExecuteNonQuery() == 1)
            {
                return true;
            }
            else
            {
                return false;
            }


        }

        

        internal object ScoreOfStudent(int idStudent)
        {
            SqlCommand command = new SqlCommand("SELECT Score.IdStudent , Student.FirstName, Student.LastName, Score.IdCourse,Course.Label,  Score.Score, Score.Description FROM Student INNER JOIN Score ON Student.Id = Score.IdStudent INNER JOIN Course ON Score.IdCourse = COURSE.Id Where Score.IdStudent =@idStudent ", mydb.getConnection);
            command.Parameters.Add("@idStudent", SqlDbType.Int).Value = idStudent;

            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);

            return table;
        }

        internal object getStudentsScorebyTeacher(int idTeacher)
        {
            SqlCommand command = new SqlCommand("SELECT Score.IdStudent, Student.FirstName, Student.LastName,COURSE.Label,  Score.Score, Score.Description FROM Student INNER JOIN Score ON Student.Id = Score.IdStudent INNER JOIN Course ON Score.IdCourse = COURSE.Id Where COURSE.idTeacher =@idteach ", mydb.getConnection);
            command.Parameters.Add("@idteach", SqlDbType.Int).Value = idTeacher;

            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);

            return table;
        }

        public DataTable ScoreInCourse(int inCourese)
        {
            SqlCommand command = new SqlCommand("SELECT Score.IdStudent, Student.FirstName, Student.LastName,  Score.Score, Score.Description, Student.Picture as Image FROM Student INNER JOIN Score ON Student.Id = Score.IdStudent INNER JOIN Course ON Score.IdCourse = COURSE.Id Where Score.IdCourse =@idCourse ", mydb.getConnection);
            command.Parameters.Add("@idCourse", SqlDbType.Int).Value = inCourese;

            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);

            return table;
        }

        // create a function to check if a score is already asigned to this student in this course.
        public bool studentScoreExists(int courseID, int studentId)
        {
            SqlCommand command = new SqlCommand("SELECT * FROM Score WHERE Score.IdStudent = @sid AND Score.IdCourse = @cId ", mydb.getConnection);

            command.Parameters.Add("@sid", SqlDbType.Int).Value = studentId;
            command.Parameters.Add("@cId", SqlDbType.VarChar).Value = courseID;
            

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
        // create a function to get students score
        public DataTable getStudentsScore()
        {
            
            SqlCommand command = new SqlCommand("SELECT Score.IdStudent, Student.FirstName, Student.LastName, Score.IdCourse, COURSE.Label, COURSE.Semester , Score.Score, Score.Description FROM Student INNER JOIN Score ON Student.Id = Score.IdStudent INNER JOIN Course ON Score.IdCourse = COURSE.Id", mydb.getConnection);

            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);

            return table;
        }
        
        public DataTable getStudentsScoreBySemester(int semester, string nameCoures)
        {

            SqlCommand command = new SqlCommand("SELECT Score.IdStudent, Student.FirstName, Student.LastName, Score.IdCourse, COURSE.Label, COURSE.Semester , Score.Score, Score.Description FROM Student INNER JOIN Score ON Student.Id = Score.IdStudent INNER JOIN Course ON Score.IdCourse = COURSE.Id Where COURSE.Label = @cname AND COURSE.Semester = @sem ", mydb.getConnection);
            command.Parameters.Add("@sem", SqlDbType.Int).Value = semester;
            command.Parameters.Add("@cname", SqlDbType.VarChar).Value = nameCoures;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);

            return table;
        }

        public bool deleteScore(int courseId, int studentId)
        {
            SqlCommand command = new SqlCommand("Delete from SCORE Where IdStudent =@sid and IdCourse = @cid", mydb.getConnection);
            command.Parameters.Add("@sid", SqlDbType.Int).Value = studentId;
            command.Parameters.Add("@cid", SqlDbType.Int).Value = courseId;
            mydb.openConnection();
            if (command.ExecuteNonQuery() == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        // tính trung bình
        public DataTable getAvgScoreByCourse()
        {
            SqlCommand command = new SqlCommand();
            command.Connection = mydb.getConnection;

            command.CommandText = "SELECT COURSE.Semester, COURSE.Label, round(AVG(SCORE.Score),1) As Average FROM COURSE, SCORE WHERE COURSE.Id = " + " SCORE.IdCourse GROUP BY COURSE.Label, COURSE.Semester";
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }
        public DataTable getAvgScoreByCourseOfTeach(int idTeach)
        {
            SqlCommand command = new SqlCommand();
            command.Connection = mydb.getConnection;

            command.CommandText = "SELECT COURSE.Semester, COURSE.Label, round(AVG(SCORE.Score),1) As Average FROM COURSE, SCORE WHERE COURSE.Id = " + " SCORE.IdCourse and COURSE.idTeacher = @idTeach GROUP BY COURSE.Label, COURSE.Semester";
            command.Parameters.Add("@idTeach", SqlDbType.Int).Value = idTeach;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }
        //public DataTable getScoreByCourse(string lop)
        //{
        //    SqlCommand command = new SqlCommand();
        //    command.Connection = mydb.getConnection;

        //    command.CommandText = "SELECT SCORE.IdStudent, Student.FirstName, Student.LastName, COURSE.Label, SCORE.Score, SCORE.Description FROM Student INNER JOIN SCORE ON Student.ID = SCORE.IdStudent INNER JOIN COURSE ON SCORE.IdCourse = COURSE.Id where COURSE.Label = @lop";
        //    command.Parameters.Add("@lop", SqlDbType.VarChar).Value = lop;
        //    SqlDataAdapter adapter = new SqlDataAdapter(command);
        //    DataTable table = new DataTable();
        //    adapter.Fill(table);

        //    return table;
        //}

        public DataTable show(int id)
        {
            SqlCommand command = new SqlCommand();
            command.Connection = mydb.getConnection;

            command.CommandText = "select COURSE.Semester, COURSE.ID, COURSE.Label as Name, SCORE.Score , COURSE.Label as Result from SCORE inner join COURSE ON COURSE.Id = SCORE.IdCourse inner join Student on Student.ID = SCORE.IdStudent where IdStudent = @sid ";
            command.Parameters.Add("@sid", SqlDbType.Int).Value = id;

            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }
    }
}
