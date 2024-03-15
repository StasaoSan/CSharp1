namespace Itmo.ObjectOrientedProgramming.Lab1.Models.Fuels;

public class FuelInfo
{
    public FuelInfo(FuelType fuelType, int price, Money moneyType)
    {
        FuelType = fuelType;
        Price = price;
        MoneyType = moneyType;
    }

    public FuelType FuelType { get; }
    public int Price { get; protected set; }
    public Money MoneyType { get; }
}
