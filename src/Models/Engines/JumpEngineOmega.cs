using Itmo.ObjectOrientedProgramming.Lab1.Servises.Enviroments;

namespace Itmo.ObjectOrientedProgramming.Lab1.Models.Engines;

public class JumpEngineOmega : JumpEngine
{
    public override string NameEngine => "JumpEngineOmega";

    protected override double MaxLenghtJump => 500;

    protected override double CountFuelRate(BaseEnviroment enviroment)
    {
        return Math.Log2(enviroment.DistanceToDestination) * enviroment.DistanceToDestination;
    }
}