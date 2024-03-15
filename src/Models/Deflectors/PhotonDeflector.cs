namespace Itmo.ObjectOrientedProgramming.Lab1.Entities;

public class PhotonDeflector : BaseDeflector
{
    private const int Strenght = 0;

    public PhotonDeflector()
        : base(Strenght)
    {
    }

    public int MaxUsageCount { get; } = 3;
    public int UsageCount { get; private set; }

    public void UsagePhotonDeflector()
    {
        UsageCount++;
    }
}