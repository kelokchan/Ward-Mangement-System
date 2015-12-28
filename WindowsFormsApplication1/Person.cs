using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    /*This is the abstract superclass which is to be inherited by all other classes, because it contains
      all the necessary properties to serve as an outline for derived classes*/
    public abstract class Person
    {
        public string Name { get; set; }

        public string Gender { get; set; }

        public string ID { get; set; }

        [DisplayName("Date of birth")]  
        public DateTime DateOfBirth { get; set; }

        [DisplayName("Phone no")]  
        public string PhoneNo { get; set; }

        public string Email { get; set; }

        public string Address { get; set; }
    }
}
