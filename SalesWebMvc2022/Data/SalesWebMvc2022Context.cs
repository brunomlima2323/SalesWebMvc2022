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

        public DbSet<SalesWebMvc2022.Models.Department> Department { get; set; }
    }
}
