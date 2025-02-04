﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistem_za_upravljanje_sadrzajima
{
    public enum UserRole { ADMIN, VISITOR };
    [Serializable]
    public class User
    {
        public String Username { get; set; }
        public String Password { get; set; }
        public UserRole UserRole { get; set; }

        public User()
        {

        }

        public User(string username, string password, UserRole userRole)
        {
            this.Username = username;
            this.Password = password;
            this.UserRole = userRole;
        }
    }
}
