// See https://aka.ms/new-console-template for more information
string raspunsUser;

do 
{
    Console.Write("Scrie un cuvant: ");
    raspunsUser = Console.ReadLine();    
    if (raspunsUser == "masina")
    {
        Console.WriteLine("VRUM VRUM VRUM!!!");
    }
    else 
    {
        Console.WriteLine($"Ai scris: {raspunsUser}");
    }
    
    
} while (raspunsUser != "stop");

Console.Clear();
Console.WriteLine("Ati iesit din program");


