using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.EntityFrameworkCore;

namespace Infnet.EasyMediaLibrary.ConsoleApp.Infrastructure.Data
{
    public class DesignTimeDbContextFactory : IDesignTimeDbContextFactory<MediaLibraryDbContext>
    {
        public MediaLibraryDbContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<MediaLibraryDbContext>();
            optionsBuilder.UseSqlite("Data Source=mediaLibrary.db");

            return new MediaLibraryDbContext(optionsBuilder.Options);
        }
    }
}
