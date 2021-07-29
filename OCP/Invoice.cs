using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCP
{
    public class Invoice
    {

        public double GetInvoiceDiscount(double amount, InvoiceType invoiceType)
        {
            double DiscoutAmount = 0;

            if (invoiceType == InvoiceType.FinalInvoice)
            {
                DiscoutAmount = amount - 100;
            }
            else if (invoiceType == InvoiceType.ProposedInvoice)
            {
                DiscoutAmount = amount - 120;
            }
            return DiscoutAmount;

        }

        //static void Main(string[] args)
        //{
        //}

        public enum InvoiceType
        {
            FinalInvoice,
            ProposedInvoice

        }
    }


}
