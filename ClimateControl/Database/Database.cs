using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;
using ClimateControl.ClientSide;
using ClimateControl.ClimateControl;

namespace ClimateControl.Database
{
    class Database
    {
        public Preset[] GetPresets()
        {
            XElement db = XElement.Load("../../Database/Presets.xml");

            Preset[] presets = (from preset in db.Descendants("Preset")
                select new Preset(id: (int)preset.Element("Id"),
                    name: preset.Element("Name")?.Value,
                    temperature: new Temperature((int)preset.Element("Temperature")), 
                    brightness: new Brightness((int)preset.Element("Brightness")), 
                    humidity: new Humidity((int)preset.Element("Humidity")))).ToArray();

            return presets;
        }
    }
}
