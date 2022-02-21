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
    Salary = 1815453.45M,


};

//Console.WriteLine(employee1);

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

//Console.WriteLine(employee2);

Employee employee3 = new HourlyEmployee()
{
    Id = 3030,
    FirsName = "Gonzalo",
    LastName = "Cardona",
    BisthDate = new Date(1985, 5, 23),
    HisthDate = new Date(2022, 2, 5),
    IsActive = true,
    hourValue = 12356.56M,
    Hours = 123.5F,


};

//Console.WriteLine(employee3);

Employee employee4 = new BaseCommissionEmployee()
{
    Id = 4040,
    FirsName = "Yasmiz",
    LastName = "Salazar",
    BisthDate = new Date(1988, 5, 23),
    HisthDate = new Date(2022, 1, 15),
    IsActive = true,
    Base = 860678.45M,
    Sales = 58000000M,
    CommissionPercentaje = 0.015F


};

//Console.WriteLine(employee4);

ICollection<Employee> employees = new List<Employee>()
{ 

    employee1, employee2, employee3, employee4
};

//employees.Add(employee1);
//employees.Add(employee2);
//employees.Add(employee3);
//employees.Add(employee4);

decimal payroll = 0;
foreach (Employee employee in employees)
{
    Console.WriteLine(employee);
    payroll += employee.GetValueToPay();

}

Console.WriteLine("                               ==================");
Console.WriteLine($"TOTAL                           {$"{payroll:C2}",15}");

Console.WriteLine();
Console.WriteLine();

Invoice invoice1 = new Invoice()
{
    Description = "Iphone 13",
    Price = 5300000M,
    Quantity = 6

};


Invoice invoice2 = new Invoice()
{
    Description = "Posta premium",
    Price = 32000M,
    Quantity = 17.5F

};

Console.WriteLine(invoice1);
Console.WriteLine();
Console.WriteLine(invoice2);

