using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClimateControl.ClimateControl
{
    class Brightness
    {
        private int _brightness;

        public int GetBrightness() => _brightness;
        public void SetBrightness(int brightness) => _brightness = brightness;
    }
}
