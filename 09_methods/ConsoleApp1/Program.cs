namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            demo dd = new demo();
            // 18 here called argument passed 
            dd.DoSomthing(18);
          
            // dd.promote(); //method over_loading
             int[] numbers = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            dd.printEven(ref numbers);

           

            Console.ReadKey();  

        }
    }
    public class demo
    {
        public void DoSomthing(int age) //age here called parameter
        {
            Console.WriteLine(age);
        }
        /* //method signiture (name + parameter_type + parameter_order)
         * 
         public void myMethod(int x,double y)
         {

         }
         public void myMethod(double y, int x)
         {

         }*/

      /*  //method overloading (a common way of implementing polymorphisim)
        public void promote (double amount)
        {
            Console.WriteLine("you have got a promotion of:" + amount);
        }
        public void promote(double amount,string ticket)
        {
            Console.WriteLine("you have got a promotion of:" + amount+"and a free ticket to :" + ticket);
        }
        public void promote(double amount,string ticket,string hotel )
        {
            Console.WriteLine("you have got a promotion of:" + amount + "and a free ticket to :"+ticket+"in a hotel:"+hotel);
        }
      */


        public void printEven(ref int[] original)
        {

            foreach (var n in original)
            {
                if (isEven(n))
                    Console.Write(n + " ");
            }
            bool isEven(int number)
            {
                return number % 2 == 0;
            }
        }

        
    }
}