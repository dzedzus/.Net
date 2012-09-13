using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Stock
    {

        private string stockName;
        private float stockActualPrice;
        private string stockBuyTime;
        [Key]
        public virtual string StockName { get { return stockName; } set { stockName = value; } }
        public virtual double StockActualPrice { get { return stockActualPrice; } set { stockActualPrice = (float)value; } }
        public virtual string StockBuyTime { get { return stockBuyTime; } set { stockBuyTime = value; } }

        public Stock(string name,float price,string times)
        {
            stockName = name;
            stockActualPrice = price;
            stockBuyTime = times;
        }
    }
}
