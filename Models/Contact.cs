﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CommandosITWebApp.Models
{
    public class Contact
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Email { get; set; }
        public string Category { get; set; }
        public string PhoneNumber { get; set; }
        public string BirthDate { get; set; }
        


        public Contact()
        {

        }
    }
}
