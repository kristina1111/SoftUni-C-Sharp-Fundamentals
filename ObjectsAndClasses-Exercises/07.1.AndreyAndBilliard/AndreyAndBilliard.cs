using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AndreyAndBilliard
{
    class AndreyAndBilliard
    {
        static void Main(string[] args)
        {
            // Create Dictionary of products and prices
            Dictionary<string, double> productPrices = new Dictionary<string, double>();
            int numProduct = int.Parse(Console.ReadLine());
            for (int i = 0; i < numProduct; i++)
            {
                string[] infoProduct = Console.ReadLine().Split(new[] { '-' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
                if (!productPrices.ContainsKey(infoProduct[0]))
                {
                    productPrices.Add(infoProduct[0], double.Parse(infoProduct[1]));
                }
                else
                {
                    productPrices[infoProduct[0]] = double.Parse(infoProduct[1]);
                }
            }
            List<Customer> listOfCustomers = new List<Customer>();  //create list of customers
            string command = Console.ReadLine();
            while (!command.Equals("end of clients"))
            {
                string[] inputInfo = command.Split(new[] { ',', '-' }, StringSplitOptions.RemoveEmptyEntries).ToArray();

                Customer newCustomer = new Customer() { Name = inputInfo[0] };
                if (!productPrices.ContainsKey(inputInfo[1])) // if the product that the customer wants to buy is not in the Dictionary of products and prices
                {// then skip the command, get new command and start from the beginning
                    command = Console.ReadLine();
                    continue;
                }
                else // if the product is in the Dictionary of products and prices
                {// then check if any customer in the listOfCustomers has a name like newCustomer.Name 
                    if(listOfCustomers.Any(c=>c.Name==newCustomer.Name))
                    {// if yes then check if that customer's ShopList Dictionary contains a product like in the command
                        if(listOfCustomers.First(c=>c.Name==newCustomer.Name).ShopList.ContainsKey(inputInfo[1]))
                        {// if it contains such product, then add the quantity of that product from the command to the Shoplist.Key of that customer
                            listOfCustomers.First(c => c.Name == newCustomer.Name).ShopList[inputInfo[1]] += double.Parse(inputInfo[2]);
                        }
                        else
                        {// if it doesn't contain such key, then add it to the Shoplist Dictionary of the customer
                            listOfCustomers.First(c => c.Name == newCustomer.Name).ShopList.Add(inputInfo[1], double.Parse(inputInfo[2]));
                        }
                    }
                    else // if in the ListOfCustomers there are no customer with that name
                    {// first add the product and quantity from the command to the Shoplist dictionary of newCustomer
                        newCustomer.ShopList.Add(inputInfo[1], double.Parse(inputInfo[2]));
                        // then add the newCustomer to the ListOfCustomers
                        listOfCustomers.Add(newCustomer);
                    }
                }
                command = Console.ReadLine();  // input new command
            }
            listOfCustomers = listOfCustomers.OrderBy(c => c.Name).ToList();  // order the list of clients alphabetically
            double totalBill = 0;
            foreach (var c in listOfCustomers)
            {
                Console.WriteLine("{0}", c.Name);  // print the name of the client
                double totalSumOfClient = 0;
                foreach(var p in c.ShopList)
                {// first print the products and quantities bought from each customer in the ListOfCustomers
                    Console.WriteLine("-- {0} - {1}", p.Key, p.Value);
                    // then caclulate the total sum of each customer
                    totalSumOfClient += p.Value * productPrices[p.Key];
                }
                c.TotalSum = totalSumOfClient;
                Console.WriteLine("Bill: {0:f2}", c.TotalSum);  // print the total sum of each customer
                totalBill += c.TotalSum; // add the total sum of each customer to the total bill
            }
            Console.WriteLine("Total bill: {0:f2}", totalBill);  // print the total bill
        }
    }
    public class Customer
    {
        public string Name { get; set; }
        public Dictionary<string, double> ShopList { get; set; }
        public Customer()
        {
            ShopList = new Dictionary<string, double>();
        }
        public double TotalSum { get; set; }
    }
}
