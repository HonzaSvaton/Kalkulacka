// See https://aka.ms/new-console-template for more information
Console.Write("Napiš svoje první číslo: ");
double prvnicislo = Convert.ToDouble(Console.ReadLine());

Console.Write("Napiš svoje druhý číslo: ");
double druhecislo = Convert.ToDouble(Console.ReadLine());

Console.Write("Napiš jaké znamínko chceš použít: ");
string znamenko = Console.ReadLine();
if (znamenko != "+" && znamenko != "-" && znamenko != "/" && znamenko != "*")
{
    Console.WriteLine("Zadal jsi neplatné znaménko zadej znovu!!" + "Zadej prosím + - * /");
}
else
{
    if (druhecislo == 0 && znamenko == "/")
    {
        Console.WriteLine("Nulou nelzde dělit!!");
    }
    else
    {
        if (znamenko == "+")
        {
            Console.WriteLine($"Výsledek:  {prvnicislo + druhecislo}");
        }
        else if (znamenko == "-")
        {
            Console.WriteLine($"Výsledek: {prvnicislo - druhecislo}");
        }
        else if (znamenko == "*")
        {
            Console.WriteLine($"Výsledek: {prvnicislo * druhecislo}");
        }
        else if (znamenko == "/")
        {
            Console.WriteLine($"Výsledek: {prvnicislo / druhecislo}");
        }
    }
}
