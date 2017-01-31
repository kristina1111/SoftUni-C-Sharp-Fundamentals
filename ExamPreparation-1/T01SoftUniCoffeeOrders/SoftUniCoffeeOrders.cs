using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T01SoftUniCoffeeOrders
{
    class SoftUniCoffeeOrders
    {
        static void Main(string[] args)
        {
            checked
            {
                double inputNum = double.Parse(Console.ReadLine());
                decimal totalSum = 0;
                while (inputNum > 0)
                {
                    Coffeorder newCoffeeOrder = new Coffeorder();
                    newCoffeeOrder.pricepercapsule = decimal.Parse(Console.ReadLine());
                    newCoffeeOrder.OrderDate = DateTime.ParseExact(Console.ReadLine(), "d/M/yyyy", null);
                    newCoffeeOrder.NumCapsules = int.Parse(Console.ReadLine());
                    Console.WriteLine("The price for the coffee is: ${0:f2}", newCoffeeOrder.OrderPrice);

                    totalSum += newCoffeeOrder.OrderPrice;

                    inputNum--;
                }
                Console.WriteLine("Total: ${0:f2}", totalSum);
            }
        }
    }
    public class Coffeorder
    {
        public decimal pricepercapsule { get; set; }
        public DateTime OrderDate { get; set; }
        public int NumCapsules { get; set; }
        public decimal OrderPrice
        {
            get
            {
                return (DateTime.DaysInMonth(OrderDate.Year, OrderDate.Month) * (decimal)(NumCapsules)) * pricepercapsule;
            }
        }
    }
}
