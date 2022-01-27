using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using static System.Console;

namespace Packt.Shared;
internal class Northwind : DbContext
{
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        if (ProjectConstants.DatabaseProvider == "SQLite")
        {
            string path = Path.Combine(Environment.CurrentDirectory, "Northwind.db");
            WriteLine($"using {path} database file.");
            optionsBuilder.UseSqlite($"Filename={path}");
        }
        else
        {
            string connection = "Data Source =.;" + "Initial Catalog = Northwind;"
        }
    }
}