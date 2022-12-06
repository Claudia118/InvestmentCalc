using InvestmentCalculator.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InvestmentCalculator.Data
{
    public class InvestmentCalcDbContext :DbContext
    {
        //Constructor
       public InvestmentCalcDbContext(DbContextOptions context):base(context)
        {

        }

        public DbSet<InvestmentCalc> InvestmentCalcs { get; set; }

        public class InvestmentCalcDbContextFactory : IDesignTimeDbContextFactory<InvestmentCalcDbContext>
        {
            public InvestmentCalcDbContext CreateDbContext(string[] args)
            {
                var optionsBuilder = new DbContextOptionsBuilder<InvestmentCalcDbContext>();
                optionsBuilder.UseSqlite("Data Source = ../InvestmentCalculator.db");
                return new InvestmentCalcDbContext(optionsBuilder.Options);
            }
        }
    }

}
