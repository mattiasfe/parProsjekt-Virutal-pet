namespace ObjektOrienteringOSV;

public class MainProgram
{
    static void Main(string[] args)
    {
        Console.WriteLine("Select Person");
        Console.WriteLine("Mattias");
        Console.WriteLine("Martin");
    
        string valg = Console.ReadLine();

        switch (valg)
        {
            case "Mattias":
                Mattias mattias = new Mattias();
                Console.WriteLine(mattias.GetStatus());
                break;
            case "Martin":
                Martin martin = new Martin();
                Console.WriteLine(martin.GetStatus());
                break;
            default:
                Console.WriteLine("Try again");
                break;
        }
    
    }
}