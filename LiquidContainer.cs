public class LiquidContainer : Container, IHazardNotifier
{
    private bool _isHazardous;

    public LiquidContainer(double capacity, double height, double weight, double depth, bool isHazardous) : base("L", capacity, height, weight, depth)
    {
        _isHazardous = isHazardous;
    }

    public override void Load(double mass)
    {
        double limit = _isHazardous ? Capacity * 0.5 : Capacity * 0.9;
        if (mass > limit)
            NotifyHazard("blad - przekroczono limit bezpieczenstwa dla cieczy NotifyHazard");
        base.Load(mass);
    }

    public void NotifyHazard(string message)
    {
        Console.WriteLine("| !!! | " + SerialNumber + ": " + message);
    }
}