using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarTrackData
{
    public class Car
    {
        string Brand;
        string Model;
        int YearMade;
        long Mileage;
        decimal Engine;

        public Car(string Brand, string Model, int YearMade, long Mileage, decimal Engine) {
            this.Brand = Brand;
            this.Model = Model;
            this.YearMade = YearMade;
            this.Mileage = Mileage;
            this.Engine = Engine;
        }
    }
}
