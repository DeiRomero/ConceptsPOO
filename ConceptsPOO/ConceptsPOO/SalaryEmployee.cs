namespace ConceptsPOO
{
    public class SalaryEmployee : Employee

    {
        public decimal Salary { get; set; }
        public override decimal GetValueToPay()
        {
            return Salary;
        }

        public override string ToString()
        {
            return $"{base.ToString()}" +
                $"\n\t Value to pay:.........{GetValueToPay():C2}";
        }
    }
}
