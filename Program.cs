
using OOP.Classes;

Calculator Ish = new Calculator();

Console.WriteLine("Sonlarni kiriting: ");
Ish.qiymat1 = Convert.ToDouble(Console.ReadLine());
Ish.qiymat2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Operatorni kiriting: ");
string operatorr = Console.ReadLine();

if(operatorr == null)
{
    operatorr = "Null";
}

string Natija = Ish.Hisobla(Ish.qiymat1, Ish.qiymat2, operatorr);
System.Console.WriteLine(Natija);
