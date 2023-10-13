string imie = Console.ReadLine();
//string imie = "Molenda 55 65";
string[] input = imie.Split(' ');
int wiek = int.Parse(input[1]);
int emeryt = int.Parse(input[2]);
int roz = emeryt - wiek;
int last = roz % 10;
//int emeryt = 65;
int pol = 0;
//Console.Write($"Witaj {input[0]}! ");

if (wiek < 0 || emeryt < 0)
{
    pol = 4;
}
else if (roz == 0)
{
    pol = 5;
}
else if (roz == 1)
{
    pol = 1;
}
else if (last > 1 && last < 5)
{
    pol = 2;
}
else if ((last >= 5 && last <= 9) || last == 0)
{
    pol = 3;
}
else if (wiek >= emeryt)
{
    pol = 5;
}
else 
{
    pol = 6;
}

switch (pol)
{
    case 1:
        Console.WriteLine($"Witaj {input[0]}! Do emerytury brakuje Ci {roz} rok! ");
        break;
    case 2:
        Console.WriteLine($"Witaj {input[0]}! Do emerytury brakuje Ci {roz} lata! ");
        break;
    case 3:
        Console.WriteLine($"Witaj {input[0]}! Do emerytury brakuje Ci {roz} lat! ");
        break;
    case 4:
        Console.WriteLine("Wiek nie może być ujemny!");
        break;
    case 5:
        Console.WriteLine($"Witaj emerycie {input[0]}!");
        break;
    case 6:
        Console.WriteLine("Błąd! Nieobsługiwane dane, proszę skontaktuj się z developerem. tel: 6969");
        break;
}


/*
końcówki
1
rok
2
3
4
lata
5
6
7
8
9
0
lat







*/

/*if (wiek < 0 || emeryt < 0)
{
    Console.WriteLine("Wiek nie może być ujemny!");
}
else if (wiek >= emeryt)
{
    Console.WriteLine("Jesteś emerytem!");
}
else
{
    Console.WriteLine($"Do emerytury brakuje ci {emeryt - wiek} lat!");
}*/