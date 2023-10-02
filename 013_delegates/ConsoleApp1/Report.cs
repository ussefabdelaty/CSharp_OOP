using System;
using System.Security.Cryptography.X509Certificates;
using static ConsoleApp1.Report;

namespace ConsoleApp1
{
    public class Report

    {
        public delegate bool IllegibaleSales(Employee e);
        public void ProcessEmpolyee(Employee[] emps ,string title, IllegibaleSales isIllegibale ) 
        {
            Console.WriteLine(title);
            Console.WriteLine("-------------------------------------");

            foreach (var e in emps)
            {
                if (isIllegibale(e))
                {
                    Console.WriteLine($"{e.Id}| {e.Name} | {e.TotalSale} | {e.Gender}");
                }
            }
            Console.WriteLine("\n\n");

        }

    }
}
