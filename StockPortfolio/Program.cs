// See https://aka.ms/new-console-template for more information
using StockPortfolio;

Console.WriteLine("Stock portfolio update using GoF Observer pattern.");

PortfolioManager myPortfolioManager = new PortfolioManager();

Stock shiva = new Stock("Shiva", 21.2, 1000);
Stock tesla = new Stock("Tesla", 6.66, 500);
Stock mitsubishi = new Stock("Mitsubishi", 100, 2000);

Console.WriteLine("Stocks created.");

myPortfolioManager.AddStock(shiva);
shiva.AttachObserver(myPortfolioManager);

myPortfolioManager.AddStock(tesla);
tesla.AttachObserver(myPortfolioManager);

myPortfolioManager.AddStock(mitsubishi);
mitsubishi.AttachObserver(myPortfolioManager);

shiva.UpdateStock(shiva.GetAmount(), 25);

System.Threading.Thread.Sleep(2000);

mitsubishi.UpdateStock(mitsubishi.GetAmount(), 101.1);