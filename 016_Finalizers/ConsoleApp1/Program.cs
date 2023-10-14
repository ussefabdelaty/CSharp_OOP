using System.Drawing;

namespace ConsoleApp1
{
    internal class Program
    {

        static void Main(string[] args)
        {
            Makesomegarabage();
            Console.WriteLine($"memory used before collectino{GC.GetTotalMemory(false):N0}");
            GC.Collect();
            Console.WriteLine($"memory used After collectino{GC.GetTotalMemory(true):N0}");
            Console.ReadKey();

            //   var p = new person();
        }

        static void Makesomegarabage()
        {
            Version v;
            for (int i = 0; i < 1000; i++)
            {
                v = new Version();
            }

        }


        /*  class person
          { 
           public string Name { get; set; }

              public person()
              {
                  Console.WriteLine("this is person constructor");    
              }

               ~ person()
              {
                  Console.WriteLine("this is person destructor");
              }
          }
        */
    }
}