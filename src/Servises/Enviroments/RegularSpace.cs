using Itmo.ObjectOrientedProgramming.Lab1.Servises.Obstacle;

namespace Itmo.ObjectOrientedProgramming.Lab1.Servises.Enviroments;

public class RegularSpace : BaseEnviroment
{
    public RegularSpace(double distanceToDestination)
        : base(distanceToDestination, new List<BaseObstacle> { new Asteroid(), new Meteorite() })
    {
    }
}