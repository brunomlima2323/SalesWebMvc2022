using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SalesWebMvc2022.Models;

namespace SalesWebMvc2022.Data
{
    public class SalesWebMvc2022Context : DbContext
    {
        public SalesWebMvc2022Context (DbContextOptions<SalesWebMvc2022Context> options)
            : base(options)
        {
        }

        public DbSet<Department> Department { get; set; }
        public DbSet<Seller> Seller { get; set; }
        public DbSet<SalesRecord> SalesRecord { get; set; }
    }
}
