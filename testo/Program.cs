string input = "Molenda 55 65";
string[] subs = input.Split(' ');
int wiek = int.Parse(subs[1]);
int emeryt = int.Parse(subs[2]);


Console.WriteLine($"wiek = {wiek}");
Console.WriteLine($"emeryt = {emeryt}");
Console.WriteLine($"Roznica = {emeryt - wiek}");



/*
foreach (var sub in subs)
{
    Console.WriteLine($"Substring: {sub}");
}
*/