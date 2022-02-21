namespace ConceptsPOO
{
    public abstract class Employee : IPay
    {
        public int Id { get; set; }

        public string FirsName { get; set; }

        public string LastName { get; set; }

        public Date BisthDate { get; set; }

        public Date HisthDate { get; set; }

        public bool IsActive { get; set; }

        public abstract decimal GetValueToPay();

        public override string ToString()
        {
            return $"Id: {Id}, "+
                $"Name: {FirsName}, " +
                $"LastName: {LastName}, " +
                $"Birth: {BisthDate}, " +
                $"Hiring: {HisthDate}, " +
                $"Is active: {IsActive},";
        }


    }
}
