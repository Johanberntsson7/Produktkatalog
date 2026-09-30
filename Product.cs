namespace Produktkatalog;


public class Product

{
    public string Name = "";

    public double Price = 0;

    public int Quantity = 0;

    public void Readinfo()
    {
        Console.WriteLine("Vad vill du lägga till för varor");
        Name = Console.ReadLine()!;
        Console.WriteLine("Hur mycket kostar den?");
        Price = double.Parse(Console.ReadLine()!);
        Console.WriteLine("Hur många vill du ha?");
        Quantity = int.Parse(Console.ReadLine()!);
    }

    public void PrintInfo()
    {
        Console.WriteLine($"Du valde {Name} som kostar {Price} och du ville ha så här många {Quantity}");
    }

    public void GetTotalPrice()
    {
        double TotalPrice = Price * Quantity;
        Console.WriteLine($"Totalsumma {Name}: {TotalPrice}kr");
    }
    
}
    
        

    
        