using Itmo.ObjectOrientedProgramming.Lab1.Servises.Obstacle;

namespace Itmo.ObjectOrientedProgramming.Lab1.Servises.Enviroments;

public abstract class BaseEnviroment
{
    private readonly List<BaseObstacle> _obstacles = new List<BaseObstacle>();
    private readonly List<BaseObstacle> _allowedObstacles;

    protected BaseEnviroment(double distanceToDestination, IEnumerable<BaseObstacle> allowedObstacles)
    {
        DistanceToDestination = distanceToDestination;
        _allowedObstacles = allowedObstacles.ToList() ?? throw new ArgumentNullException(nameof(allowedObstacles));
    }

    public double DistanceToDestination { get; }

    public IReadOnlyCollection<BaseObstacle> Obstacles => _obstacles;

    protected IReadOnlyCollection<BaseObstacle> AllowedObstacles => _allowedObstacles;

    public void AddObstacle(BaseObstacle obstacle)
    {
        if (_allowedObstacles.Any(allowedObstacle => allowedObstacle.GetType() == obstacle.GetType()))
        {
            _obstacles.Add(obstacle);
        }
        else
        {
            throw new ArgumentException("Incorrect type obstacle");
        }
    }
}