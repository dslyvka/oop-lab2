using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace User
{
    internal class Program
    {
        static void Main(string[] args)
        {
            User user = new User();
            user.Surname = "Danyil";
            user.Name = "Slyvka";
            user.Login = "dslyvka";
            user.Age = 20;

            foreach (PropertyInfo property in user.GetType().GetProperties())
            {
                Console.WriteLine(property.Name + ": " + property.GetValue(user, null));
            }
        }
    }
}
