using Itmo.ObjectOrientedProgramming.Lab1.Servises.Obstacle;

namespace Itmo.ObjectOrientedProgramming.Lab1.Servises.Enviroments;

public class NeurtinoSpace
    : BaseEnviroment
{
    public NeurtinoSpace(double distanseToDestination)
        : base(distanseToDestination, new List<BaseObstacle> { new SpaceWhale() })
    {
    }
}