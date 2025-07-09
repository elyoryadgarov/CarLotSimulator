using System;

namespace CarLotSimulator;

public class Car
{
    public int Year;
    public string Make;
    public string Model;
    public string EngineNoise;
    public string HonkNoise;
    public bool IsDriveable;

    public string MakeEngineNoise(string engineNoise)
    {
        engineNoise = EngineNoise;
        return "Engine Noise: " + engineNoise;
    }
    
    public string MakeHonkeNoise(string honkNoise)
    {
        honkNoise = HonkNoise;
        return "Honk Noise: " + honkNoise;
    }
    public Car() 
    {
        Year = 2015;
        Make = "Lexus";
        Model = "LS 350";
        EngineNoise = "qhhhhh";
        IsDriveable = false;
        HonkNoise = "fffff";
    }

    public void Details()
    {
        Console.WriteLine($"Details of a Car is: {Year} - {Make} - {Model}");
    }
    
}