using System;
using System.Collections.Generic;

namespace BurgerAPI.Models
{
    public partial class Burger
    {
        public byte BurgerId { get; set; }
        public string Bun { get; set; }
        public string Patty { get; set; }
    }
}
