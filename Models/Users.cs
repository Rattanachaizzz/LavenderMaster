using System;
using System.Collections.Generic;

namespace LavenderMaster.Models
{
    public partial class Users
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Password { get; set; }
        public string Role { get; set; }
        public DateTime? CreateDate { get; set; }
    }
}
