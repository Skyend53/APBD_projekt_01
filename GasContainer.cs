public class GasContainer : Container, IHazardNotifier
{
    public double Pressure { get; }

    public GasContainer(double capacity, double height, double weight, double depth, double pressure) : base("G", capacity, height, weight, depth)
    {
        Pressure = pressure;
    }

    public override void Unload()
    {
        SetLoadMass(LoadMass * 0.05); 
    }

    public void NotifyHazard(string message)
    {
        Console.WriteLine("| !!! | " + SerialNumber + ": " + message);
    }
}