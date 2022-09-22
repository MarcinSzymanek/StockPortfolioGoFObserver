using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockPortfolio
{
    internal class Portfolio
    {
        List<OwnedStock> _ownedStocks;
        public Portfolio()
        {
            _ownedStocks = new List<OwnedStock>();
        }
        public List<OwnedStock> GetOwnedStocks() { return _ownedStocks; }
        public void AddStock(string name, double val, int amount)
        {
            OwnedStock stock = SearchStock(name);
            
            if(stock == null)
            {
                _ownedStocks.Add(new OwnedStock(name, val, amount));
            }
        }

        public void UpdateStockValue(string name, double val)
        {
            OwnedStock stock = SearchStock(name);

            if (stock != null)
            {
                stock.UpdateValue(val);
            }
        }

        // Search for a specific stock by name
        public OwnedStock SearchStock(string name)
        {
            foreach (OwnedStock stock in _ownedStocks)
            {
                if (stock.GetName() == name)
                {
                    return stock;
                }
            }
            return null;
        }
    }
}
