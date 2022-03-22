using System;
using System.Linq;
using System.Web.Mvc;
using Sitecore.Diagnostics;
using Sitecore.Feature.Fundamentals.Models;
using Sitecore.Feature.Fundamentals.Repositories;

// C# 70-483 Exam Competency: Manage Program Flow and Events. Implement and Manage Multithreading and Asynchronous Processing. utilizing the Task Parallel Library and managing data.
// https://docs.microsoft.com/en-us/dotnet/standard/threading/using-threads-and-threading
// https://www.itprotoday.com/web-application-management/multithreading-aspnet-applications
// https://docs.microsoft.com/en-us/dotnet/csharp/async
// https://app.pluralsight.com/library/courses/getting-started-with-asynchronous-programming-dotnet

// TO-DO: C# 70-483 Exam Competency: Decision and iteration statements.
// https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/concepts/iterators

namespace Sitecore.Feature.Fundamentals.Controllers
{
    public class StockController : Controller
    {
        private IStockRepository _stockRepo;

        public StockController(IStockRepository stockRepo)
        {
            this._stockRepo = stockRepo;
        }

        // GET: Stock
        public ActionResult Index()
        {
            StockViewModel stockView = new StockViewModel();

            try
            {
                stockView.Stocks = _stockRepo.PriceAlert();
            }
            catch (Exception ex)
            {
                if (!stockView.Stocks.Any(x => string.IsNullOrEmpty​(x.Name)))
                {
                    var msg = "Unable to retrieve Stock";
                    Log.Error(msg, this);
                    stockView.GetStocksError = "Unable to retrieve Stocks";
                }
            }
            return View(stockView);

            // Thread example.
            //StockViewModel stockView = new StockViewModel();

            //// https://docs.microsoft.com/en-us/dotnet/api/system.threading.thread?view=net-5.0
            //var thread = new Thread(() =>
            //{
            //    try
            //    {
            //        stockView.Stocks = _stockRepo.GetStocks();
            //        stockView.Alerts = _stockRepo.GetStockAlerts();
            //    }
            //    // C# 70-483 Exam Competency: Handling errors and exceptions
            //        // https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/exceptions/exception-handling
            //        // https://app.pluralsight.com/library/courses/c-sharp-error-handling-exceptions/table-of-contents
            //    catch (Exception ex)
            //    {
            //        if (!stockView.Stocks.Any(x => string.IsNullOrEmpty​(x.Name)))
            //        {
            //            var msg = "Unable to retrieve Stock";
            //            Log.Error(msg, this);
            //            stockView.GetStocksError = "Unable to retrieve Stocks";
            //        }
            //        if (!stockView.Alerts.Any(x => string.IsNullOrEmpty​(x.Alert)))
            //        {
            //            var msg = "Unable to retrieve Alert";
            //            Log.Error(msg, this);
            //            stockView.GetAlertsError = "Unable to retrieve Alerts";
            //        }
            //    }
            //});
            //thread.Start();

            //return View(stockView);
        }

        // Async example
        //public async Task<ActionResult> Index()
        //{
        //    try
        //    {
                  // Only executes on one thread
        //        var task1 = Task.Run(() => _stockRepo.GetStocks());
        //        var task2 = Task.Run(() => _stockRepo.GetStockAlerts());

        //        StockViewModel stockView = new StockViewModel();
        //        stockView.Stocks = await task1;
        //        stockView.Alerts = await task2;

        //        return View(stockView);
        //    }
        //    catch
        //    {
        //        return View("Stock list not found");
        //    }
        //}
    }
}