using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClimateControl.ClimateControl
{
    class Climate
    {
        private Temperature _temperature;
        private Brightness _brightness;
        private Humidity _humidity;

        public Temperature GetTemperature() => _temperature;
        public Brightness GetBrightness() => _brightness;
        public Humidity GetHumidity() => _humidity;

        public void SetClimate(ClimateChangeRequest request)
        {
            _temperature = request.GetTemperature();
            _brightness = request.GetBrightness();
            _humidity = request.GetHumidity();
        } 
    }
}
