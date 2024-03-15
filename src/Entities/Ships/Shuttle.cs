using Itmo.ObjectOrientedProgramming.Lab1.Entities;
using Itmo.ObjectOrientedProgramming.Lab1.Models.Engines;
using Itmo.ObjectOrientedProgramming.Lab1.Models.Frame;

namespace Itmo.ObjectOrientedProgramming.Lab1.Models.Ships;

public class Shuttle : BaseShip
{
    public Shuttle()
    {
        FirstEngine = new ImpulseEngineC();
        Frame = new FrameTypeFirst();
        Deflector = null;
    }

    public override ShipSize Size => ShipSize.Small;
}