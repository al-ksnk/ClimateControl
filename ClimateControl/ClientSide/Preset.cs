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
        private readonly string _name;
        private readonly Temperature _temperature;
        private readonly Brightness _brightness;
        private readonly Humidity _humidity;

        public Preset(string name, Temperature temperature, Brightness brightness, Humidity humidity)
        {
            _id = name?.GetHashCode() ?? throw new ArgumentNullException();
            _name = name;
            _temperature = temperature;
            _brightness = brightness;
            _humidity = humidity;
        }

        public string GetName() => _name;
        public Temperature GetTemperature() => _temperature;
        public Brightness GetBrightness() => _brightness;
        public Humidity GetHumidity() => _humidity;

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("Current climate:\n");
            sb.Append($"---> Name: {_name}\n");
            sb.Append($"---> Temperature: {_temperature}\n");
            sb.Append($"---> Brightness: {_brightness}\n");
            sb.Append($"---> Humidity: {_humidity}\n");
            return sb.ToString();
        }
    }
}
