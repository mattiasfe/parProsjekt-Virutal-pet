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
                SelectedPerson(mattias);
                break;
            case "Martin":
                Martin martin = new Martin();
                Console.WriteLine(martin.GetStatus());
                SelectedPerson(martin);
                break;
            default:
                Console.WriteLine("Try again");
                break;
        }
    
    }

    static void SelectedPerson(object person)
    {
        Console.WriteLine("Hva vill du gjøre? 'eat' eller 'workout'");
            string valg = Console.ReadLine();
            
        if (person is Mattias mattias)
        {
            switch (valg)
            {
                case "workout":
                    mattias.Workout();
                    Console.WriteLine(mattias.GetStatus());
                    break;          
                case "eat":
                    mattias.Eat();
                    Console.WriteLine(mattias.GetStatus());
                    break;
                default:
                    Console.WriteLine("Try again");
                    break;
            }
            
        }
        else if (person is Martin martin)
        {
            switch (valg)
            {
                case "workout":
                    martin.Workout();
                    Console.WriteLine(martin.GetStatus());
                    break;          
                case "eat":
                    martin.Eat();
                    Console.WriteLine(martin.GetStatus());
                    break;
                default:
                    Console.WriteLine("Try again");
                    break;
            }
        }
    }
}