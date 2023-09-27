using Microsoft.VisualBasic;
using System.Runtime.InteropServices;
using System.Xml.Linq;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            date dd = new date(29,02,1999);
            // dd.Day = 01;
            // dd.Month = 01;
            // dd.Year = 0001;
            // var x=dd.GetDate();
            //Console.WriteLine($"{dd.Day.ToString().PadLeft(2,0)}/{dd.Month.ToString().PadLeft(2,0)}/{dd.Year.ToString().PadLeft(4,0)}");
            Console.WriteLine(dd.GetDate());

            /*
             << object initalizer >>
            date d = new date
            {
             Day = 01,
            Month = 05,
            Year = 2015
            };


             */

            Employee emp = new Employee( 1001, "youssef","abdelaty");
           
           
            Console.ReadKey();        
        }


    }

    public class Employee
    {
        public Employee(int id , string fname , string lname)
        {
            this.id = id;   
            this.fname = fname;
            this.lname = lname; 
        }
        public static Employee Create(int id , string fname , string lname)
        {
            return new Employee(id, fname , lname); 
        }


        private int id;
        private string fname;
        private string lname;
    }
        public class date
     { 


            private static readonly int[] dayOfMonth365 = {0,31,28,31,30,31,30,31,31,30,31,30,31};
            private static readonly int[] dayOfMonth366 = {0,31,29,31,30,31,30,31,31,30,31,30,31 };

       
        /*  public int Day;
          public int Month;
          public int Year;
        */ //or 
        private int day=01;
        private int month=01;
        private int year = 01 ;


        //constructor => <acces_modifier> <Type_name =>"the same name of the class"> (parameters) {block_code}

        public date (int day,int month ,int year)
        {
            var ISLeap = year % 4 == 0  && (year % 100 != 0 || year % 400 == 0);

            if (year>=1 && year <=9999 && month >=1 && month <=12)
            {
                int[] days = ISLeap ? dayOfMonth366 : dayOfMonth365;
                if (day>=1 && day <= days[month])
                {
                    this.day = day;
                    this.month = month;
                    this.year = year;

                }
                //else
                //{
                //    this.day = 01;
                //    this.month = 01;
                //    this.year = 0001;
                //}
            }
            //else
            //{
            //    this.day = 01;
            //    this.month = 01;
            //    this.year = 01;
            //}

           // this.day = day;
           // this.month = month;          
           // this.year = year;        
        }
        //construcor overloading
        public date (int year ) : this(01,01,year) { }
        public date (int month, int year ) : this(01,month,year) { }

        public string GetDate()
        {
            return $"{day.ToString().PadLeft(2, '0')}" +
                $"/{month.ToString().PadLeft(2, '0')}" +
                $"/{year.ToString().PadLeft(4, '0')}";
        }
    }
}