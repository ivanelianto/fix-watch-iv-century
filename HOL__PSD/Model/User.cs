using System;

namespace HOL__PSD.Model
{
    public class User
    {
        public String Username { get; set; }
        public String Name { get; set; }
        public String Password { get; set; }
        public DateTime Birthday { get; set; }

        public User() { }

        public User(String username, String name, String password, DateTime birthday)
        {
            this.Username = username;
            this.Name = name;
            this.Password = password;
            this.Birthday = birthday;
        }
    }
}
