using NewsletterAppMVC.Models;
using NewsletterAppMVC.ViewModels;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NewsletterAppMVC.Controllers
{
    public class HomeController : Controller
    {
        //private readonly string connectionString = @"Data Source=LAPTOP-ORLFEUDE\SQLEXPRESS;Initial Catalog=Newsletter;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult SignUp(string firstName, string lastName, string emailAddress)
        {
            if (string.IsNullOrEmpty(firstName) || string.IsNullOrEmpty(lastName) || string.IsNullOrEmpty(emailAddress))
            {
                return View("~/Views/Shared/Error.cshtml");
            }
            else
            {
                //string queryString = @"INSERT INTO SignUps (FirstName, LastName, EmailAddress) VALUES (@firstName, @lastName, @emailAddress)";

                //using (SqlConnection connection = new SqlConnection(connectionString))
                //{
                //    SqlCommand command = new SqlCommand(queryString, connection);

                //    command.Parameters.Add("@firstName", SqlDbType.VarChar);
                //    command.Parameters.Add("@lastName", SqlDbType.VarChar);
                //    command.Parameters.Add("@emailAddress", SqlDbType.VarChar);

                //    command.Parameters["@firstName"].Value = firstName;
                //    command.Parameters["@lastName"].Value = lastName;
                //    command.Parameters["@emailAddress"].Value = emailAddress;

                //    connection.Open();
                //    command.ExecuteNonQuery();
                //    connection.Close();
                //}
                using (NewsletterEntities db = new NewsletterEntities())
                {
                    var signup = new SignUp();
                    signup.FirstName = firstName;
                    signup.LastName = lastName;
                    signup.EmailAddress = emailAddress;
                    db.SignUps.Add(signup);
                    db.SaveChanges();
                }
                return View("Success");
            }
        }

            //List<NewsletterSignUp> signups = new List<NewsletterSignUp>();
            //string queryString = @"SELECT * FROM SignUps";

            //using (SqlConnection connection = new SqlConnection(connectionString))
            //{
            //    SqlCommand command = new SqlCommand(queryString, connection);

            //    connection.Open();

            //    SqlDataReader reader = command.ExecuteReader();
            //    while (reader.Read())
            //    {
            //        NewsletterSignUp signup = new NewsletterSignUp();
            //        signup.Id = Convert.ToInt32(reader["Id"]);
            //        signup.FirstName = reader["FirstName"].ToString();
            //        signup.LastName = reader["LastName"].ToString();
            //        signup.EmailAddress = reader["EmailAddress"].ToString();
            //        signup.SSN = reader["SSN"].ToString();
            //        signups.Add(signup);
            //    }
            //}

            //List<SignUpVm> signupVms = new List<SignUpVm>();
            //foreach (var signup in signups)
            //{
            //    var signupVm = new SignUpVm();
            //    signupVm.FirstName = signup.FirstName;
            //    signupVm.LastName = signup.LastName;
            //    signupVm.EmailAddress = signup.EmailAddress;
            //}
            //return View(signupVms);
    }
}