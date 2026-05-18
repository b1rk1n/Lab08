using System;

public class Planet
{
    public string Name { get; set; }
    public string StarSystem { get; set; }
    public double DiameterKm { get; set; }
    public double DistanceFromSunMln { get; set; }
    public double MassKg { get; set; }
    public int NumberOfMoons { get; set; }
    public bool HasRings { get; set; }
    public bool HasAtmosphere { get; set; }

    public double GetSurfaceArea()
    {
        double radius = DiameterKm / 2.0;
        return 4 * Math.PI * radius * radius;
    }

    public Planet() { }

    public Planet(string name, string starSystem, double diameterKm,
                  double distanceFromSunMln, double massKg,
                  int numberOfMoons, bool hasRings, bool hasAtmosphere)
    {
        Name = name;
        StarSystem = starSystem;
        DiameterKm = diameterKm;
        DistanceFromSunMln = distanceFromSunMln;
        MassKg = massKg;
        NumberOfMoons = numberOfMoons;
        HasRings = hasRings;
        HasAtmosphere = hasAtmosphere;
    }
}