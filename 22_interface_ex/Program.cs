namespace _22_interface_ex
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Cashier c = new Cashier(new Cash());
            c.CheckOut(6568643);
            Console.ReadKey();
        }
    }
    class Cashier
    {
        private IPayment _payment;
        public Cashier(IPayment payment)
        {
            _payment = payment ; 
        }
        public void CheckOut (decimal amount)
        {
            _payment.pay(amount);
        }
    }
    interface IPayment
    {
        void pay(decimal amount);   
    }
    class Cash :IPayment
    {
        public void pay(decimal amount)
        {
            Console.WriteLine($"cash payment: {Math.Round(amount, 2):N0}");
        }
    }
    class Debit:IPayment
    {
        public void pay(decimal amount)
        {
            Console.WriteLine($"debit payment: {Math.Round(amount, 2):N0}");
        }
    }
    class Visa : IPayment   
    {
        public void pay(decimal amount)
        {
            Console.WriteLine($"Visa payment: {Math.Round(amount, 2):N0}");
        }
    }
    class MasterCard : IPayment 
    {
        public void pay(decimal amount)
        {
            Console.WriteLine($"master card payment: {Math.Round(amount, 2):N0}");
        }
    }
}