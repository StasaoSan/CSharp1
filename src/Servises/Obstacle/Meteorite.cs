using Itmo.ObjectOrientedProgramming.Lab1.Entities;

namespace Itmo.ObjectOrientedProgramming.Lab1.Servises.Obstacle;

public class Meteorite : BaseObstacle
{
    private const double Damage = 66;
    private const string MeteoriteName = "Meteorite";
    public Meteorite()
        : base(Damage, MeteoriteName)
    {
    }

    public override void InflictDamage(BaseShip ship)
    {
        bool isDeflected = ship.Deflector?.AbsorbDamage(DamagePoints) ?? false;

        bool isAbsorbed = !isDeflected && (ship.Frame?.AbsorbDamage(DamagePoints) ?? false);

        if (!isDeflected && !isAbsorbed)
        {
            ship.KillShip();
        }
    }
}
