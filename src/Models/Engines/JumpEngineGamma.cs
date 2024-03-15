using Itmo.ObjectOrientedProgramming.Lab1.Servises.Enviroments;

namespace Itmo.ObjectOrientedProgramming.Lab1.Models.Engines;

public class JumpEngineGamma : JumpEngine
{
    public JumpEngineGamma()
    {
    }

    public override string NameEngine => "JumpEngineGamma";

    protected override double MaxLenghtJump => 300;

    protected override double CountFuelRate(BaseEnviroment enviroment)
    {
        return Math.Pow(enviroment.DistanceToDestination, 2);
    }
}