//Rakendus küsib kasutaja vanust
//kui vanus on väiksem kui 13 siis konsoolis kuvatakse: 
//"You are too young to use instagram"
//teistel juhtudel
//konsoolis kuvatakse "Welcome to Instagram"

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Enter your age:");

        int userAge = int.Parse(Console.ReadLine()); //"13" - heap, 13 - stack

        if (userAge >= 13)
        {
            Console.WriteLine("Welcome to Instagram");
        }
        else
        {
            Console.WriteLine("You are too young to use instagram.");
        }
    }
}