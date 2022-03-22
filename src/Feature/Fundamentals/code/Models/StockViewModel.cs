using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Sitecore.Feature.Fundamentals.Models
{
    public class StockViewModel
    {
        public List<Stock> Stocks { get; set; }
        public List<StockAlert> Alerts { get; set; }
        public string GetStocksError { get; set; }
        public string GetAlertsError { get; set; }
    }
}