using Itmo.ObjectOrientedProgramming.Lab1.Servises.Obstacle;

namespace Itmo.ObjectOrientedProgramming.Lab1.Servises.Enviroments;

public class HightDensitySpase : BaseEnviroment
{
    public HightDensitySpase(double distanceToDestination)
        : base(distanceToDestination, new List<BaseObstacle> { new AntimatterFlashes() })
    {
    }
}