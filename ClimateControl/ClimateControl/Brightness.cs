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

        public Brightness(int brightness)
        {
            _brightness = brightness;
        }

        public int GetBrightness() => _brightness;
        public void SetBrightness(int brightness) => _brightness = brightness >= 0 && brightness <= 100 ? brightness : throw new InvalidOperationException();

        public override string ToString() => $"{_brightness}%";
    }
}
