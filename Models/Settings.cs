﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppFinalCore.Models
{
    public class Settings
    {
        public int SettingsId { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }
      
    }
}
