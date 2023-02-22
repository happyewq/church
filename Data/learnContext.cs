using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using learn.Models;

namespace learn.Data
{
    public class learnContext : DbContext
    {
        public learnContext (DbContextOptions<learnContext> options)
            : base(options)
        {
        }

        public DbSet<learn.Models.Class4> Class4 { get; set; } = default!;
    }
}
