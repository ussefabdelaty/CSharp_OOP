namespace _21_inheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SubClass sc = new SubClass(123);
            Console.WriteLine(sc);
           
/*
            Animal a = new Animal();
            Console.WriteLine(a);

            Type type = a.GetType();
            Console.WriteLine(type.FullName);
            //var e = new Eagle();
            //e.Move();
            //e.Run();  
*/  
            Console.ReadKey();  

        }
    }
    class BaseClass
    {
        public int x;
        public BaseClass(int value )
        {
            this.x = value;
        }
    }
    class SubClass : BaseClass
    {
        public SubClass(int scValue): base(scValue) 
        {
            
        }
    }

  /*
   * class Animal
    {
        public string Name { get; set; }    
        
        public virtual void Move()
        {
            Console.WriteLine("moviing!");
        }

        public override string ToString()
        {
            return $"Anima {Name} is Moveing";
        }
    }

   
   * class Eagle: Animal
    {
        public override void Run()
        {
                     Console.WriteLine("runiiiiiiig !");
        }
        public override void Move()
        {
            Console.WriteLine("it's override moviing");
        }
        public void Fly()
        {
            Console.WriteLine("flyiing!");
        }
    }
  */
}