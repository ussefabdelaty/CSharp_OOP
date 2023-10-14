using customlib;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Employee e1 = new Employee();
            Console.WriteLine(e1.EmpInusrance.ComName);

            Console.WriteLine($"{GC.GetTotalMemory(false):N0}");
            GC.Collect();
            Console.WriteLine($"{GC.GetTotalMemory(true):N0}");
        }
    }
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public Insurance EmpInusrance { get; set; }

        public Employee() => //lamda_exprression
             EmpInusrance = new Insurance {PolicyId= -1 , ComName = "NN" }; 
            

        public class Insurance
        {
            public int PolicyId { get; set; }
            public string ComName { get; set; }
        }
    }
    


    public class Department
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }

    
    //  class A
    //{
    //    private int z;
    //    class B
    //    {
    //        void Method()
    //        {
    //            A a = new A();
    //            a.z= 1; 
    //        }
    //    }
    //}    
}