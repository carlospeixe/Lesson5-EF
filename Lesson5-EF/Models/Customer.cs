using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Lesson5_EF.Models
{
    public class Customer
    {
        public int CustomerId { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
    }
}