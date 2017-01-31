using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07SalesReport
{
    class SalesReport
    {
        static void Main(string[] args)
        {
            int inputNum = int.Parse(Console.ReadLine());
            SortedDictionary<string, decimal> salesDict = new SortedDictionary<string, decimal>();

            while(inputNum>0)
            {
                string[] inputArray = Console.ReadLine().Split(' ').ToArray();
                Sale saleInput = ReturnSaleProperties(inputArray);
                if(!salesDict.Keys.Contains(saleInput.town))
                {
                    salesDict.Add(saleInput.town, saleInput.value);
                }
                else
                {
                    salesDict[saleInput.town] += saleInput.value;
                }
                inputNum--;
            }
            foreach(KeyValuePair<string, decimal> p in salesDict)
            {
                Console.WriteLine("{0} -> {1:f2}", p.Key, p.Value);
            }
        }

        static Sale ReturnSaleProperties(string[] inputArray)
        {
            Sale sale = new Sale();
            sale.town = inputArray[0];
            sale.product = inputArray[1];
            sale.price = decimal.Parse(inputArray[2]);
            sale.quantity = decimal.Parse(inputArray[3]);
            
            return sale;
        }
    }

    class Sale
    {
        public string town { get; set; }
        public string product { get; set; }
        public decimal quantity { get; set; }
        public decimal price { get; set; }
        public decimal value { get
            {
                return quantity * price;
            }
        }
    }
}
