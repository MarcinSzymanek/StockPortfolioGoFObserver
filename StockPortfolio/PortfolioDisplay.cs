using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockPortfolio
{
    internal class PortfolioDisplay
    {
        const string _separator = "\n---------\n";
        const string _separateNameAndVal = " : ";
        public void UpdateDisplay(List<OwnedStock> ownedStocks)
        {
            Console.WriteLine("Currently owned stocks: \n");
            foreach (var ownedStock in ownedStocks)
            {
                Console.Write(ownedStock.GetName() + _separateNameAndVal + ownedStock.GetValue() + "$ " + ownedStock.GetOwnedAmount() + " owned.");
                Console.Write(_separator);
            }
        }
    }
}
