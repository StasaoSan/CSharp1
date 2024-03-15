using Itmo.ObjectOrientedProgramming.Lab1.Entities;
using Itmo.ObjectOrientedProgramming.Lab1.Models.Fuels;
using Itmo.ObjectOrientedProgramming.Lab1.Servises.Enviroments;

namespace Itmo.ObjectOrientedProgramming.Lab1.Models.Engines;

public abstract class JumpEngine : BaseEngine
{
    private const double SpeedJumpEngine = 1000;
    protected JumpEngine()
    {
        Fuel = FuelType.GravitonMatter;
    }

    protected abstract double MaxLenghtJump { get; }

    public bool Jump(double channelLenght)
    {
        return channelLenght <= MaxLenghtJump;
    }

    protected override double GetCurrentSpeed(BaseEnviroment enviroment)
    {
        return SpeedJumpEngine;
    }
}