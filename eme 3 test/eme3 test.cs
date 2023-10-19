string nazwisko = Console.ReadLine();
string[] input = nazwisko.Split(' ');
int wiek = int.Parse(input[1]);
int emeryt = int.Parse(input[2]);
int roz = emeryt - wiek;
int last = (emeryt - wiek) % 10;
string afix = " ";

if (wiek >= 0 && emeryt >= 0)
{
    if (wiek >= emeryt)
    {
        Console.WriteLine( $"Witaj emerycie {input[0]}!");
    }
    else
    {
        Console.Write($"Witaj {input[0]} ");
        switch (last)
        {
            case 1: afix = roz == 1? "rok" : "lat"; break;
            case 2: case 3: case 4: afix = roz > 10 && roz < 20? "lat" : "lata"; break;
            case 5: case 6: case 7: case 8: case 9: case 0: afix = "lat"; break;
        }
        Console.WriteLine($"Do emerytury brakuje Ci {roz} {afix}!");
    }
}
else
{
    Console.WriteLine("Wiek nie może być ujemny!");
}
