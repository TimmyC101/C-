using MVCExercise.Models;
using MVCExercise.ViewModels;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCExercise.Controllers
{
    public class AdminController : Controller
    {
        private readonly string connectionString = @"Data Source=LAPTOP-ORLFEUDE\SQLEXPRESS;Initial Catalog=Insurance;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        // GET: Admin
        public ActionResult Index()
        {
            List<PersonVm> db = new List<PersonVm>();
            string queryString = @"SELECT * FROM Persons";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand com = new SqlCommand(queryString, connection);
                connection.Open();

                SqlDataReader reader = com.ExecuteReader();
                while (reader.Read())
                {
                    PersonVm person = new PersonVm();
                    person.FirstName = reader["FirstName"].ToString();
                    person.LastName = reader["LastName"].ToString();
                    person.EmailAddress = reader["EmailAddress"].ToString();
                    person.Quote = Convert.ToDecimal(reader["Quote"]);
                    db.Add(person);
                }
            }
            return View(db);
        }
    }
}