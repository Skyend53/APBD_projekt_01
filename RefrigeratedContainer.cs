public class RefrigeratedContainer : Container
{
    public string ProductType { get; }
    public double RequiredTemperature { get; }

    private static readonly Dictionary<string, double> ProductTemperatures = new()
    {
        {"bananas", 13.3},
        {"chocolate", 18},
        {"fish", 2},
        {"meat", -15},
        {"ice cream", -18},
        {"frozen pizza", -30},
        {"cheese", 7.2},
        {"sausages", 5},
        {"butter", 20.5},
        {"eggs", 19}
    };
    
    public RefrigeratedContainer(double capacity, double height, double weight, double depth, string productType) 
        : base("C", capacity, height, weight, depth)
    {
        if (!ProductTemperatures.ContainsKey(productType))
            throw new ArgumentException("nie mam tego produktu na liscie (banans, chocolate, fish,meat, ice cream, frozen pizza, cheese, sausages, butter, eggs) ArgumentException");
        
        ProductType = productType;
        RequiredTemperature = ProductTemperatures[productType];
    }
    
    public override string ToString()
    {
        return base.ToString() + ", Produkt: " + ProductType + ", Temp: " + RequiredTemperature + "°C";
    }
}