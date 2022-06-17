using System;
using System.Collections.Generic;
using System.Text;

namespace GameApp
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string IdentityNumber { get; set; }
        public DateTime? DateOfBirth { get; set; }
    }
}
