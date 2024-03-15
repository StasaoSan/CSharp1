using Itmo.ObjectOrientedProgramming.Lab1.Entities;
using Itmo.ObjectOrientedProgramming.Lab1.Models.Deflectors;
using Itmo.ObjectOrientedProgramming.Lab1.Models.Engines;
using Itmo.ObjectOrientedProgramming.Lab1.Models.Frame;

namespace Itmo.ObjectOrientedProgramming.Lab1.Models.Ships;

public class Vaklas : BaseShip
{
    public Vaklas()
    {
        FirstEngine = new ImpulseEngineE();
        SecondEngine = new JumpEngineGamma();
        Frame = new FrameTypeSecond();
        Deflector = new DeflectorTypeFirst();
    }

    public override ShipSize Size => ShipSize.Medium;
}