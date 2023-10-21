using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace STOCKUI2
{
    internal class PortfolioManager : TransactionDB
    { 
        private PortfolioDB db;

        public PortfolioManager()
        {
            db = new PortfolioDB();
        }
        public List<string> GetTickers()
        {
            return GetInvestmentTickers();
        }

        public double GetProportion(string ticker)
        {
            return Math.Round((db.GetMoneyInvestedForTicker(ticker) / db.GetTotalMoneyInvested())*100,3);
        
        }
    }
}
