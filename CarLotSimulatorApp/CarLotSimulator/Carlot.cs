using System.Collections.Generic;

namespace CarLotSimulator;

public class Carlot
{
    
    public List<Car> Cars { get; set; } = new List<Car>();

    public void AddCar()
    {
        foreach (var Info in Cars)
        {
            Info.Details();
        }
    }

}