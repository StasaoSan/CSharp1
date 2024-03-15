using Itmo.ObjectOrientedProgramming.Lab1.Entities;

namespace Itmo.ObjectOrientedProgramming.Lab1.Models.Deflectors;

public class DeflectorTypeFirst : BaseDeflector
{
    private const int Strenght = 66;
    public DeflectorTypeFirst()
        : base(Strenght)
    {
    }
}