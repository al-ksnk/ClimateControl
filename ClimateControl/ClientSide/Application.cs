using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClimateControl.ClimateControl;

namespace ClimateControl.ClientSide
{
    class Application
    {
        private Database.Database _database;
        private Climate _climate = new Climate();

        public void SelectPreset(Preset preset)
        {
            ClimateChangeRequest request = new ClimateChangeRequest(preset.GetTemperature(), preset.GetBrightness(), preset.GetHumidity());
            _climate.SetClimate(request);
        }

        public Climate NotifyOfClimate() => _climate;

        public void ChangeTemperature(Temperature temperature)
        {
            ClimateChangeRequest request = new ClimateChangeRequest(temperature: temperature);
            _climate.SetClimate(request);
        }

        public void ChangeBrightness(Brightness brightness)
        {
            ClimateChangeRequest request = new ClimateChangeRequest(brightness: brightness);
            _climate.SetClimate(request);
        }

        public void ChangeHumidity(Humidity humidity)
        {
            ClimateChangeRequest request = new ClimateChangeRequest(humidity: humidity);
            _climate.SetClimate(request);
        }
    }
}
