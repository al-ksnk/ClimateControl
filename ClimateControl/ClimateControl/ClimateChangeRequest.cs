using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClimateControl.ClimateControl
{
    class ClimateChangeRequest
    {
        private readonly Temperature _temperature;
        private readonly Brightness _brightness;
        private readonly Humidity _humidity;

        public ClimateChangeRequest(Temperature temperature = null, Brightness brightness = null, Humidity humidity = null)
        {
            _temperature = temperature;
            _brightness = brightness;
            _humidity = humidity;
        }

        public Temperature GetTemperature() => _temperature;
        public Brightness GetBrightness() => _brightness;
        public Humidity GetHumidity() => _humidity;
    }
}
