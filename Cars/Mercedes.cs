using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ArticleForCarSalesProject.CarCore;

namespace ArticleForCarSalesProject.Cars;
class Mercedes : Car
{
    public float SensorDistance;
    public Mercedes()
    {
        this.Horn = "Beep beep!";
        this.OilTankSize = 37.5f;
        this.SeatCount = 5;
        this.Price = 355000;
        this.Name = "Mercedes";
        this.SensorDistance = 45f;
    }
}