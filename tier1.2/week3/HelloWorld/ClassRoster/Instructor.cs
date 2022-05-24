using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassRoster
{
    internal class Instructor : Person
    {
        private string contactInfo;

        public Instructor(string newFirstName, string newLastName, string newContactInfo) : base(newFirstName, newLastName)
        {
            contactInfo = newContactInfo;
        }

        public string ContactInfo
        {
            get { return contactInfo; }
            set { contactInfo = value; }
        }

        public override string ToString()
        {
            return $"Instructor: {this.FirstName} {this.LastName} {this.ContactInfo}";
        }
    }
}
