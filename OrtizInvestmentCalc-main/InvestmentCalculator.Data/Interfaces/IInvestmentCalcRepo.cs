using InvestmentCalculator.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InvestmentCalculator.Data.Interfaces
{
    public interface IInvestmentCalcRepo
    {

        //Crud Methods
        //Category CRUD     
        Task<List<InvestmentCalc>> GetInvestmentCalcsAsync();

        Task<InvestmentCalc?> GetInvestmentCalcAsync(int id);

        Task<InvestmentCalc> SaveInvestmentCalcAsync(InvestmentCalc item);

        Task DeleteInvestmentCalcAsync(InvestmentCalc item);

        //Task<int> GetInvestmentCalcCountAsync();
        //Task<List<InvestmentCalc>> GetInvestmentCalcsAsync();
        //Task<InvestmentCalc?> GetInvestmentCalcAsync(int id);
        //Task<InvestmentCalc> SaveInvestmentCalcAsync(InvestmentCalc item);
        //Task DeleteInvestmentCalcAsync(InvestmentCalc item);

    }
}
