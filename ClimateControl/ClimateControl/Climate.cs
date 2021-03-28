using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClimateControl.ClimateControl
{
    class Climate
    {
        private Temperature _temperature = new Temperature(25);
        private Brightness _brightness = new Brightness(50);
        private Humidity _humidity = new Humidity(30);

        public Temperature GetTemperature() => _temperature;
        public Brightness GetBrightness() => _brightness;
        public Humidity GetHumidity() => _humidity;

        public void SetClimate(ClimateChangeRequest request)
        {
            if (request.GetTemperature() != null)
            {
                _temperature.SetTemperature(request.GetTemperature().GetTemperature());
            }

            if (request.GetBrightness() != null)
            {
                _brightness.SetBrightness(request.GetBrightness().GetBrightness());
            }

            if (request.GetHumidity() != null)
            {
                _humidity.SetHumidity(request.GetHumidity().GetHumidity());
            }
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("Current climate:\n");
            sb.Append($"---> Temperature: {_temperature}\n");
            sb.Append($"---> Brightness: {_brightness}\n");
            sb.Append($"---> Humidity: {_humidity}");
            return sb.ToString();
        }
    }
}
