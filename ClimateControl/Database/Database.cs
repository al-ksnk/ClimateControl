using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClimateControl.ClientSide;
using ClimateControl.ClimateControl;

namespace ClimateControl.Database
{
    class Database
    {
        public Preset[] GetPresets() => new Preset[]
        {
            new Preset("Ocean Avenue", new Temperature(30), new Brightness(70), new Humidity(70)),
            new Preset("Forest Adventure", new Temperature(20), new Brightness(45), new Humidity(75)),
            new Preset("Swedish Winter", new Temperature(20), new Brightness(30), new Humidity(60)),
            new Preset("Australian Paradise", new Temperature(32), new Brightness(85), new Humidity(55)),
            new Preset("Night Relaxation", new Temperature(24), new Brightness(0), new Humidity(50)),
        };
    }
}
