using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace University.Models
{
    public class Information
    {
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string Fathername { get; set; }
        public string Mothername { get; set; }
        public DateTime Dateofbirth { get; set; }
        public int Mobileno { get; set; }
        public string Village { get; set; }
        public string Thana { get; set; }
        public string District { get; set; }
        public string Country { get; set; }
    }
}