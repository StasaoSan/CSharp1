using Itmo.ObjectOrientedProgramming.Lab1.Entities;

namespace Itmo.ObjectOrientedProgramming.Lab1.Servises.Obstacle;

public class Asteroid : BaseObstacle
{
    private const double Damage = 33;
    private const string AsteroidName = "Asteroid";
    public Asteroid()
        : base(Damage, AsteroidName)
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
