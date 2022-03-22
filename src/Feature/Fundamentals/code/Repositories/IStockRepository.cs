using System.Collections.Generic;
using System.Threading.Tasks;
using Sitecore.Feature.Fundamentals.Models;

// C# 70-483 Exam Competency: Working with classes and methods.
    // https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/classes-and-structs/
    // https://app.pluralsight.com/library/courses/csharp-solid-principles/table-of-contents

namespace Sitecore.Feature.Fundamentals.Repositories
{
    public interface IStockRepository
    {
        List<Stock> GetStocks();
        List<StockAlert> GetStockAlerts();
        List<Stock> PriceAlert();

        //Task<List<Stock>> GetStocks();
        //Task<List<StockAlert>> GetStockAlerts();
    }

    public class StockService : IStockRepository
    {
        // C# 70-483 Exam Competency: Working with arrays and collections.
        public List<StockAlert> GetStockAlerts()
        {
            return new List<StockAlert>()
            {
                new StockAlert() { Alert = "Annual Report"},
                new StockAlert() { Alert = "Bull Market"},
                new StockAlert() { Alert = "Bear Market"},
                new StockAlert() { Alert = "Averaging Down"},
                new StockAlert() { Alert = "Beta"},
                new StockAlert() { Alert = "Blue Chip Stocks"},
                new StockAlert() { Alert = "High"},
                new StockAlert() { Alert = "Low"},
                new StockAlert() { Alert = "Open"},
                new StockAlert() { Alert = "Closed"}
            };
        }

        public List<Stock> GetStocks()
        {
            return new List<Stock>()
            {
                new Stock() { Id = 0, Name = "A", Volume = 157838, Alert=""},
                new Stock() { Id = 1, Name = "AAL", Volume = 5634500, Alert=""},
                new Stock() { Id = 2, Name = "AAN", Volume = 414138, Alert=""},
                new Stock() { Id = 3, Name = "AAON", Volume = 118551, Alert=""},
                new Stock() { Id = 4, Name = "AAP", Volume = 337160, Alert=""},
                new Stock() { Id = 5, Name = "AAPL", Volume = 99756489, Alert=""},
                new Stock() { Id = 6, Name = "AAT", Volume = 156242, Alert=""},
                new Stock() { Id = 7, Name = "AAWW", Volume = 164808, Alert=""},
                new Stock() { Id = 8, Name = "ABCD", Volume = 1165854, Alert=""},
                new Stock() { Id = 9, Name = "ABM", Volume = 7294962, Alert=""}
            };
        }

        public List<Stock> PriceAlert()
        {
            var stocks = GetStocks();

            //foreach (var stock in stocks)
            //{
            //    if (stock.Volume < 1000000)
            //    {
            //        stock.Alert = "LOW";
            //    }
            //    if (stock.Volume > 5000000)
            //    {
            //        stock.Alert = "HIGH";
            //    }
            //}

            // Parallel.ForEach(source, (element) =>{});
            // Blocks the calling thread until all parallel operations complete.
            Parallel.ForEach(stocks, (stock) =>
            {
                if (stock.Volume < 1000000)
                {
                    stock.Alert = "LOW";
                }
                if (stock.Volume > 5000000)
                {
                    stock.Alert = "HIGH";
                }
            });

            return stocks;
        }

        //public async Task<List<StockAlert>> GetStockAlerts()
        //{
        //    return await Task.FromResult(new List<StockAlert>()
        //    {
        //        new StockAlert() { Alert = "Annual Report"},
        //        new StockAlert() { Alert = "Bull Market"},
        //        new StockAlert() { Alert = "Bear Market"},
        //        new StockAlert() { Alert = "Averaging Down"},
        //        new StockAlert() { Alert = "Beta"},
        //        new StockAlert() { Alert = "Blue Chip Stocks"},
        //        new StockAlert() { Alert = "High"},
        //        new StockAlert() { Alert = "Low"},
        //        new StockAlert() { Alert = "Open"},
        //        new StockAlert() { Alert = "Closed"}
        //    });
        //}

        //public async Task<List<Stock>> GetStocks()
        //{
        //    return await Task.FromResult(new List<Stock>()
        //    {
        //        new Stock() { Id = 0, Name = "A"},
        //        new Stock() { Id = 1, Name = "AAL"},
        //        new Stock() { Id = 2, Name = "AAN"},
        //        new Stock() { Id = 3, Name = "AAON"},
        //        new Stock() { Id = 4, Name = "AAP"},
        //        new Stock() { Id = 5, Name = "AAPL"},
        //        new Stock() { Id = 6, Name = "AAT"},
        //        new Stock() { Id = 7, Name = "AAWW"},
        //        new Stock() { Id = 8, Name = "ABCD"},
        //        new Stock() { Id = 9, Name = "ABM"}
        //    });
        //}
    }
}
