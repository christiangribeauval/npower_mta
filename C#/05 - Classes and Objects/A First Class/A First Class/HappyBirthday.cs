using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A_First_Class
{
    static class HappyBirthday
    {
        public static string GetMessage { get; set; }
        static HappyBirthday()
        {
            GetMessage = "Happy Birthday ";
        }
        
    }
}
