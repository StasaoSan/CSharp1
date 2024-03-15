using Itmo.ObjectOrientedProgramming.Lab1.Entities;
using Itmo.ObjectOrientedProgramming.Lab1.Models.Deflectors;
using Itmo.ObjectOrientedProgramming.Lab1.Models.Engines;
using Itmo.ObjectOrientedProgramming.Lab1.Models.Frame;

namespace Itmo.ObjectOrientedProgramming.Lab1.Models.Ships;

public class Meridian : BaseShip
{
    public Meridian()
    {
        FirstEngine = new ImpulseEngineE();
        AntiNeutrinoEmitter = true;
        Frame = new FrameTypeSecond();
        Deflector = new DeflectorTypeSecond();
    }

    public override ShipSize Size => ShipSize.Medium;
}