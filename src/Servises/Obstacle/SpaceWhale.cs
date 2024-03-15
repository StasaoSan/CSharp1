using Itmo.ObjectOrientedProgramming.Lab1.Entities;

namespace Itmo.ObjectOrientedProgramming.Lab1.Servises.Obstacle;

public class SpaceWhale : BaseObstacle
{
    private const double Damage = 1320;
    private const string SpaceWhaleName = "SpaceWhale";
    private int _whalePackSize = 1;
    public SpaceWhale(int packSize = 1)
        : base(Damage, SpaceWhaleName)
    {
        _whalePackSize = packSize;
    }

    public override void InflictDamage(BaseShip ship)
    {
        if (ship.AntiNeutrinoEmitter)
            return;

        bool isDeflected = ship.Deflector?.AbsorbDamage(DamagePoints) ?? false;

        bool isAbsorbed = !isDeflected && (ship.Frame?.AbsorbDamage(DamagePoints) ?? false);

        if (!isDeflected && !isAbsorbed)
        {
            ship.KillShip();
        }
    }
}
