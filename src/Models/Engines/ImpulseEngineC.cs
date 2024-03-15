using Itmo.ObjectOrientedProgramming.Lab1.Servises.Enviroments;

namespace Itmo.ObjectOrientedProgramming.Lab1.Models.Engines;

public class ImpulseEngineC : ImpulseEngine
{
    private readonly double _fuelRateCoefficient = 0.1;
    private double _speed = 200;

    public override string NameEngine => "ImpulceEngineC";

    protected override double GetCurrentSpeed(BaseEnviroment enviroment)
    {
        return _speed;
    }

    protected override double CountFuelRate(BaseEnviroment enviroment)
    {
        if (enviroment is NeurtinoSpace)
            return enviroment.DistanceToDestination * _fuelRateCoefficient * 20;
        return enviroment.DistanceToDestination * _fuelRateCoefficient;
    }
}