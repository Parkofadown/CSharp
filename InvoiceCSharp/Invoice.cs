using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unit3MidTermRichardBoyd
{
    class Invoice
    {
        // Constructor
        public Invoice(string partNumber, string partDescription, int quantity, decimal price)
        {
            
            PartNumber = partNumber;
            PartDescription = partDescription;
            if (quantity < 0)
            {
                Quantity = 0;
            } else
            {
                Quantity = quantity;
            }
            if(price < 0)
            {
                Price = 0;
            }
            else
            {
                Price = price;
            }
           
        }
        // End Constructor
        //Start Property PartNumber
        public string PartNumber
        {
            get;
            set;
        }
        // End Property PartNumber
        //Start Property PartDescription
        public string PartDescription
        {
            get;
            set;
        }
        // End Property PartDescription
        //start Property Quanity
        public int Quantity
        {
            get;
            set;
        }
        // End Property Quantity
        //Start Property Price
        public decimal Price
        {
            get;
            set;
        }
        //End Property Price

        // Start Method GetInvoiceAmount
        public decimal GetInvoiceAmount()
        {
            decimal invoiceAmount = (decimal)Quantity * Price;
            return invoiceAmount;
        } 
        // End Method GetInvoiceAmount

    }// End Class Invoice
} // End Namespace
