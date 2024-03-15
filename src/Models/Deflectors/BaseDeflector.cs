namespace Itmo.ObjectOrientedProgramming.Lab1.Entities;

public abstract class BaseDeflector
{
    private double _strength;
    private double _maxHP;
    private PhotonDeflector? _photonDeflector;
    protected BaseDeflector(int strength)
    {
        _strength = strength;
        _maxHP = strength;
    }

    public PhotonDeflector? PhotonDeflector
    {
        get => _photonDeflector;
        set => _photonDeflector = value;
    }

    public bool Active => _strength > 0;

    public virtual bool AbsorbDamage(double damagePoints)
    {
        if (damagePoints > _strength)
            return false;

        _strength -= damagePoints;
        return true;
    }

    public void AddPhotonDeflector()
    {
        if (!(this is PhotonDeflector))
            _photonDeflector = new PhotonDeflector();
    }
}
