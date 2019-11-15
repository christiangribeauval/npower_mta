using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A_First_Class
{
    class NotBirthday
    {
        private string getMessage2(string givenName)
        {
            string theMessage;

            theMessage = "It isnt your birthday " + givenName + "!\n";
            theMessage += "Number of presents = " + NumberOfPresents.ToString();

            return theMessage;
            
        }
        private string birthdayMessage;
        private int NumberOfPresents;

        public string MyProperty
        {
            get { return birthdayMessage; }
            set { birthdayMessage = getMessage2(value); }
        }

        public NotBirthday()
        {
            NumberOfPresents = 0;

        }
        public int presentCount
        {
            set { NumberOfPresents = value; }
        }
    }
}
