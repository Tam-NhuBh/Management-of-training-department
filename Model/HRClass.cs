using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1.Model
{
    public class HRClass
    {
        COURSE course = new COURSE();
        my_db mydb = new my_db();
        string idhr = GlobalData.GlobalUserID.ToString();
        public DataTable getAllGroup(string commend = "SELECT * FROM mygroups")
        {
            // Phân quyền từng nhóm group thuộc một HR
            //if(idhr.Trim() != "")
            //{
            //    commend = commend +"Where userid =" + idhr;
            //}
            
            string commend2 = "SELECT * FROM mygroups where userid = " + idhr;
            SqlCommand cmd = new SqlCommand(commend2, mydb.getConnection);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }

        internal bool CheckexistbyIdUser(int id)
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM login WHERE ID = @id", mydb.getConnection);
            cmd.Parameters.Add("@id", SqlDbType.Int).Value = id;
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable table = new DataTable();
            adapter.Fill(table);
            if (table.Rows.Count > 0)
            {
                mydb.closeConnection();
                //already exists
                return false;
                
            }
            else
            {
                mydb.closeConnection();
                return true;
                
            }
        }

        internal DataTable GetAllCorseNTeacher()
        {
            
            string idhr = GlobalData.GlobalUserID.ToString();
            string commend2 = "SELECT * FROM Course where Course.idTeacher is NULL or Course.idTeacher IN (Select mycontact.id From mycontact Where mycontact.idHR = " + idhr +")";
            SqlCommand cmd = new SqlCommand(commend2, mydb.getConnection);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }

        internal bool UpdateAccount(int id, string user, string pass, string fname, string lname, int type, MemoryStream pic, string email)
        {
            SqlCommand command = new SqlCommand("UPDATE login SET Id=@id, Username = @user, Password = @pass, F_name = @fn, L_name =@ln, Type_User = @type, Image =@pic, Email =@email WHERE Id = @id", mydb.getConnection);
            command.Parameters.Add("@id", SqlDbType.Int).Value = id;
            command.Parameters.Add("@user", SqlDbType.NChar).Value = user;
            command.Parameters.Add("@pass", SqlDbType.NChar).Value = pass;
            command.Parameters.Add("@fn", SqlDbType.NVarChar).Value = fname;
            command.Parameters.Add("@ln", SqlDbType.NVarChar).Value = lname;
            command.Parameters.Add("@type", SqlDbType.Int).Value = type;
            command.Parameters.Add("@pic", SqlDbType.Image).Value = pic.ToArray();
            command.Parameters.Add("@email", SqlDbType.NVarChar).Value = email;
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

        internal bool TransferCourse(string oldCourse, string newCouse, int idTech)
        {
            SqlCommand command = new SqlCommand("UPDATE Course SET idTeacher = NULL WHERE Course.Id = @oldCourse", mydb.getConnection);
            command.Parameters.Add("@oldCourse", SqlDbType.Int).Value = oldCourse;


            mydb.openConnection();
            if ((command.ExecuteNonQuery() == 1))
            {
                SqlCommand commandNew = new SqlCommand("UPDATE Course SET idTeacher = @tech WHERE Course.Id = @newCourse", mydb.getConnection);
                commandNew.Parameters.Add("@newCourse", SqlDbType.Int).Value = newCouse;
                commandNew.Parameters.Add("@tech", SqlDbType.Int).Value = idTech;
                if ((commandNew.ExecuteNonQuery() == 1))
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
            else
            {
                mydb.closeConnection();
                return false;
            }
        }

        internal DataTable GetDataOfUser(int idHr)
        {
            
            string commend = "SELECT Username,Password,F_name,L_name,Type_User,Image,Email FROM login where login.Id = @iduser";
            
            SqlCommand cmd = new SqlCommand(commend, mydb.getConnection);
            cmd.Parameters.Add("@iduser", SqlDbType.Int).Value = idHr;
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }

        internal bool DeleteCourseOfTeach(string idCouse)
        {
            SqlCommand command = new SqlCommand("UPDATE Course SET idTeacher = NULL WHERE Course.Id = @oldCourse", mydb.getConnection);
            command.Parameters.Add("@oldCourse", SqlDbType.Int).Value = idCouse;

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

        internal bool CheckexistbyIdContact(int idContact)
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM mycontact WHERE id = @id", mydb.getConnection);
            cmd.Parameters.Add("@id", SqlDbType.Int).Value = idContact;


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

        internal object GetAllContactofGroup(string nameGroup)
        {
            SqlCommand cmd = new SqlCommand("SELECT mycontact.id, mycontact.fname, mycontact.lname,mycontact.group_id,mycontact.phone, mycontact.email, mycontact.address, mycontact.pic, mycontact.idHR  FROM mycontact,mygroups WHERE group_id = mygroups.id and mygroups.name=@group", mydb.getConnection);
            cmd.Parameters.Add("@group", SqlDbType.NVarChar).Value = nameGroup;


            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }

        internal bool enrollClass(int idContact, string[] listcourse)
        {
            
            mydb.openConnection();
            for (int i = 0; i < listcourse.Length; i++)
            {
                SqlCommand commandScore = new SqlCommand("UPDATE Course SET idTeacher = @idtec Where Course.Id =@ci", mydb.getConnection);
                commandScore.Parameters.Add("@idtec", SqlDbType.Int).Value = idContact;
                
                commandScore.Parameters.Add("@ci", SqlDbType.Int).Value = listcourse[i];
                
                if (commandScore.ExecuteNonQuery() != 1)
                {
                    
                    mydb.closeConnection();
                    return false;

                }

            }
            mydb.closeConnection();
            return true;
        }

        internal bool CheckExitNamebyIDHR(string nameGroup)
        {
            string idhr = GlobalData.GlobalUserID.ToString();
            SqlCommand command = new SqlCommand("Select * from mygroups Where name = @gName and userid = @idHr", mydb.getConnection);
            command.Parameters.Add("@gName", SqlDbType.NVarChar).Value = nameGroup;
            command.Parameters.Add("@idHr", SqlDbType.Int).Value = idhr;
            mydb.openConnection();
            SqlDataAdapter adapter = new SqlDataAdapter(command);
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

        internal DataTable getAllGroupbyIdHR(int idHr)
        {
            SqlCommand cmd = new SqlCommand("SELECT name  FROM mygroups WHERE userid = @idhr ", mydb.getConnection);
            cmd.Parameters.Add("@idhr", SqlDbType.Int).Value = idHr;

            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }

        internal bool DeleteContact(int idContact)
        {
            SqlCommand command = new SqlCommand("Delete from mycontact Where Id =@cid", mydb.getConnection);
            command.Parameters.Add("@cid", SqlDbType.Int).Value = idContact;

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

        internal DataTable GetContactbyId(int tbID)
        {
            SqlCommand cmd = new SqlCommand("SELECT fname, lname, mygroups.name as NameGroup,phone,email,address,pic FROM mycontact,mygroups WHERE mycontact.id = @id", mydb.getConnection);
            cmd.Parameters.Add("@id", SqlDbType.Int).Value = tbID;

            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }

        internal DataTable GetAllContactofHR(int idHR)
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM mycontact WHERE idHR = @idHR", mydb.getConnection);
            cmd.Parameters.Add("@idHr", SqlDbType.Int).Value = idHR;

            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }

        internal bool EditGroup(int idGroup, string newName)
        {
            SqlCommand command = new SqlCommand("UPDATE mygroups SET  name = @nn WHERE Id = @idGroup", mydb.getConnection);
            command.Parameters.Add("@idGroup", SqlDbType.Int).Value = idGroup;
            command.Parameters.Add("@nn", SqlDbType.NVarChar).Value = newName;
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

        internal DataTable getAllCoursebyTeach(int contact)
        {
            SqlCommand cmd = new SqlCommand("SELECT Id  FROM Course WHERE idTeacher = @idTeach", mydb.getConnection);
            cmd.Parameters.Add("@idTeach", SqlDbType.Int).Value = contact;

            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable table = new DataTable();
            adapter.Fill(table);
            

            return table;
        }

        internal bool insertContact(int idContact, string fname, string lname, int idGroup, string phone, string email, string address, MemoryStream pic, int idHR)
        {
            SqlCommand cmd = new SqlCommand("INSERT INTO mycontact (Id, fname,lname, group_id, phone, email,address, pic, idHR)" +
                "VALUES (@id, @fname,@lname,@idGroup,@phone,@email,@address, @pic, @idHR)", mydb.getConnection);
            cmd.Parameters.Add("@id", SqlDbType.Int).Value = idContact;
            cmd.Parameters.Add("@fname", SqlDbType.NVarChar).Value = fname;
            cmd.Parameters.Add("@lname", SqlDbType.NVarChar).Value = lname;
            cmd.Parameters.Add("@idGroup", SqlDbType.Int).Value = idGroup;
            cmd.Parameters.Add("@phone", SqlDbType.NChar).Value = phone;
            cmd.Parameters.Add("@email", SqlDbType.NVarChar).Value = email;
            cmd.Parameters.Add("@address", SqlDbType.NVarChar).Value = address;
            
            cmd.Parameters.Add("@pic", SqlDbType.Image).Value = pic.ToArray();
            cmd.Parameters.Add("@idHR", SqlDbType.Int).Value = idHR;
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

        internal bool DeleteGroup(int idGroup)
        {
            SqlCommand command = new SqlCommand("Delete from mygroups Where id =@gid", mydb.getConnection);
            command.Parameters.Add("@gid", SqlDbType.Int).Value = idGroup;

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

        internal bool UpdateContact(int idContact, string fname, string lname, int idGroup, string phone, string email, string address, MemoryStream pic, int idHR)
        {
            SqlCommand command = new SqlCommand("UPDATE mycontact SET  fname = @fn, lname =@ln, group_id = @group_id, phone =@phone, email =@email, address =@adrs, pic =@pic, idHR= @idhr WHERE Id = @id", mydb.getConnection);
            command.Parameters.Add("@id", SqlDbType.Int).Value = idContact;
            command.Parameters.Add("@fn", SqlDbType.NVarChar).Value = fname;
            command.Parameters.Add("@ln", SqlDbType.NVarChar).Value = lname;
            command.Parameters.Add("@group_id", SqlDbType.Int).Value = idGroup;
            command.Parameters.Add("@phone", SqlDbType.NChar).Value = phone;
            command.Parameters.Add("@email", SqlDbType.NVarChar).Value = phone;
            command.Parameters.Add("@adrs", SqlDbType.NVarChar).Value = address;
            command.Parameters.Add("@pic", SqlDbType.Image).Value = pic.ToArray();
            command.Parameters.Add("@idhr", SqlDbType.Int).Value = idHR;
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

        internal bool AddGroup(int idGroup, string nameGroup)
        {
            int idHR = GlobalData.GlobalUserID;
            SqlCommand cmd = new SqlCommand("INSERT INTO mygroups (Id, name,userid)" +
                "VALUES (@id, @name,@userid)", mydb.getConnection);
            cmd.Parameters.Add("@id", SqlDbType.Int).Value = idGroup;
            cmd.Parameters.Add("@name", SqlDbType.NVarChar).Value = nameGroup;
            cmd.Parameters.Add("@userid", SqlDbType.Int).Value = idHR;

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

        internal bool checkExitbyIDGroup(int idGroup)
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM mygroups WHERE id = @id", mydb.getConnection);
            cmd.Parameters.Add("@id", SqlDbType.Int).Value = idGroup;


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

    }
}
