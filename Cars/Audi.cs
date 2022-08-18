using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ArticleForCarSalesProject.CarCore;

namespace ArticleForCarSalesProject.Cars;
class Audi: Car
{
    public float CarTrunkSize;
    public Audi()
    {
        this.Horn = "Beeeeeep!";
        this.OilTankSize = 56.7f;
        this.SeatCount = 5;
        this.Price = 340000;
        this.Name = "Audi";
        this.CarTrunkSize = 40.7f;
    }
}