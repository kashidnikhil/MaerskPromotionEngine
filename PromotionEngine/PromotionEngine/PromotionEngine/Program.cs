//Nikhil Kashid Promotion Engine

//This is console application for promotion engine for a checkout process.
//Total number of order.
//Then Add product one by one after completing automatically shown total order value


using System;
using System.Collections.Generic;


namespace PromotionEngine
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Create List of Product
            List<Product> products = new List<Product>();

            //Message for Enter Total Number Order
            Console.WriteLine("Total number of order");

            //Read Enter Order
            int a = Convert.ToInt32(Console.ReadLine());

            //Create For Loop for Enter Product Type and read enter product
            for (int i = 0; i < a; i++)
            {
                Console.WriteLine("Enter the type of product:A,B,C or D");
                string type = Console.ReadLine();
                Product p = new Product(type);
                products.Add(p);
            }
            //Call GetTotalPrice
            int totalPrice = GetTotalPrice(products);

            //Final Output of Total Price
            Console.WriteLine("Total price is = " + totalPrice);
            Console.ReadLine();
        }

        public static int GetTotalPrice(List<Product> products)
        {
            //Declare Variable and Given Price with product
            int counterofA = 0;
            int priceofA = 50;
            int counterofB = 0;
            int priceofB = 30;
            int CounterofC = 0;
            int priceofC = 20;
            int CounterofD = 0;
            int priceofD = 15;

            //Get count of each product
            foreach (Product pr in products)
            {
                if (pr.Id == "A" || pr.Id == "a")
                {
                    counterofA = counterofA + 1;
                }
                if (pr.Id == "B" || pr.Id == "b")
                {
                    counterofB = counterofB + 1;
                }
                if (pr.Id == "C" || pr.Id == "c")
                {
                    CounterofC = CounterofC + 1;
                }
                if (pr.Id == "D" || pr.Id == "d")
                {
                    CounterofD = CounterofD + 1;
                }
            }
            //Apply Logic of A Product price
            int totalPriceofA = (counterofA / 3) * 130 + (counterofA % 3 * priceofA);

            //Apply Logic of B Product price
            int totalPriceofB = (counterofB / 2) * 45 + (counterofB % 2 * priceofB);
            int totalPriceofC = 0;
            int totalPriceofD = 0;

            //Apply Logic of Combine C & D Product and Single Product
            if (CounterofC > 0 && CounterofD > 0)
            {
                if (CounterofC > CounterofD)
                {
                    totalPriceofC = (CounterofC - CounterofD) * priceofC + (CounterofD * 30);

                }
                else
                {
                    totalPriceofD = (CounterofD - CounterofC) * priceofD + (CounterofC * 30);
                }
            }
            else
            {
                totalPriceofC = (CounterofC * priceofC);
                totalPriceofD = (CounterofD * priceofD);
            }

            //Return OutPut
            return totalPriceofA + totalPriceofB + totalPriceofC + totalPriceofD;

        }
    }

    //List of Product 
    public class Product
    {

        public string Id { get; set; }
        public decimal Price { get; set; }


        public Product(string id)
        {
            this.Id = id;
            switch (id)
            {
                case "A":
                    this.Price = 50m;

                    break;
                case "B":
                    this.Price = 30m;

                    break;
                case "C":
                    this.Price = 20m;

                    break;
                case "D":
                    this.Price = 2015m;
                    break;
            }
        }
    }
    
}
