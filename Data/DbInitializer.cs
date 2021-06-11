using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using test.Models;

namespace test.Data
{
    public static class DbInitializer
    {
        public static void Initialize(DbContext context) {
            context.Database.EnsureCreated();
            context.SaveChanges();
        }
    }
}
