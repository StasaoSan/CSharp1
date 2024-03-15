using Itmo.ObjectOrientedProgramming.Lab1.Entities;
using Itmo.ObjectOrientedProgramming.Lab1.Models.Deflectors;
using Itmo.ObjectOrientedProgramming.Lab1.Models.Engines;
using Itmo.ObjectOrientedProgramming.Lab1.Models.Frame;

namespace Itmo.ObjectOrientedProgramming.Lab1.Models.Ships;

public class Stella : BaseShip
{
    public Stella()
    {
        FirstEngine = new ImpulseEngineC();
        SecondEngine = new JumpEngineOmega();
        Frame = new FrameTypeFirst();
        Deflector = new DeflectorTypeFirst();
    }

    public override ShipSize Size => ShipSize.Small;
}