using Itmo.ObjectOrientedProgramming.Lab1.Entities;
using Itmo.ObjectOrientedProgramming.Lab1.Models.Deflectors;
using Itmo.ObjectOrientedProgramming.Lab1.Models.Engines;
using Itmo.ObjectOrientedProgramming.Lab1.Models.Frame;

namespace Itmo.ObjectOrientedProgramming.Lab1.Models.Ships;

public class Augur : BaseShip
{
    public Augur()
    {
        FirstEngine = new ImpulseEngineE();
        SecondEngine = new JumpEngineAlpha();
        Frame = new FrameTypeThird();
        Deflector = new DeflectorTypeThird();
    }

    public override ShipSize Size => ShipSize.Big;
}