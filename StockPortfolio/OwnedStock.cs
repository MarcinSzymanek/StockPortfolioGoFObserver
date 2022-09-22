using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockPortfolio
{
    internal class OwnedStock : BaseStock, IStock
    {
        private int _ownedAmount; 
        public OwnedStock(string name, double val, int ownedAmount)
        {
            _name = name;
            _value = val;
            _ownedAmount = ownedAmount;
        }
        public string GetName() { return _name; }
        public double GetValue() { return _value; }
        public int GetOwnedAmount() { return _ownedAmount; }
        public void UpdateValue(double val) { _value = val; }
        public void UpdateAmount(int amount) { _ownedAmount = amount; }
    }
}
