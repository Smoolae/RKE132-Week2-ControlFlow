// See https://aka.ms/new-console-template for more information

//rakendus küsib kasutajalt sisetada enda vanuse
//kui kasutaja vanus on väiksem kui 13, siis konsoolis kuvatakse:
//"You are too young to use this program"
//muul juhul:
//"Welcome to program"

Console.WriteLine("Please enter your age:");
string userAge = Console.ReadLine();

int userAgeNum = 0;

//boolean - true/false

bool isAgeNumber = Int32.TryParse(userAge, out userAgeNum);
Console.WriteLine($"Parse result {isAgeNumber}. User is {userAgeNum} years old.");

if(isAgeNumber)
{
    if (userAgeNum >= 13)
    {
        Console.WriteLine("Welcome to program!");
    }
    else
    {
        Console.WriteLine("You are too young to use this program");
    }
}
else
{
    Console.WriteLine("Could not read your age. Enter your age using numbers");
}









//int userAge = Int32.Parse(Console.ReadLine()); //"13" - heap, 13 - stack

//if (userAge >= 13)
//{
    //Console.WriteLine("Welcome to program!");
//}
//else //if (userAge < 13)
//{
    //Console.WriteLine("You are too young to use this program");
//}


