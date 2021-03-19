using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.Common;
using System.Data;
using System.Data.SqlClient;

namespace Lab_Group.tiennln.Student
{
    class StudentDAO
    {
        public List<StudentDTO> getStudentList()
        {
            List<StudentDTO> listStudents = new List<StudentDTO>();

            // Get connection string / provider from *.config
            string database = ConfigurationManager.AppSettings["provider"];
            string connectionString = ConfigurationManager.ConnectionStrings["SqlProviderPubs"].ConnectionString;

            // Make a factory provider
            DbProviderFactory df = DbProviderFactories.GetFactory(database);

            // Make connection object
            DbConnection cn = df.CreateConnection();
            cn.ConnectionString = connectionString;
            cn.Open();

            // make command obj
            DbCommand command = df.CreateCommand();
            command.Connection = cn;
            command.CommandText = "Select * From student ";

            // print out data with data reader
            DbDataReader dr = command.ExecuteReader(CommandBehavior.CloseConnection);

            while (dr.Read())
            {
                string studentID = dr["studentID"].ToString();
                string surname = dr["surname"].ToString();
                string name = dr["name"].ToString();
                string dob = dr["dateOfBirth"].ToString();
                string sex = dr["sex"].ToString();
                string majorID = dr["majorID"].ToString();

                StudentDTO temp =
                    new StudentDTO(studentID, surname, name, dob, sex, majorID);

                listStudents.Add(temp);
            }

            dr.Close();

            return listStudents;
        }

        public Boolean AddNewStudent(string studentID, string surname, string name, string dob, string sex, string majorID)
        {
            // Get connection string / provider from *.config
            string database = ConfigurationManager.AppSettings["provider"];
            string connectionString = ConfigurationManager.ConnectionStrings["SqlProviderPubs"].ConnectionString;

            // Make a factory provider
            DbProviderFactory df = DbProviderFactories.GetFactory(database);

            // Make connection object
            DbConnection cn = df.CreateConnection();
            cn.ConnectionString = connectionString;
            cn.Open();


            // Make command obj
            DbCommand command = df.CreateCommand();
            command.Connection = cn;

            string sqlString = string.Format("INSERT INTO student " +
                "VALUES('{0}', '{1}', '{2}', '{3}', '{4}', '{5}')", 
                studentID, surname, name, Convert.ToDateTime(dob), sex, majorID);

            command.CommandText = sqlString;

            try
            {
                int result = command.ExecuteNonQuery();
                if (result > 0)
                {
                    return true;
                }
                return false;
            }
            catch
            {
                Console.WriteLine("Error");
                return false;
            }
        }

        public Boolean DeleteStudent(string studentID)
        {
            // Get connection string / provider from *.config file
            string database = ConfigurationManager.AppSettings["provider"];
            string connectionString = ConfigurationManager.ConnectionStrings["SqlProviderPubs"].ConnectionString;

            // Make a factory provider
            DbProviderFactory df = DbProviderFactories.GetFactory(database);

            // Make connection object
            DbConnection cn = df.CreateConnection();
            cn.ConnectionString = connectionString;
            cn.Open();

            // Make command object
            DbCommand command = df.CreateCommand();
            command.Connection = cn;

            string sqlString = string.Format("DELETE FROM student " +
                "WHERE studentID='{0}'", studentID);

            command.CommandText = sqlString;
            try
            {
                int result = command.ExecuteNonQuery();
                if (result > 0)
                {
                    return true;
                }
                return false;
            }
            catch
            {
                Console.WriteLine("Error");
                return false;
            }
        }

        public Boolean UpdateStudent(string studentID, string surname, string name, string dob, string sex, string majorID)
        {
            // Get connection string / provider from *.config file
            string database = ConfigurationManager.AppSettings["provider"];
            string connectionString = ConfigurationManager.ConnectionStrings["SqlProviderPubs"].ConnectionString;

            // Make a factory provider
            DbProviderFactory df = DbProviderFactories.GetFactory(database);

            // Make connection object
            DbConnection cn = df.CreateConnection();
            cn.ConnectionString = connectionString;
            cn.Open();

            // Make command object
            DbCommand command = df.CreateCommand();
            command.Connection = cn;

            string sqlString = string.Format("Update student " +
                "SET studentID='{0}', surname='{1}', name='{2}', dateOfBirth='{3}', sex='{4}', majorID='{5}' " +
                "WHERE studentID='{0}'", 
                studentID, surname, name, Convert.ToDateTime(dob), sex, majorID);

            command.CommandText = sqlString;

            try
            {
                int result = command.ExecuteNonQuery();

                if(result > 0)
                {
                    return true;
                }
                return false;
            }
            catch
            {
                Console.WriteLine("Error");
                return false;
            }
        }
    }
}
