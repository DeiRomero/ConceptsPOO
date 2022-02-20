using ConceptsPOO;

Console.WriteLine("ConceptsPOO");
Console.WriteLine("===========");

Employee employee1 = new SalaryEmployee()
{
    Id = 1010,
    FirsName = "Sandra",
    LastName = "Morales",
    BisthDate = new Date(1990, 5, 23),
    HisthDate = new Date(2022, 1, 15),
    IsActive = true,
    Salary = 181545.45M


};

Console.WriteLine(employee1);

Employee employee2 = new CommissionEmployee()
{
    Id = 2020,
    FirsName = "Patricia",
    LastName = "Gutierrez",
    BisthDate = new Date(1995, 5, 23),
    HisthDate = new Date(2022, 2, 5),
    IsActive = true,
    Sales = 320000000M,
    CommissionPercentaje = 0.03F    


};

Console.WriteLine(employee2);

