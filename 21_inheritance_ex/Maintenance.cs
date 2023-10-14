using System.Reflection.Metadata.Ecma335;

namespace _21_inheritance_ex
{
    public class Maintenance : Employee
    {
        public Maintenance(int id, string name, decimal loggedhours, decimal wage) : 
            base(id, name, loggedhours , wage)
        {
            
        }
        protected const decimal Hardship = 100m;

        protected override decimal CalculateSal()
        {
            return base.CalculateSal() + Hardship;
        }
       
        public override string ToString()
        {
            return base.ToString() +
                $"\nallowance: {Math.Round(Hardship,2):N0}" +
                $"\nnetsalary:{Math.Round(this.CalculateSal(),2):N0}";
        }


    }

}