namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            employee[] emps = new employee[2];
          
            //object(instance) syntax 
            /*
             * 1)declaration <type> <obj_name>;
             * 2)assignment <obj_name> = <key_word "new"> <type>;
             * 3)<type> <obj_name> = <key_word "new"> <type>();
             */
            employee e1 = new employee();
            employee e2 = new employee();


            //method for calculate salary 

            Console.WriteLine("first employee");

            Console.Write("Enter you first name: ");
             e1.fName = Console.ReadLine();

            Console.Write("enter you last name:");
            e1.lName = Console.ReadLine();

            Console.Write("wage: ");
            e1.wage = Convert.ToDouble(Console.ReadLine());

            Console.Write("ligged Hours:");
            e1.loggedHours = Convert.ToDouble(Console.ReadLine());

            emps[0] = e1;

            Console.WriteLine("\n second employee");

            Console.Write("Enter you first name: ");
            e2.fName = Console.ReadLine();

            Console.Write("enter you last name:");
            e2.lName = Console.ReadLine();

            Console.Write("wage: ");
            e2.wage = Convert.ToDouble(Console.ReadLine());

            Console.Write("ligged Hours:");
            e2.loggedHours = Convert.ToDouble(Console.ReadLine());

            emps[1] = e2;

            foreach (var emp in emps)
            {

                var netSalary = (emp.wage * emp.loggedHours) - (emp.wage * emp.loggedHours * employee.TAX);
                Console.WriteLine($"first name :{emp.fName}");
                Console.WriteLine($"last name :{emp.lName}");
                Console.WriteLine($"wage:{emp.wage}");
                Console.WriteLine($"loggedHours :{emp.loggedHours}");
                Console.WriteLine($"net salary :{netSalary}");
            }


        }
    }
}