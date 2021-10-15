using System;

namespace OpenClosed
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Bir nesne gelişime AÇIK değişime KAPALI olmalıdır.
             * Bir özellik eklemek için varolan kodu değiştirmek zorunda kalıyorsanız bu prensibi ihlal ediyorsunuz demektir.
             */

            Customer customer = new Customer();
            customer.Card = new Premium();

            OrderManagement orderManagement = new OrderManagement();
            orderManagement.Customer = customer;
            var discountedPrice = orderManagement.CalculateDiscountedPrice(1000);
            Console.WriteLine(discountedPrice.ToString());

        }

    }
    public abstract class CardType
    {
        public abstract double CalculatePrice(double price);
      
    }


    public class Standard : CardType
    {
        public override double CalculatePrice(double price)
        {
            return price * 0.95;
        }
    }

    public class Silver : CardType
    {
        public override double CalculatePrice(double price)
        {
            return price * 0.90;
        }
    }

    public class Premium : CardType
    {
        public override double CalculatePrice(double price)
        {
            return price * 0.80;
        }
    }

    public class Gold : CardType
    {
        public override double CalculatePrice(double price)
        {
            return price * 0.85;
        }
    }

    public class Customer
    {
        public CardType Card { get; set; }
    }

    public class OrderManagement
    {
        public Customer Customer { get; set; }
        public double CalculateDiscountedPrice(double price)
        {
           return  Customer.Card.CalculatePrice(price);
        }


    }
}
