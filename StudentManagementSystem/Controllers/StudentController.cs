using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using StudentManagementSystem.Models;
using System.Data.SqlClient;
using System.Data;

namespace StudentManagementSystem.Controllers
{
    public class StudentController : Controller
    {
        private string _connectionString = @"Data Source=LAPTOP-ORLFEUDE\SQLEXPRESS;Initial Catalog=Skool;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        
        // GET: Student
        public ActionResult Index()
        {
            // Create string that represents the SQL Query statement - what part of the database do we want to retrieve for this method/view
            string queryString = "SELECT * FROM Skool";
            // Create new list of students to populate
            List<Students> students = new List<Students>();

            // Create SqlConnection object using connection string
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                // Create SqlCommand object - it tells SQL:
                //     1) What we want to query (queryString)
                //     2) Where to find the database (connection)
                SqlCommand command = new SqlCommand(queryString, connection);
                connection.Open();
                // Create SqlDataReader object that executes the SqlCommand.ExecuteReader() method.
                SqlDataReader reader = command.ExecuteReader();

                // This reader goes through each database row MATCHING THE QUERY STATEMENT and populates a list of Students objects
                while (reader.Read())
                {
                    Students student = new Students();
                    student.Id = Convert.ToInt32(reader["Id"]);
                    student.FirstName = reader["FirstName"].ToString();
                    student.LastName = reader["LastName"].ToString();
                    students.Add(student);
                }
                connection.Close();
            }
            return View(students);
        }

        public ActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Add(Students student)
        {
            // INSERT INTO tbl_name (col1, col2) VALUES (col1.data, col2.data)
            string queryString = @"INSERT INTO Skool (FirstName, LastName) VALUES (@FirstName, @LastName)";

            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                SqlCommand command = new SqlCommand(queryString, connection);

                // Define parameters of the queryString - these should align with the parentheses after VALUES
                command.Parameters.Add("@FirstName", SqlDbType.VarChar);
                command.Parameters.Add("@LastName", SqlDbType.VarChar);

                // Set values of the parameters defined above
                command.Parameters["@FirstName"].Value = student.FirstName;
                command.Parameters["@LastName"].Value = student.LastName;

                connection.Open();
                // I *think* this is just used when we are actually modifying or populating data instead of just retrieving it
                command.ExecuteNonQuery();
                connection.Close();
            }
            return RedirectToAction("Index");
        }

        public ActionResult Details(int id)
        {
            string queryString = "SELECT * FROM Skool WHERE id = @id";
            Students student = new Students();

            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                SqlCommand command = new SqlCommand(queryString, connection);

                command.Parameters.Add("@id", SqlDbType.Int);

                command.Parameters["@id"].Value = id;

                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    student.Id = Convert.ToInt32(reader["Id"]);
                    student.FirstName = reader["FirstName"].ToString();
                    student.LastName = reader["LastName"].ToString();
                }
                connection.Close();
            }
                return View(student);
        }

        public ActionResult Edit(int id)
        {
            string queryString = "SELECT * FROM Skool WHERE id = @id";
            Students student = new Students();

            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                SqlCommand command = new SqlCommand(queryString, connection);

                command.Parameters.Add("@id", SqlDbType.Int);

                command.Parameters["@id"].Value = id;

                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    student.Id = Convert.ToInt32(reader["Id"]);
                    student.FirstName = reader["FirstName"].ToString();
                    student.LastName = reader["LastName"].ToString();
                }
                connection.Close();
            }
            return View(student);
        }

        [HttpPost]
        public ActionResult Edit(Students student)
        {
            string queryString = @"UPDATE Skool SET FirstName = @firstName, LastName = @lastName WHERE Id = @Id";

            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                SqlCommand command = new SqlCommand(queryString, connection);

                command.Parameters.Add("@Id", SqlDbType.Int);
                command.Parameters.Add("@firstName", SqlDbType.VarChar);
                command.Parameters.Add("@lastName", SqlDbType.VarChar);

                command.Parameters["@Id"].Value = student.Id;
                command.Parameters["@firstName"].Value = student.FirstName;
                command.Parameters["@lastName"].Value = student.LastName;

                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();
            }
            return RedirectToAction("Index");
        }
    }
}