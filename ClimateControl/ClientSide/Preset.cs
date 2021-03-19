using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClimateControl.ClimateControl;

namespace ClimateControl.ClientSide
{
    class Preset
    {
        private int _id;
        private string _name;
        private Temperature _temperature;
        private Brightness _brightness;
        private Humidity _humidity;

        public string GetName() => _name;
        public Temperature GetTemperature() => _temperature;
        public Brightness GetBrightness() => _brightness;
        public Humidity GetHumidity() => _humidity;
    }
}
