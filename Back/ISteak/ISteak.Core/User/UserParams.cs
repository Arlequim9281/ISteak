﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISteak.Core.User
{
    public class UserParams
    {
        public string? Name { get; set; }
        public string? AccessKey { get; set; }
        public string? Password { get; set; }
        public string? Email { get; set; }
        public string? Phone { get; set; }
        public int? AccessCount { get; set; }
        public string? Note { get; set; }
       
    }
}