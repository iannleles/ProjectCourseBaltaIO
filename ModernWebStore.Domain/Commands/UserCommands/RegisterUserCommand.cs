﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModernWebStore.Domain.Commands.UserCommands
{
    public class RegisterUserCommand
    {
        public string Email { get; set; }
        public string Password { get; set; }
        public bool IsAdmin { get; set; }

        public RegisterUserCommand(string email, string password, bool isAdmin)
        {
            this.Email = email;
            this.Password = password;
            this.IsAdmin = isAdmin;
        }
    }
}
