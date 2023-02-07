// See https://aka.ms/new-console-template for more information
using POOConcepts;

Console.WriteLine("POOConcepts");
Console.WriteLine("=============");
//Instanciar un objeto de la clase year
//Date date1 = new Date(2022,2,11);
//Console.WriteLine(date1);
//CTRL + K, CTRL + S
try
{
	Console.WriteLine(new Date(2022, 2, 29));
	Console.WriteLine(new Date(1974, 9, 23));
	Console.WriteLine(new Date(1985, 11, 31));
}
catch (Exception error)
{
	Console.WriteLine(error.Message);
}