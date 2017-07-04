using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Moto.Api.Entities
{
    public class MotocyklContext : DbContext
    {
        public MotocyklContext(DbContextOptions<MotocyklContext> options) : base(options)
        {
            Database.Migrate();
        }

        public DbSet<Motocykl> Motocykle { get; set; }        
    }
}
