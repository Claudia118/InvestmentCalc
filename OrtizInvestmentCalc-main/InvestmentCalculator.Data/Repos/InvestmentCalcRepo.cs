using InvestmentCalculator.Data.Interfaces;
using InvestmentCalculator.Data.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InvestmentCalculator.Data.Repos
{
    public class InvestmentCalcRepo : IInvestmentCalcRepo
    {
        private IDbContextFactory<InvestmentCalcDbContext> factory;

        //constructor
        public InvestmentCalcRepo(IDbContextFactory<InvestmentCalcDbContext> factory)
        {
            this.factory = factory;
        }

        //InvestmentCalc CRUD
        public async Task<List<InvestmentCalc>> GetInvestmentCalcsAsync()
        {
            using var context = factory.CreateDbContext();
            return await context.InvestmentCalcs.ToListAsync();
        }

        public async Task<InvestmentCalc?> GetInvestmentCalcAsync(int id)
        {
            using var context = factory.CreateDbContext();
            return await context.InvestmentCalcs.Where(i => i.Id == id).FirstOrDefaultAsync();
        }

        public async Task<InvestmentCalc> SaveInvestmentCalcAsync(InvestmentCalc item)
        {
            using var context = factory.CreateDbContext();
            if (item.Id == 0) //Add new item
            {
                context.InvestmentCalcs.Add(item);
            }
            else //Update old item
            {
                context.Entry(item).State = EntityState.Modified;
            }
            await context.SaveChangesAsync();
            return item;
        }

        public async Task DeleteInvestmentCalcAsync(InvestmentCalc item)
        {
            using var context = factory.CreateDbContext();
            context.Remove(item);
            await context.SaveChangesAsync();
        }

        ////Investment Calc CRUD
        //public async Task<int> GetInvestmentCalcCountAsync()
        //{
        //    using var context = factory.CreateDbContext();
        //    return await context.InvestmentCalcs.CountAsync();
        //}

        //public async Task<List<InvestmentCalc>> GetInvestmentCalcsAsync()
        //{
        //    using var context = factory.CreateDbContext();
        //    return await context.InvestmentCalcs.ToListAsync();
        //}

        //public async Task<InvestmentCalc?> GetInvestmentCalcAsync(int id)
        //{
        //    using var context = factory.CreateDbContext();
        //    return await context.InvestmentCalcs.Where(i => i.Id == id).FirstOrDefaultAsync();
        //}

        //public async Task<InvestmentCalc> SaveInvestmentCalcAsync(InvestmentCalc item)
        //{
        //    using var context = factory.CreateDbContext();
        //    if (item.Id == 0)
        //    {
        //        context.InvestmentCalcs.Add(item);
        //    }
        //    else
        //    {
        //        context.Entry(item).State = EntityState.Modified;
        //    }
        //    await context.SaveChangesAsync();
        //    return item;
        //}

        //public async Task DeleteInvestmentCalcAsync(InvestmentCalc item)
        //{
        //    using var context = factory.CreateDbContext();
        //    context.Remove(item);
        //    await context.SaveChangesAsync();
        //}
    }
}
