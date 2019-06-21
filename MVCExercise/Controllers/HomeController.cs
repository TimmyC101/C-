using MVCExercise.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCExercise.Controllers
{
    public class HomeController : Controller
    {
        private readonly string connectionString = @"Data Source=LAPTOP-ORLFEUDE\SQLEXPRESS;Initial Catalog=Insurance;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Quote(string firstName, string lastName, string emailAddress, DateTime birthDate, int carYear, string carMake, string carModel, int dui, int tickets, string coverage)
        {
            if (string.IsNullOrEmpty(firstName) || string.IsNullOrEmpty(lastName) || string.IsNullOrEmpty(emailAddress))
            {
                return View("~/Views/Shared/Error.cshtml");
            }
            else
            {
                // Create person as a global variable
                Person person = new Person();

                //Calculate quote prior to DB entry
                DateTime today = DateTime.Today;
                int age = today.Year - birthDate.Year;
                decimal quote = 50;
                if (age < 18)
                {
                    quote += 100;
                }
                else if (age < 25)
                {
                    quote += 25;
                }
                if (age > 100)
                {
                    quote += 25;
                }
                if (carYear < 2000)
                {
                    quote += 25;
                }
                if (carYear > 2015)
                {
                    quote += 25;
                }
                if (carMake == "Porsche")
                {
                    quote += 25;
                }
                else if (carMake == "Porsche" && carModel == "Carrera")
                {
                    quote += 50;
                }
                for (int i = 0; i < tickets; i++)
                {
                    quote += 10;
                }
                if (dui == 1)
                {
                    quote = quote * 1.25m;
                }
                if (coverage.ToLower() == "full")
                {
                    quote = quote * 1.5m;
                }

                //Insert person info into DB
                string queryString = @"INSERT INTO Persons (FirstName, LastName, EmailAddress, BirthDate, CarYear, CarMake, CarModel, DUI, Tickets, Coverage, Quote) 
                                        VALUES (@FirstName, @LastName, @EmailAddress, @BirthDate, @CarYear, @CarMake, @CarModel, @DUI, @Tickets, @Coverage, @Quote)";

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    SqlCommand com = new SqlCommand(queryString, connection);

                    com.Parameters.Add("@FirstName", SqlDbType.VarChar);
                    com.Parameters.Add("@LastName", SqlDbType.VarChar);
                    com.Parameters.Add("@EmailAddress", SqlDbType.VarChar);
                    com.Parameters.Add("@Birthdate", SqlDbType.DateTime);
                    com.Parameters.Add("@CarYear", SqlDbType.Int);
                    com.Parameters.Add("@CarMake", SqlDbType.VarChar);
                    com.Parameters.Add("@CarModel", SqlDbType.VarChar);
                    com.Parameters.Add("@DUI", SqlDbType.Bit);
                    com.Parameters.Add("@Tickets", SqlDbType.Int);
                    com.Parameters.Add("@Coverage", SqlDbType.VarChar);
                    com.Parameters.Add("@Quote", SqlDbType.Int);

                    com.Parameters["@FirstName"].Value = firstName;
                    com.Parameters["@LastName"].Value = lastName;
                    com.Parameters["@EmailAddress"].Value = emailAddress;
                    com.Parameters["@BirthDate"].Value = birthDate;
                    com.Parameters["@CarYear"].Value = carYear;
                    com.Parameters["@CarMake"].Value = carMake;
                    com.Parameters["@CarModel"].Value = carModel;
                    com.Parameters["@DUI"].Value = dui;
                    com.Parameters["@Tickets"].Value = tickets;
                    com.Parameters["@Coverage"].Value = coverage;
                    com.Parameters["@Quote"].Value = quote;

                    connection.Open();
                    com.ExecuteNonQuery();
                    connection.Close();

                    // Create person object to send to Quote View as a model
                    person.FirstName = firstName;
                    person.LastName = lastName;
                    person.EmailAddress = emailAddress;
                    person.BirthDate = birthDate;
                    person.CarYear = carYear;
                    person.CarMake = carMake;
                    person.CarModel = carModel;
                    person.DUI = dui;
                    person.Tickets = tickets;
                    person.Coverage = coverage;
                    person.Quote = quote;                   

                }
                return View(person);
            }
        }
    }
}