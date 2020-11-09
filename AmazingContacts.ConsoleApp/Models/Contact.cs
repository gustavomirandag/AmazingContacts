﻿using System;
using System.Collections.Generic;
using System.Text;

namespace AmazingContacts.ConsoleApp.Models
{
    public class Contact
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
    }
}
