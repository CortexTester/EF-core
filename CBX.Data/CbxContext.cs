using CBX.Domain;
using Microsoft.EntityFrameworkCore;
using System;

namespace CBX.Data
{
    public class CbxContext : DbContext
    {
        public CbxContext(DbContextOptions<CbxContext> options) : base(options)
        { }
        public DbSet<Party> Parties { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Protocol> Protocols { get; set; }


    }
}
