namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Money m1 = new Money(10);
            Money m2 = new Money(20);

            Money m3 = m1 + m2;
           Console.WriteLine($"money m3 :${ m3.Amount}");
            Console.WriteLine(++m3.Amount);
        }
    }

    class Money
    {
        private decimal amount;

        public Money(decimal value)
        {
            this.amount = value;
        }
        public decimal Amount
        {
            get 
            {
              return amount;
            }
            set {
                amount = value; 
            }
        }




        public static Money operator+(Money m1 , Money m2) {
              var value = m1.Amount + m2.Amount;
              return new  Money(value);                    
          }

         public static bool operator >(Money m1 , Money m2)
          {
              return m1.Amount > m2.Amount;   
          }
         public static bool operator <(Money m1, Money m2)
          {
              return m1.Amount > m2.Amount;
          }

        public static bool operator ==(Money m1, Money m2)
        {
            return m1.Amount > m2.Amount;
        }
        public static bool operator !=(Money m1, Money m2)
        {
            return m1.Amount > m2.Amount;
        }
        public static Money operator ++(Money money)
        {
           var value = money.Amount;
            return new Money(++value);
        }
        public static Money operator --(Money money)
        {
            var value = money.Amount;
            return new Money(--value);  
        }

    }
}