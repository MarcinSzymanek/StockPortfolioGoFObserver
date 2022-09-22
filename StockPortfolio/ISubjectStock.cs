using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockPortfolio
{
    internal interface ISubjectStock
    {
        void AttachObserver(IStockObserver o);
        void DetachObserver(IStockObserver o);
        void NotifyObservers();
    }
}
