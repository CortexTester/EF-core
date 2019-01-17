using System;
using System.Collections.Generic;

namespace CBX.Domain
{
    public class Party
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Protocol Protocol { get; set; }
        public List<User> Users { get; set; }
    }
}
