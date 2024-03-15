using Itmo.ObjectOrientedProgramming.Lab1.Entities;
using Itmo.ObjectOrientedProgramming.Lab1.Models.Fuels;

namespace Itmo.ObjectOrientedProgramming.Lab1.Models.Engines;
public abstract class ImpulseEngine : BaseEngine
{
    private int _startConsumption = 10;
    protected ImpulseEngine()
    {
        Fuel = FuelType.ActivePlasma;
    }

    protected override void StartEngine()
    {
        base.StartEngine();

        FuelConsumption += _startConsumption;
    }
}