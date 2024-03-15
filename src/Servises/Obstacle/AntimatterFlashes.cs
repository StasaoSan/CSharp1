using Itmo.ObjectOrientedProgramming.Lab1.Entities;

namespace Itmo.ObjectOrientedProgramming.Lab1.Servises.Obstacle;

public class AntimatterFlashes : BaseObstacle
{
    private const double Damage = 0;
    private const string AntimatterFlashesName = "AntimatterFlashes";
    public AntimatterFlashes()
        : base(Damage, AntimatterFlashesName)
    {
    }

    public override void InflictDamage(BaseShip ship)
    {
        if (ship.Deflector is null || ship.Deflector.PhotonDeflector is null ||
            (ship.Deflector.PhotonDeflector.UsageCount >= ship.Deflector.PhotonDeflector.MaxUsageCount))
        {
            ship.KillCrew();
            return;
        }

        ship.Deflector.PhotonDeflector.UsagePhotonDeflector();
    }
}
