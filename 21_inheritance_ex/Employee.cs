namespace _21_inheritance_ex
{
    public class Employee
    {
        protected const int MinimumLoggedHours = 176;
        protected const decimal OverTimeRate = 1.25m;

        protected Employee(int id, decimal loggedhours, string name, decimal wage)
        {
            Id = id;
            Loggedhours = loggedhours;
            Name = name;
            Wage = wage;
        }

        public Employee(int id, string name, decimal loggedhours, decimal wage)
        {
            Id = id;
            Name = name;
            Loggedhours = loggedhours;
            Wage = wage;
        }

        protected int Id { get; set; }
        protected decimal Loggedhours { get; set; }
        protected string Name { get; set; }
        protected decimal Wage { get; set; }

        protected decimal CalBaseSalary()
        {
          return  Wage* MinimumLoggedHours;
        }

        protected decimal CalOverTime()
        {
            var additionalHours = ((Loggedhours - MinimumLoggedHours) > 0 ? Loggedhours - MinimumLoggedHours : 0);
            return additionalHours* Wage *OverTimeRate;
        }

        protected virtual decimal CalculateSal()
        {
            return CalBaseSalary() + CalOverTime();    
        }

        public override string ToString()
        {
            var type = GetType().ToString().Replace("_21_inheritance_ex.","");
            return
                $"\n{type}"+
                $"\nId: {Id}" +
                   $"\nName: {Name}" +
                   $"\nLoggedHours:{Loggedhours}hrs" +
                   $"\nWage: {Wage}$" +
                   $"\nBaseSalary: ${CalBaseSalary()}" +
                   $"\nCalOverTime:${CalOverTime()}";
        }

      

    }
}