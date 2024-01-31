using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Assessment31.Models
{
    public class Course
    {
        public int CId { get; set; }
        public string CName { get; set; }
        public double CFee { get; set; }
        public string Technology {  get; set; }
        public DateTime CStartData { get; set; }
        public DateTime CEndData { get; set;}
    }
}