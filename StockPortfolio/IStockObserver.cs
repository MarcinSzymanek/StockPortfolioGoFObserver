using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockPortfolio
{
    internal interface IStockObserver
    {
        void Notify(string name, double val);
    }
}
