using Itmo.ObjectOrientedProgramming.Lab1.Models.Fuels;
using Itmo.ObjectOrientedProgramming.Lab1.Servises.Enviroments;

namespace Itmo.ObjectOrientedProgramming.Lab1.Entities;

public abstract class BaseEngine
{
    public double Time { get; protected set; }
    public abstract string NameEngine { get; }
    protected double FuelConsumption { get; set; }
    protected FuelType Fuel { get; set; }

    public void Run(BaseEnviroment enviroment)
    {
        if (enviroment == null)
            throw new ArgumentException("Error: enviroment cant be null (BaseEngine.cs, Run)");
        StartEngine();

        double fuelRequiredForDistanceImpulse = CountFuelRate(enviroment);
        double timeRequiredImpulse = enviroment.DistanceToDestination / GetCurrentSpeed(enviroment);
        FuelConsumption += fuelRequiredForDistanceImpulse;

        Time += timeRequiredImpulse;
    }

    public double PriseFuel()
    {
        FuelInfo fuelInfo = FuelExchange.Instance.FindFuelInfo(Fuel);
        return fuelInfo.Price * FuelConsumption;
    }

    protected abstract double CountFuelRate(BaseEnviroment enviroment);
    protected virtual void StartEngine() { }

    protected abstract double GetCurrentSpeed(BaseEnviroment enviroment);
}
