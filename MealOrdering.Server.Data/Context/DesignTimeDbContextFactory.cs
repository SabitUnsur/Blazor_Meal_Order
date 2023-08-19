using Microsoft.EntityFrameworkCore.Design;
<<<<<<< HEAD
using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
=======
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
>>>>>>> 9e6b9473dcf2cd01f3c11c3d90412de78c5a2a62

namespace MealOrdering.Server.Data.Context
{
    public class DesignTimeDbContextFactory : IDesignTimeDbContextFactory<MealOrderingDbContext>
    {
        public MealOrderingDbContext CreateDbContext(string[] args)
        {
            String connectionString = "User ID=postgres;password=123;Host=localhost;Port=5432;Database=MealOrdering;SearchPath=public";

            var builder = new DbContextOptionsBuilder<MealOrderingDbContext>();
<<<<<<< HEAD
            
=======

>>>>>>> 9e6b9473dcf2cd01f3c11c3d90412de78c5a2a62
            builder.UseNpgsql(connectionString);

            return new MealOrderingDbContext(builder.Options);
        }
    }
}
