using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ArticleForCarSalesProject.CarCore;

namespace ArticleForCarSalesProject.Cars;
class Ford : Car
{
    public Ford()
    {
        this.Horn = "Bip Bip!";
        this.OilTankSize = 65.2f;
        this.SeatCount = 4;
        this.Price = 325000;
        this.Name = "Audi";
    }
}