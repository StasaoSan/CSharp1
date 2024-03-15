using Itmo.ObjectOrientedProgramming.Lab1.Models.Engines;
using Itmo.ObjectOrientedProgramming.Lab1.Servises.Enviroments;
using Itmo.ObjectOrientedProgramming.Lab1.Servises.Obstacle;

namespace Itmo.ObjectOrientedProgramming.Lab1.Entities;

public abstract class BaseShip
{
    public enum ShipSize
    {
        Small,
        Medium,
        Big,
    }

    public BaseDeflector? Deflector { get; protected set; }
    public BaseFrame? Frame { get; init; }
    public bool CrewAlive { get; private set; } = true;
    public bool ShipAlive { get; private set; } = true;
    public bool ShipVisible { get; private set; } = true;
    public abstract ShipSize Size { get; }

    public double Time
    {
        get
        {
            double t = 0;
            if (FirstEngine != null)
                t += FirstEngine.Time;
            if (SecondEngine != null)
                t += SecondEngine.Time;
            return t;
        }
    }

    public double Money
    {
        get
        {
            double t = 0;
            if (FirstEngine != null)
                t += FirstEngine.PriseFuel();
            if (SecondEngine != null)
                t += SecondEngine.PriseFuel();
            return t;
        }
    }

    public bool AntiNeutrinoEmitter { get; protected init; }
    protected ImpulseEngine? FirstEngine { get; init; }
    protected JumpEngine? SecondEngine { get; init; }

    public virtual bool StartShipFly(IEnumerable<BaseEnviroment> enviroments)
    {
        var enviromentsList = enviroments.ToList();

        foreach (BaseEnviroment environment in enviromentsList)
        {
            if (FirstEngine == null)
                throw new AggregateException("Engine cannot be null.");

            switch (environment)
            {
                case RegularSpace _:
                case NeurtinoSpace _:
                    FirstEngine.Run(environment);
                    break;

                case HightDensitySpase _:
                    if (SecondEngine == null || !SecondEngine.Jump(environment.DistanceToDestination))
                    {
                        ShipVisible = false;
                        return false;
                    }

                    SecondEngine.Run(environment);
                    break;

                default:
                    throw new InvalidOperationException($"Unknown environment type: {environment}");
            }

            foreach (BaseObstacle obstacle in environment.Obstacles)
            {
                obstacle.InflictDamage(this);
            }
        }

        return ShipVisible && CrewAlive && ShipAlive;
    }

    public void KillCrew()
    {
        CrewAlive = false;
    }

    public void KillShip()
    {
        ShipAlive = false;
        CrewAlive = false;
    }
}
