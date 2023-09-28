namespace oop_prooerties
{
    class Program
    {
        static void Main(string[] args)
        {

            Dollar dollar = new Dollar(1.088m);
            Console.WriteLine();
            dollar.SetAmount (1.099m) ; //set

            Console.WriteLine(dollar.Amount); //get
            Console.WriteLine(dollar.IsZero);
        }
    }
        public class Dollar
        {
            decimal _amount;
        // prop tap tap

            //property 
            //prop tap tap 
            public decimal Amount
            {
                get
                {
                    return this._amount;
                }
                private set
                { // that's called validation

                    this._amount = processValue(value);

                }
            }
        public void SetAmount(decimal value)
        {
            this.Amount = value;
        }

            public Dollar(decimal amount)
            {
                //_amount = amount;    
                this._amount = processValue(amount);
            }

            private decimal processValue(decimal value) => value <= 0 ? 0 : Math.Round(value, 2);

             public bool IsZero
        {
            get
            {
                return _amount == 0;
            }
        }
        }

    
}