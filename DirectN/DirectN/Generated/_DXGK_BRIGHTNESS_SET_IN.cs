// c:\program files (x86)\windows kits\10\include\10.0.19041.0\shared\d3dkmdt.h(1888,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public partial struct _DXGK_BRIGHTNESS_SET_IN
    {
        public uint BrightnessMillinits;
        public uint TransitionTimeMs;
        public _DXGK_BRIGHTNESS_SENSOR_DATA SensorReadings;
    }
}
