using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unit3MidTermRichardBoyd
{
    class InvoiceTest
    {
        public static void Main(string[] args)
        {
            // declare variables
            string partNumber;
            string partDescription;
            int quantity;
            decimal price;

            // Ask for user input and store in
            Console.Write("Enter part number: ");
            partNumber = Console.ReadLine();
            Console.Write("Enter part description: ");
            partDescription = Console.ReadLine();
            Console.Write("Enter quantity: ");
            quantity = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter price: ");
            price = Convert.ToDecimal(Console.ReadLine());

            // create objects
            Invoice invoice = new Invoice(partNumber, partDescription, quantity, price);
            Console.Write("The invoice amount is {0:F} ", invoice.GetInvoiceAmount());
            

            Console.ReadKey();
        } // end Main
    } // end class InvoiceTest
} // end namespace
