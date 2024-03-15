using Itmo.ObjectOrientedProgramming.Lab1.Entities;

namespace Itmo.ObjectOrientedProgramming.Lab1.Models.Deflectors;

public class DeflectorTypeSecond : BaseDeflector
{
    private const int Strenght = 330;
    public DeflectorTypeSecond()
        : base(Strenght)
    {
    }
}