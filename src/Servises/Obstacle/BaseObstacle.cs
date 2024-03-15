using Itmo.ObjectOrientedProgramming.Lab1.Entities;

namespace Itmo.ObjectOrientedProgramming.Lab1.Servises.Obstacle;

public abstract class BaseObstacle
{
    protected BaseObstacle(double damagePoints, string name)
    {
        DamagePoints = damagePoints;
        Name = name;
    }

    public string Name { get; }
    public double DamagePoints { get; }

    public override bool Equals(object? obj)
    {
        if (obj is BaseObstacle otherObstacle)
        {
            return Name.Equals(otherObstacle.Name, StringComparison.Ordinal);
        }

        return false;
    }

    public override int GetHashCode()
    {
        return Name.GetHashCode(StringComparison.Ordinal);
    }

    public abstract void InflictDamage(BaseShip ship);
}
