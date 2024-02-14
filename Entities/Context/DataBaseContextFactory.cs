using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Context
{
    public  class DataBaseContextFactory : IDesignTimeDbContextFactory<DataBaseContext>
    {
  
    
        public DataBaseContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<DataBaseContext>();
            optionsBuilder.UseSqlServer("Server=localhost\\SQLEXPRESS;Database=Tienda;Trusted_Connection=True;");

            return new DataBaseContext(optionsBuilder.Options);
        }
    }
}
