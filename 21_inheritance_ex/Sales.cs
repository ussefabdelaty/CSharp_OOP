namespace _21_inheritance_ex
{
    public class Sales : Employee
    {
        public Sales(int id, string name, decimal loggedhours, decimal wage, decimal salesvol,decimal commission) :
            base(id, name, loggedhours, wage)
        {
            this.SalesVol = salesvol;
            this.Commission = commission;   
        }
        protected decimal SalesVol { get; set; }
        public decimal Commission { get; set; }


        protected override decimal CalculateSal()
        {
            return base.CalculateSal() + CalculateBonus() ;
        }

        private decimal CalculateBonus()
        {
          return  SalesVol* Commission;
        }
       
        public override string ToString()
        {
            return base.ToString() +
                $"\nCommision:{Math.Round(Commission,2):N0}"+
                $"\nallowance: {CalculateBonus()}" +
                $"\nnetsalary:{this.CalculateSal()}";
        }


    }
 
}