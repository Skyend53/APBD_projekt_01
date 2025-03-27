class Program
{
    static void Main()
    {
        Console.WriteLine("=== stworzenie statkow ===");
        Ship ship1 = new Ship("Swift Sparrow", 10, 40000, 20);
        Ship ship2 = new Ship("Greedy Gull", 7, 35000, 18);
        Console.WriteLine(ship1);
        Console.WriteLine(ship2);
        
        Console.WriteLine("\n=== stworzenie kontenerow ===");
        LiquidContainer milkContainer = new LiquidContainer(10000, 300, 2000, 250, false);
        GasContainer heliumContainer = new GasContainer(5000, 280, 1200, 230, 8);
        RefrigeratedContainer bananaContainer = new RefrigeratedContainer(8000, 350, 2500, 270, "bananas");
        Console.WriteLine(milkContainer);
        Console.WriteLine(heliumContainer);
        Console.WriteLine(bananaContainer);
        
        Console.WriteLine("\n=== zaladowanie kontenerow ladunkiem ===");
        milkContainer.Load(9000);
        heliumContainer.Load(2500);
        bananaContainer.Load(7000);
        Console.WriteLine(milkContainer);
        Console.WriteLine(heliumContainer);
        Console.WriteLine(bananaContainer);
        
        Console.WriteLine("\n=== zaladowanie kontenerow na statek ===");
        ship1.LoadContainer(milkContainer);
        ship1.LoadContainer(heliumContainer);
        ship1.LoadContainer(bananaContainer);
        Console.WriteLine(ship1);
        
        Console.WriteLine("\n=== przeniesienie kontenerwo miedzy statkami ===");
        ship1.TransferContainerTo(ship2, milkContainer.SerialNumber);
        Console.WriteLine(ship1);
        Console.WriteLine(ship2);
        
        Console.WriteLine("\n=== usuniecie kontenera ze statku ===");
        ship1.UnloadContainer(heliumContainer.SerialNumber);
        Console.WriteLine(ship1);
        
        Console.WriteLine("\n=== zastapienie kontenera innym kontenerem ===");
        RefrigeratedContainer cheeseContainer = new RefrigeratedContainer(8000, 350, 2500, 270, "cheese");
        ship1.LoadContainer(cheeseContainer);
        Console.WriteLine(ship1);
        
        Console.WriteLine("\n=== rozladowanie kontenera ===");
        bananaContainer.Unload();
        Console.WriteLine(bananaContainer);
        
        Console.WriteLine("\n=== wypisanie informacji o kontenerach ===");
        Console.WriteLine(milkContainer);
        Console.WriteLine(heliumContainer);
        Console.WriteLine(bananaContainer);
        
        Console.WriteLine("\n=== wypisanie informacji o statkach ===");
        Console.WriteLine(ship1);
        Console.WriteLine(ship2);
    }
}

