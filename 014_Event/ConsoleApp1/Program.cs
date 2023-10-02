 namespace CaEvent

{
    internal class Program
    {
        static void Main(string[] args)
        {
            var stock = new Stock("amazon");
            stock.StockPriceChanged += Stock_StockPriceChanged;
            stock.Price = 100;
            stock.ChangeStockPriceBy(0.05m);
            stock.ChangeStockPriceBy(-0.02m);
            stock.ChangeStockPriceBy(0.00m);

            // Console.WriteLine($"stock before changing: ${stock.Price} ");
            // stock.ChangeStockPriceBy(0.05m);
            // Console.WriteLine($"stock after changing: ${stock.Price} ");
        }

        private static void Stock_StockPriceChanged(Stock stock, decimal oldprice)
        {
            if (stock.Price > oldprice)
            {
                Console.ForegroundColor = ConsoleColor.Green;

            }
            else if (stock.Price < oldprice)
            {
                Console.ForegroundColor = ConsoleColor.Red;

            }
            else { Console.ForegroundColor = ConsoleColor.Gray; }
            Console.WriteLine($"{stock.Name} : {stock.Price}");

        }
    }
    public delegate void StockPriceChangeHandler(Stock stock, decimal oldprice);

    public class Stock
    {
        private string name;
        private decimal price;

        public event StockPriceChangeHandler StockPriceChanged;  

        public string Name => this.name;
        public decimal Price { get => this.price; set => this.price = value; }

        public Stock( string stockname)
        {
            this.name = stockname;  
                    }
        public void ChangeStockPriceBy( decimal percent ) 
        {
            decimal oldprice = this.price;
            this.price += Math.Round(this.price*percent,2);
            if(StockPriceChanged != null)
            {
                StockPriceChanged(this,oldprice);   //firing event or publishing event 
            }

        }
    }
}