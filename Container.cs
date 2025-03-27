using System;
using System.Collections.Generic;
using System.Linq;

public abstract class Container
{
    
    private static int _counter = 1;
    
    public string SerialNumber { get; }
    public double Capacity { get; }
    public double Height { get; }
    public double Weight { get; }
    public double Depth { get; }
    
    public double LoadMass { get; private set; }

    protected Container(string type, double capacity, double height, double weight, double depth)
    {
        SerialNumber = "KON-" + type + "-" + _counter++;
        Capacity = capacity;
        Height = height;
        Weight = weight;
        Depth = depth;
        LoadMass = 0;
    }

    public virtual void Load(double mass)
    {
        if (LoadMass + mass > Capacity)
            throw new OverfillException("blad - przekroczono pojemnosc kontenera OverfillException");
        LoadMass += mass;
    }

    public virtual void Unload()
    {
        LoadMass = 0;
    }

    protected void SetLoadMass(double mass)
    {
        LoadMass = mass;
    }

    public override string ToString() => SerialNumber + " - Załadunek: " + LoadMass + "/" + Capacity + " kg, Wysokość: " + Height + " cm, Waga: " + Weight + " kg, Głębokość: " + Depth + " cm";
}