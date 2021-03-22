using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClimateControl.ClimateControl
{
    class Temperature
    {
        private int _temperature;

        public Temperature(int temperature)
        {
            _temperature = temperature;
        }

        public int GetTemperature() => _temperature;
        public int SetTemperature(int temperature) => _temperature = temperature;

        public override string ToString() => $"{_temperature}*C";
    }
}
