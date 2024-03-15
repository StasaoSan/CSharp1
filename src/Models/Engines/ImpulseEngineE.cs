using Itmo.ObjectOrientedProgramming.Lab1.Servises.Enviroments;

namespace Itmo.ObjectOrientedProgramming.Lab1.Models.Engines;

public class ImpulseEngineE : ImpulseEngine
{
    private readonly double _fuelRateCoefficient = 0.3;

    public override string NameEngine => "ImpulceEngineE";

    protected override double CountFuelRate(BaseEnviroment enviroment)
    {
        return enviroment.DistanceToDestination * _fuelRateCoefficient;
    }

    protected override double GetCurrentSpeed(BaseEnviroment enviroment)
    {
        return Math.Exp(enviroment.DistanceToDestination);
    }
}