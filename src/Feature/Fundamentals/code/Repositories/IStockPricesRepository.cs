//// not currently in use but good code examples!

//using System;
//using System.Collections.Generic;
//using System.IO;
//using System.Linq;
//using System.Threading;
//using System.Threading.Tasks;
//using Sitecore.Configuration;
//using Sitecore.Data.Items;
//using Sitecore.Feature.Fundamentals.Models;
//using Sitecore.Resources.Media;

//namespace Sitecore.Feature.Fundamentals.Repositories
//{
//    public interface IStockPricesRepository
//    {
//        // Search button
//        Task<IEnumerable<StockPrice>> GetStockPrices(string ticker, CancellationToken cancellationToken);
//        // Sitecore StockPrices.csv new file uploaded alert message
//        Task<IEnumerable<StockPrice>> AwaitStockPricesAlert();
//    }

//    public class StockService : IStockPricesRepository
//    {
//        //public async Task<IEnumerable<StockPrice>> GetStockPrices()
//        //{

//        //}
//        //public async Task<IEnumerable<StockPrice>> GetStockPricesFor(string ticker, CancellationToken cancellationToken)
//        ////{
//        ////    using (MemoryStream memoryStream = new MemoryStream())
//        ////    {
//        ////        var db = Factory.GetDatabase("master");
//        ////        var mediaItem = (MediaItem)db.GetItem("/sitecore/media library/Files/StockPrices/StockPrices");
//        ////        var fileDataStream = mediaItem.GetMediaStream();

//        ////        fileDataStream.CopyTo(memoryStream);
//        ////        // process the stream data here
//        ////        var stocks = new List<StockPrice>();

//        ////        return await Task.FromResult(stocks.Where(stock => stock.Ticker == ticker));
//        ////    };
//        ////}

//        //private async Task<IEnumerable<StockPrice>> GetStockPrices()
//        //{
//        //    var prices = new List<StockPrice>();

//        //    using (var stream =
//        //        new StreamReader(File.OpenRead(Path.Combine(basePath, @"StockPrices_Small.csv"))))
//        //    {
//        //        await stream.ReadLineAsync(); // Skip headers

//        //        string line;
//        //        while ((line = await stream.ReadLineAsync()) != null)
//        //        {
//        //            var segments = line.Split(',');

//        //            for (var i = 0; i < segments.Length; i++) segments[i] = segments[i].Trim('\'', '"');
//        //            var price = new StockPrice
//        //            {
//        //                Ticker = segments[0],
//        //                TradeDate = DateTime.ParseExact(segments[1], "M/d/yyyy h:mm:ss tt", CultureInfo.InvariantCulture),
//        //                Volume = Convert.ToInt32(segments[6], CultureInfo.InvariantCulture),
//        //                Change = Convert.ToDecimal(segments[7], CultureInfo.InvariantCulture),
//        //                ChangePercent = Convert.ToDecimal(segments[8], CultureInfo.InvariantCulture),
//        //            };
//        //            prices.Add(price);
//        //        }
//        //    }

//        //    return prices;
//        //}

//        //public Task<IEnumerable<StockPrice>> AwaitStockPricesAlert()
//        //{
//        //    throw new NotImplementedException();
//        //}

//        //public Task<IEnumerable<StockPrice>> GetStockPrices(string ticker, CancellationToken cancellationToken)
//        //{
//        //    var db = Factory.GetDatabase("master");
//        //    var csvItem = db.GetItem("/sitecore/media library/Files/StockPrices/StockPrices");

//        //    var prices = new List<StockPrice>();

//        //    using (var reader = new StreamReader(MediaManager.GetMedia(csvItem).GetStream().Stream))
//        //    {
//        //        await reader.ReadLineAsync();


//        //        string text = reader.ReadToEnd();
//        //    }

//        //    using (MemoryStream mStream = csvItem.GetMediaStream().ReadAsync())
//        //    using (StreamReader reader = new StreamReader(mStream))
//        //    {
//        //        IEnumerable<Data> datas = cc.Read<Data>(reader, inputFileDescription);
//        //    }
//        //}
//        public Task<IEnumerable<StockPrice>> AwaitStockPricesAlert()
//        {
//            throw new NotImplementedException();
//        }

//        public Task<IEnumerable<StockPrice>> GetStockPrices(string ticker, CancellationToken cancellationToken)
//        {
//            throw new NotImplementedException();
//        }
//    }
//}