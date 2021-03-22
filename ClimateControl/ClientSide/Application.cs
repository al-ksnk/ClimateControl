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
        private readonly Database.Database _database = new Database.Database();

        // was not in lab 3
        private readonly Climate _climate = new Climate();

        public void SelectPreset(string presetName)
        {
            Preset preset = _database.GetPresets().First(p => p.GetName() == presetName);
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
