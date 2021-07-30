using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_params
{
    class Phone
    {
        public float screenSize;
        public string model;
        public int battery;
        public string cameraQuality;

        public Phone(float screenSize = 16.9F, string model = "NotNokia", int battery = 50, string cameraQuality = "720p")
        {
            this.screenSize = screenSize;
            this.model = model;
            this.battery = battery;
            this.cameraQuality = cameraQuality;
        }
    }
}
