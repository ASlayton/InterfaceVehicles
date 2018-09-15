using System;
using System.Linq;
using System.Collections.Generic;


public interface IVehicle
{
    // an int property called Wheels
    int Wheels { get; set; }
    // an int property called Doors
    int Doors { get; set; }
    // an int property called PassengerCapacity
    int PassengerCapacity { get; set; }
    // a bool property called Winged
    bool Winged { get; set; }
    // a string property called TransmissionType
    string TransmissionType { get; set; }
    // a double property called EngineVolume
    double EngineVolume { get; set; }
    // a double property called MaxWaterSpeed
    double MaxWaterSpeed { get; set; }
    // a double property called MaxLandSpeed
    double MaxLandSpeed { get; set; }
    // a double property called MaxAirSpeed
    double MaxAirSpeed { get; set; }
    // a method called Start() that returns void
    void Start();
    // a method called Stop() that returns void
    void Stop();
    // a method called Drive() that returns void
    void Drive();
    // a method called Fly() that returns void
    void Fly();
}

public class JetSki : IVehicle
{
    public int Wheels { get; set; }
    public int Doors { get; set; }
    public int PassengerCapacity { get; set; }
    public bool Winged { get; set; }
    public string TransmissionType { get; set; }
    public double EngineVolume { get; set; }
    public double MaxWaterSpeed { get; set; }
    public double MaxLandSpeed { get; set; }
    public double MaxAirSpeed { get; set; }

    public void Drive()
    {
        Console.WriteLine("The jetski zips through the waves with the greatest of ease");
    }

    public void Fly()
    {
        throw new NotImplementedException();
    }

    public void Start()
    {
        throw new NotImplementedException();
    }

    public void Stop()
    {
        throw new NotImplementedException();
    }
}

public class Motorcycle : IVehicle
{
    public int Wheels { get; set; } = 2;
    public int Doors { get; set; } = 0;
    public int PassengerCapacity { get; set; }
    public bool Winged { get; set; } = false;
    public string TransmissionType { get; set; } = "Manual";
    public double EngineVolume { get; set; } = 1.3;
    public double MaxWaterSpeed { get; set; }
    public double MaxLandSpeed { get; set; } = 160.4;
    public double MaxAirSpeed { get; set; }

    public void Drive()
    {
        Console.WriteLine("The motorcycle screams down the highway");
    }

    public void Fly()
    {
        throw new NotImplementedException();
    }

    public void Start()
    {
        throw new NotImplementedException();
    }

    public void Stop()
    {
        throw new NotImplementedException();
    }
}

public class Cessna : IVehicle
{
    public int Wheels { get; set; } = 3;
    public int Doors { get; set; } = 3;
    public int PassengerCapacity { get; set; } = 113;
    public bool Winged { get; set; } = true;
    public string TransmissionType { get; set; } = "None";
    public double EngineVolume { get; set; } = 31.1;
    public double MaxWaterSpeed { get; set; }
    public double MaxLandSpeed { get; set; }
    public double MaxAirSpeed { get; set; } = 309.0;

    public void Drive()
    {
        throw new NotImplementedException();
    }

    public void Fly()
    {
        Console.WriteLine("The Cessna effortlessly glides through the clouds like a gleaming god of the Sun");
    }

    public void Start()
    {
        throw new NotImplementedException();
    }

    public void Stop()
    {
        throw new NotImplementedException();
    }
}


public class Program
{

    public static void Main()
    {

        // Build a collection of all vehicles that fly
        List<string> FlyingVehicles = new List<string>();
        FlyingVehicles.Add("Cessna");


        // With a single `foreach`, have each vehicle Fly()
        foreach (var vehicle in FlyingVehicles)
        {
            vehicle.Fly();
        }



        // Build a collection of all vehicles that operate on roads
        List<string> RoadVehicles = new List<string>();
        // With a single `foreach`, have each road vehicle Drive()
        foreach (var vehicle in RoadVehicles)
        {
            vehicle.Drive();
        }


        // Build a collection of all vehicles that operate on water
        List<string> waterVehicles = new List<string>();
        // With a single `foreach`, have each water vehicle Drive()
        foreach (var vehicle in waterVehicles)
        {
            vehicle.Swim();
        }
    }

}