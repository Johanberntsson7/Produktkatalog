namespace Produktkatalog;

class Program
{
    static void Main(string[] args)
    {


        Product product = new Product();
        product.Readinfo();
        product.PrintInfo();
        
        

        Product product1 = new Product();
        product1.Readinfo();
        product1.PrintInfo();
        product1.GetTotalPrice();
        product.GetTotalPrice();
        
        double TotalSum1 = product.Price * product.Quantity;
        double Totalsum2 = product1.Price * product1.Quantity;
        double TotalTotal = TotalSum1 + Totalsum2;
        Console.WriteLine($"{TotalSum1} + {Totalsum2} = {TotalTotal}");
        
        
    }

    
}
