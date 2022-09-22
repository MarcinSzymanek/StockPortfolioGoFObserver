using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockPortfolio
{
    internal class Stock : BaseStock, IStock, ISubjectStock
    {
        private List<IStockObserver> _observers;
        public string GetName() { return _name; }
        public double GetValue() { return _value; }
        public int GetAmount() { return _amount; }

        public void UpdateStock(int amount, double val)
        {
            _amount = amount;
            _value = val;
            Console.WriteLine("A stock has been updated.");
            NotifyObservers();
        }
        public Stock(string n, double val, int amount)
        {
            _observers = new List<IStockObserver>();
            _name = n;
            _value = val;
            _amount = amount;
        }

        int _amount;

        public void AttachObserver(IStockObserver o)
        {
            _observers.Add(o);
        }
        public void DetachObserver(IStockObserver o)
        {
            _observers.Remove(o);
        }

        public void NotifyObservers()
        {
            foreach(IStockObserver o in _observers)
            {
                o.Notify(_name, _value);
            }
        }
    }
}
