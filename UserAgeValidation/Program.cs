// See https://aka.ms/new-console-template for more information

//rakendus küsib kasutaja soo (m/f)
//rakendus küsib kasutajalt tema perekonnanime
//lähtudes valikust, rakendus tervitab kasutajat järgmiselt:
//"Welcome, Mr. [kasutaja perekonnanimi]" / "Welcome, Ms. [kasutaja perekonnanimi]"


Console.WriteLine("PLease select your gender (m/f)");

char userGender = Char.Parse(Console.ReadLine()); //loeb andmeid string (sõne) formaadis

Console.WriteLine("Please enter your last name:");
string userLastName = Console.ReadLine();

if (userGender == 'm')
{
    Console.WriteLine($"Welcome, Mr.{userLastName}!");
}
else if (userGender == 'f')
{
    Console.WriteLine($"Welcome, Ms.{userLastName}!");
}
else
{
    Console.WriteLine($"Welcome, {userLastName}!");
}


