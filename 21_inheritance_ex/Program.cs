namespace _21_inheritance_ex
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Manger m = new Manger(1000, "MAoaa", 180, 8);

            Maintenance ms = new Maintenance(1000,"MA",189,10);

            Sales s = new Sales(1001, "Ya", 180, 20, 0.05m, 10000m);

            Developer d = new Developer(1222,"yy",188,15,true);
          
            Employee[] employees = { m, ms, s, d }; 
            foreach(var employee in employees)
            {
                Console.WriteLine("\n=====================");
                Console.WriteLine(employee);
            }
            Console.WriteLine();
        }
    }
     
   
}