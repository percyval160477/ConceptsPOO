// See https://aka.ms/new-console-template for more information
using POOConcepts;

Console.WriteLine("POOConcepts");
Console.WriteLine("=============");
//Instanciar un objeto de la clase year
//Date date1 = new Date(2022,2,11);
//Console.WriteLine(date1);
//CTRL + K, CTRL + S
//try
//{
//	Console.WriteLine(new Date(2022, 2, 29));
//	Console.WriteLine(new Date(1974, 9, 23));
//	Console.WriteLine(new Date(1985, 11, 31));
//}
//catch (Exception error)
//{
//	Console.WriteLine(error.Message);
//}

Employee employee1 = new SalaryEmployee()
{
    Id=1010,
    Firstname="Sandra",
    Lastname="Morales",
    BirthDate=new Date(1990,5,23),
    HiringDate= new Date(2022, 1, 15),
    IsActive=true,
    Salary=1815453.45M
};
Console.WriteLine(employee1);

Employee employee2 = new CommissionEmployee()
{
    Id = 2020,
    Firstname = "Patricia",
    Lastname = "Gutierrez",
    BirthDate = new Date(1995, 5, 23),
    HiringDate = new Date(2022, 2, 5),
    IsActive = true,
    Sales = 320000000M,
    CommissionPercentaje = 0.03F
};
Console.WriteLine(employee2);