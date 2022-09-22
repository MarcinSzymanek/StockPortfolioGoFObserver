using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockPortfolio
{
    internal interface IStock
    {
        double GetValue();
        string GetName();
    }
}
