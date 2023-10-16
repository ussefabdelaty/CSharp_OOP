namespace _22_Interface
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Honda d = new Honda("bmw","cxcd",2022);
            
            Console.WriteLine();
        }
    }
    abstract class Vehical
    {
        protected string Brand;
        protected string Model;
        protected int Year;

        public Vehical(string brand ,string model , int year)
        {
            Brand = brand;  
            Model = model;  
           Year = year; 
        }
    }
    interface IDrivable
    { 
        void turn()
        {
            Console.WriteLine("turniiiiiiiiiiiiiiiiiiing!");
        }
        void move();
        void stop();
    }

    interface ILoader
    {
        void load();
        void unload();
    }

    class Honda : Vehical ,IDrivable
    {
        public Honda(string brand, string model, int year): base (brand,model,year)
        {
            
        }
        //implement inteerface explicitly
         void IDrivable.move()
        {
            Console.WriteLine("moving");
        }

         void IDrivable.stop()
        {
            Console.WriteLine("stoping");
        }
    }

    class Caterpiller : Vehical , ILoader ,IDrivable   //caterpiller==الونش
    {
        public Caterpiller(string brand, string model, int year) : base(brand, model, year)
        {

        }
        //implement interface Implicitly
        public void load()
        {
            Console.WriteLine("loading"); 
        }

        public void move()
        {
            Console.WriteLine("moving");
        }

        public void stop()
        {
            Console.WriteLine("stopng");
        }

        public void unload()
        {
            Console.WriteLine("unloading");
        }
    }

}