namespace _21_inheritance_ex
{
    public class Manger : Employee
    {
        public Manger(int id, string name, decimal loggedhours, decimal wage) :
            base(id, name, loggedhours, wage)
        {
            
        }
        protected const decimal AllowanceRate = 0.05m;

        protected override decimal CalculateSal()
        {
            return base.CalculateSal() + CalculateAllowance() ; 
        }
       protected decimal CalculateAllowance()
        {
            return base.CalculateSal() * AllowanceRate;
        }
        public override string ToString()
        {
            return base.ToString() +
                $"\nallowance: {CalculateAllowance()}" +
                $"\nnetsalary:{this.CalculateSal()}";
        }


    }
}