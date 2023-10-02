using System.Reflection;
using System.Xml.Linq;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            var emps = new Employee[]
            {
                    new Employee {Id= 1,Name = "issam",  Gender = "m",   TotalSale=65000m},
                    new Employee {Id= 2,Name = "sam",    Gender = "m",   TotalSale=50000m},
                    new Employee {Id= 3,Name = "amiaa",  Gender = "f",   TotalSale =75000m},
                    new Employee {Id= 4,Name = "salah",  Gender = "m",   TotalSale =40000m},
                    new Employee {Id= 5,Name = "samiiaa",Gender = "f",   TotalSale =42000m},
                    new Employee {Id= 6,Name = "salii",  Gender = "f",   TotalSale =30000m},
                    new Employee {Id= 7,Name = "dam",    Gender = "m",   TotalSale = 15000m},
                    new Employee {Id= 8,Name = "sdam",   Gender = "m",   TotalSale = 20000m},

            };

            Report report = new Report();
            report.ProcessEmpolyee(emps,"sales>=60000",delegate (Employee e ){return e.TotalSale >= 60000m; });//it's called annonymous delegate
            report.ProcessEmpolyee(emps, "30000<=sales<=60000",(Employee e) =>  e.TotalSale >= 30000m && e.TotalSale <= 59999);//lambda expression
            report.ProcessEmpolyee(emps, "sales<60000",delegate (Employee e) { return e.TotalSale < 30000m;
            });

            Console.ReadKey(); 
        }
      //  static bool Isgreaterthanorequal(Employee e) => e.TotalSale >= 60000m;
       // static bool IsBetween(Employee e) => e.TotalSale >= 30000m && e.TotalSale<=59999;
       // static bool IsLess(Employee e) => e.TotalSale < 30000m;
    }
    
   
}