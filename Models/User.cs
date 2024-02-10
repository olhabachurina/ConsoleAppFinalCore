using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppFinalCore.Models
{
    public class User
    {
        public int UserId { get; set; }
        public string Username { get; set; }
        public Settings Settings { get; set; }
        public List<Transaction> Transactions { get; set; }
    }
}
