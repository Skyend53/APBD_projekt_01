public class Ship
{
    public string Name { get; }
    public int MaxContainers { get; }
    public double MaxWeight { get; }
    public double MaxSpeed { get; }
    private List<Container> _containers = new();

    public Ship(string name, int maxContainers, double maxWeight, double maxSpeed)
    {
        Name = name;
        MaxContainers = maxContainers;
        MaxWeight = maxWeight;
        MaxSpeed = maxSpeed;
    }

    public void LoadContainer(Container container)
    {
        if (_containers.Count >= MaxContainers || GetTotalWeight() + container.LoadMass > MaxWeight)
            throw new OverfillException("statek nie moze miec wiecej kontenerow OverfillException");
        _containers.Add(container);
    }
    
    public void UnloadContainer(string serialNumber)
    {
        _containers.RemoveAll(c => c.SerialNumber == serialNumber);
    }
    
    public void TransferContainerTo(Ship targetShip, string serialNumber)
    {
        Container container = _containers.FirstOrDefault(c => c.SerialNumber == serialNumber);
        if (container == null) return;
        _containers.Remove(container);
        targetShip.LoadContainer(container);
    }
    
    public double GetTotalWeight() => _containers.Sum(c => c.LoadMass);

    public override string ToString()
    {
        return Name + ": Kontenery " + _containers.Count + "/" + MaxContainers + ", Ładunek: " + GetTotalWeight() + "/" + MaxWeight + " kg" + ", Prędkość maksymalna: " + MaxSpeed + " węzłów";
    }
}