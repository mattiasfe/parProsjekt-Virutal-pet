namespace ObjektOrienteringOSV;

public class Mattias
{
    private int age = 24;
    private int height = 173;
    private int weight = 70;
    
    
    public  string GetStatus()
    {
        return $"Alder: {age}, Høyde: {height}, Vekt: {weight}";
    }
    public void Workout()
    {
        weight--;
    }    
    public void Eat()
    {
        weight++;
    }
}

