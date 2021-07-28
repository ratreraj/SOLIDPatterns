using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace ISP
{
    public class Invoices
    {
        public long InvoiceAmount { get; set; }
        public DateTime InvoiceDate { get; set; }
        private Ilogger filelogger;

        private Email email;
        public Invoices()
        {
            filelogger = new Logger();
            email = new Email();
        }
        // SRP implementation
        public void AddInvoice()
        {

            try
            {
                // Here we write the logic for add the invoice

                //MailMessage mailMessage = new MailMessage("EmailFrom","EmailTo","Subject","Body");
                //this.SendEmail(mailMessage);
                filelogger.Info("Invoice Creation Started");

                email.FromEmail = "test@gmail.com";
                email.ToEmail = "raj@gmail.com";
                email.Subject = "Invoice Created";
                email.EmailBody = "Invoice Data";
                email.SendEmail(email);


            }
            catch (Exception ex)
            {
                filelogger.ErrorLog(@"c:\erorlog.txt", ex);
                // System.IO.File.WriteAllText(@"c:\erorlog.txt", ex.Message.ToString());
            }


        }

        public void DeleteInvoice()
        {

            try
            {
                // Here we write the logic for delete the invoice
            }
            catch (Exception ex)
            {

                System.IO.File.WriteAllText(@"c:\erorlog.txt", ex.Message.ToString());
            }
        }
        public void SendEmail(MailMessage mailMessage)
        {
            try
            {

            }
            catch (Exception ex)
            {

                System.IO.File.WriteAllText(@"c:\erorlog.txt", ex.Message.ToString());
            }

        }

        //static void Main(string[] args)
        //{
        //}
    }
}
