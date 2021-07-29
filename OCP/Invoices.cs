using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCP
{
    public class Invoices
    {
        public virtual double GetInvoiceDiscount(double amount)
        {
            double DiscountAmount = 0;

            DiscountAmount = amount - 100;

            return DiscountAmount;

        }
    }

    public class FinalInvoice : Invoices
    {
        public override double GetInvoiceDiscount(double amount)
        {
            return base.GetInvoiceDiscount(amount) - 50;
        }

    }
    public class ProposedInvoice : Invoices
    {
        public override double GetInvoiceDiscount(double amount)
        {
            return base.GetInvoiceDiscount(amount) - 80;
        }

    }
}
