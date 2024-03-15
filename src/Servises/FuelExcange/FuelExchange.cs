namespace Itmo.ObjectOrientedProgramming.Lab1.Models.Fuels;

public class FuelExchange
{
    private const int ActivePlasmaPrice = 800;
    private const int GravitonMatterPrice = 1000;
    private static FuelExchange? _instance;
    private readonly List<FuelInfo> _fuelInfos = new List<FuelInfo>();
    private FuelExchange()
    {
        _fuelInfos.Add(new FuelInfo(FuelType.ActivePlasma, ActivePlasmaPrice, new MiningGuild()));
        _fuelInfos.Add(new FuelInfo(FuelType.GravitonMatter, GravitonMatterPrice, new MiningGuild()));
    }

    public static FuelExchange Instance
    {
        get
        {
            _instance ??= new FuelExchange();
            return _instance;
        }
    }

    public FuelInfo FindFuelInfo(FuelType type)
    {
        FuelInfo? fuelInfo = _fuelInfos.FirstOrDefault(t => t.FuelType == type);
        if (fuelInfo is null)
            throw new InvalidOperationException($"No FuelInfo found for {type}.");

        return fuelInfo;
    }
}