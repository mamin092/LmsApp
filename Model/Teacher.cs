using Common.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace Model
{
   public class Teacher : Entity
    {    
        public string Name { get; set; }
        public string Phone { get; set; }
        public string Course { get; set; }
        public double TotalCredit { get; set; }

    }
}
