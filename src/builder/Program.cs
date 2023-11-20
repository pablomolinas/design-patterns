using builder;
using builder.Abstractions;

public class App
{
    public static void Main()
    {
        var director = new Director();
        IBuilder productGeneralBuilder = new ProductGeneralBuilder();
        IBuilder productServiceBuilder = new ProductServiceBuilder();

        director.SetBuilder(productGeneralBuilder);
        director.Build();
        var generalProduct = productGeneralBuilder.GetResult();
        generalProduct.ShowInfo();

        Console.WriteLine("-----------------------------");

        director.SetBuilder(productServiceBuilder);
        director.Build();
        var serviceProduct = productServiceBuilder.GetResult();
        serviceProduct.ShowInfo();
    }
}