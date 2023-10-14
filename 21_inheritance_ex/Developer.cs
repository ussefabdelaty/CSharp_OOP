namespace _21_inheritance_ex
{
    public class Developer : Employee
    {
        public Developer(int id, string name, decimal loggedhours, decimal wage ,bool taskcompleted) : base(id, name, loggedhours, wage)
        {
            this.TaskCompleted = taskcompleted;
        }
        protected const decimal Commission = 0.03m;
        protected bool TaskCompleted { get; set; }


        protected override decimal CalculateSal()
        {
            return base.CalculateSal() + CalculateBonus();
        }

        private decimal CalculateBonus()
        {
            if (TaskCompleted)
            
                return base.CalculateSal() * Commission;
                return 0;
                
        }

        public override string ToString()
        {
            return base.ToString() +
                $"\nTaskCompleted:{Math.Round(Commission, 2):N0}" +
                $"\nBonus: {CalculateBonus()}" +
                $"\nnetsalary:{this.CalculateSal()}";
        }


    }
}