using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClimateControl.ClimateControl
{
    class Humidity
    {
        private int _humidity;

        public int GetHumidity() => _humidity;
        public void SetHumidity(int humidity) => _humidity = humidity;
    }
}
