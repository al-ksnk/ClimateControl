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
            _temperature = request.GetTemperature() ?? _temperature;
            _brightness = request.GetBrightness() ?? _brightness;
            _humidity = request.GetHumidity() ?? _humidity;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("Current climate:\n");
            sb.Append($"---> Temperature: {_temperature}\n");
            sb.Append($"---> Brightness: {_brightness}\n");
            sb.Append($"---> Humidity: {_humidity}\n");
            return sb.ToString();
        }
    }
}
