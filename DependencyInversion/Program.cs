using System;

namespace DependencyInversion
{
    class Program
    {
        static void Main(string[] args)
        {

            /*
             * Bir nesne, başka bir nesneye bağımlı ise, bu bağımlılık, dışardan tanımlanabiliyor olmalı.
             * 
             * Eğer bir nesnenin bağımlılığını alternatifi ile değiştirmek istediğinizde o nesneyi değiştirmek zorunda kalıyorsanız bu prensibi ihlal ediyorsunuz. 
             */
            Console.WriteLine("Hello World!");
            Report report = new Report(new WhatsAppSender());
            report.Send();
            
        }
    }

    public class Report
    {
        private ISender sender;
        public Report(ISender mailSender)
        {
            this.sender = mailSender;
        }
        public void Send()
        {
           
            sender.Send();
        }
    }

    public interface ISender
    {
        void Send();
    }

    public class WhatsAppSender : ISender
    {
        public void Send()
        {
            Console.WriteLine("Whatsapp ile gönderildi");
        }
    }
    public class MailSender : ISender
    {
        public void Send()
        {
            Console.WriteLine("mail ile gönderildi");
        }
    }
}
