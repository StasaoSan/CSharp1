using Itmo.ObjectOrientedProgramming.Lab1.Entities;

namespace Itmo.ObjectOrientedProgramming.Lab1.Models.Deflectors;

public class DeflectorTypeThird : BaseDeflector
{
    private const int Strenght = 1320;
    public DeflectorTypeThird()
        : base(Strenght)
    {
    }
}