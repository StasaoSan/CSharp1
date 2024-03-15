using Itmo.ObjectOrientedProgramming.Lab1.Servises.Enviroments;

namespace Itmo.ObjectOrientedProgramming.Lab1.Models.Engines;

public class JumpEngineAlpha : JumpEngine
{
    private const double _FuelRateCoefficient = 0.4;

    public JumpEngineAlpha()
    {
    }

    public override string NameEngine => "JumpEngineAlpha";

    protected override double MaxLenghtJump => 100;

    protected override double CountFuelRate(BaseEnviroment enviroment)
    {
        return enviroment.DistanceToDestination * _FuelRateCoefficient;
    }
}