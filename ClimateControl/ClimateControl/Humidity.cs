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

        public Humidity(int humidity)
        {
            _humidity = humidity;
        }

        public int GetHumidity() => _humidity;
        public void SetHumidity(int humidity) => humidity  = humidity >= 0 && humidity <= 100 ? humidity : throw new InvalidOperationException();

        public override string ToString() => $"{_humidity}%";
    }
}
