using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CodeCoverage.Models
{
    public class Contact
    {
        public string firstName { get; set; }

        public string lastName { get; set; }

        public string fullName { get; set; }

        public void ConstructName(CodeCoverage.Models.Contact contcat)
        {
            string fullName = "";
            if (!String.IsNullOrEmpty(contcat.firstName) && !String.IsNullOrEmpty(contcat.lastName))
            {
                contcat.fullName = contcat.firstName + " " + contcat.lastName;
            }
        }
    }
}