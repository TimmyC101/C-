using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCExercise.Models
{
    public class Person
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string EmailAddress { get; set; }
        public DateTime BirthDate { get; set; }
        public int CarYear { get; set; }
        public string CarMake { get; set; }
        public string CarModel { get; set; }
        public int DUI { get; set; }
        public int Tickets { get; set; }
        public string Coverage { get; set; }
        public decimal Quote { get; set; }
    }
}