﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCExercise.ViewModels
{
    public class PersonVm
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string EmailAddress { get; set; }
        public decimal Quote { get; set; }
    }
}