var nazwisko = Console.ReadLine();
int wiek = int.Parse(Console.ReadLine());
int emeryt = int.Parse(Console.ReadLine());
//int emeryt = 65;
Console.WriteLine($"Witaj, {nazwisko}!");

if(wiek < 0 || emeryt < 0)
{
    Console.WriteLine("Wiek nie może być ujemny!");
}
else if(wiek >= emeryt)
{
    Console.WriteLine("Jesteś emerytem!");
}
else 
{
    Console.WriteLine($"Do emerytury brakuje ci {emeryt - wiek} lat!");
}