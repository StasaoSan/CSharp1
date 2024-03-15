using Itmo.ObjectOrientedProgramming.Lab1.Entities;
using Itmo.ObjectOrientedProgramming.Lab1.Servises.Enviroments;

namespace Lab1.Servises.Rote;

public class BaseRote
{
    private List<BaseEnviroment> enviroments = new List<BaseEnviroment>();

    public void AddEnviroment(BaseEnviroment enviroment)
    {
        enviroments.Add(enviroment);
    }

    public BaseShip? ChooseOptimalShip(IEnumerable<BaseShip> ships)
    {
        var shipsList = ships.ToList();
        if (!shipsList.Any()) throw new ArgumentException("Ships cannot be empty.");

        var successfulShips = new List<BaseShip>();

        foreach (BaseShip ship in shipsList)
        {
            bool success = ship.StartShipFly(enviroments);
            if (success)
            {
                successfulShips.Add(ship);
            }
        }

        if (!successfulShips.Any())
        {
            return null;
        }

        return successfulShips.OrderBy(s => s.Money)
            .ThenBy(s => s.Time)
            .FirstOrDefault();
    }
}