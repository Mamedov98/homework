// See https://aka.ms/new-console-template for more information


IRuler Km = new Kilometer(100f); 
IRuler ML = new AdapterForMilles(100f);
IRuler Knots = new AdapterForKnots(100f);

Console.WriteLine("Километры " + Km.GetLenght());
Console.WriteLine("Мили " + ML.GetLenght());
Console.WriteLine("Узлы " + Knots.GetLenght());

Km.AdJust();
ML.AdJust();    
Knots.AdJust();
    
interface IRuler
{
    float GetLenght();

    void AdJust();
}
class Kilometer : IRuler
{
    float CurretnLenght;
    public Kilometer(float curretnLenght)
    {
        CurretnLenght = curretnLenght;
    }

    public float GetLenght()
    {
        return CurretnLenght;
    }

    public void AdJust()
    {
        Console.WriteLine(" Регулировка в Километр");
    }
}
class Milles
{
    float CurrentLenght;
    public Milles(float currentLenght)
    {
        CurrentLenght = currentLenght;
    }
    public float GetLenght()
    {
        return CurrentLenght;
    }
    protected void AdJust()
    {
        Console.WriteLine("Регулировка в мили");
    }
}
class Knots
{
    float CurrentLenght;
    public Knots(float currentLenght)
    {
        CurrentLenght = currentLenght;
    }
    public float GetLenght()
    {
        return CurrentLenght;
    }
    protected void AdJust()
    {
        Console.WriteLine("Регулировка в Узлы");
    }
}

internal class AdapterForMilles : Milles, IRuler
{
   public AdapterForMilles (float currentLenght) : base(currentLenght)
    {

    }
    float IRuler.GetLenght()
    {
       return base.GetLenght() * 1.609f; 
    }

    void IRuler.AdJust()
    {
        base.AdJust();
        Console.WriteLine("регулировка длины в Милях");
    }

}internal class AdapterForKnots :Knots, IRuler
{
   public AdapterForKnots(float currentLenght) : base(currentLenght)
    {

    }
    float IRuler.GetLenght()
    {
       return base.GetLenght() * 1.852f; 
    }

    void IRuler.AdJust()
    {
        base.AdJust();
        Console.WriteLine("регулировка длины в Узлах");
    }

}

