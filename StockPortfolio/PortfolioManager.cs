using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockPortfolio
{
    internal class PortfolioManager : IStockObserver
    {
        private Portfolio _portfolio;
        private PortfolioDisplay _display;
        public PortfolioManager()
        {
            _portfolio = new Portfolio();
            _display = new PortfolioDisplay();
        }
        public void AddStock(string name, double val, int amount)
        {
            _portfolio.AddStock(name, val, amount);
        }

        public void AddStock(Stock s)
        {
            _portfolio.AddStock(s.GetName(), s.GetValue(), 100);
        }

        public void Notify(string name, double val)
        {
            _portfolio.UpdateStockValue(name, val);
            _display.UpdateDisplay(_portfolio.GetOwnedStocks());
        }
    }
}
