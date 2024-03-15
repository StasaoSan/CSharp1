namespace Itmo.ObjectOrientedProgramming.Lab1.Entities;

public abstract class BaseFrame
{
    private double _strenght;
    protected BaseFrame(double strenght)
    {
        _strenght = strenght;
        MaxStrenght = strenght;
    }

    protected double MaxStrenght { get; set; }

    public virtual bool AbsorbDamage(double damagePoints)
    {
        if (damagePoints > _strenght)
            return false;

        _strenght -= damagePoints;
        return true;
    }
}