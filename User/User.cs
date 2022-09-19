using System;

namespace User
{
    internal class User
    {
        private DateTime dateSubmited = DateTime.UtcNow;

        public string Login { get; set; }

        public string Name { get; set; }

        public string Surname { get; set; }

        public int Age { get; set; }

        public DateTime DateSubmited
        {
            get
            {
                return dateSubmited;
            }
        }
    }
}

