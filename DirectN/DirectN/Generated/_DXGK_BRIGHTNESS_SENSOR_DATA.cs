// c:\program files (x86)\windows kits\10\include\10.0.18362.0\shared\d3dkmdt.h(1865,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public partial struct _DXGK_BRIGHTNESS_SENSOR_DATA
    {
        public uint Size;
        public _DXGK_BRIGHTNESS_SENSOR_DATA__union_0 __union_1;
        public float AlsReading;
        public _DXGK_BRIGHTNESS_SENSOR_DATA_CHROMATICITY Chromaticity;
        public float ColorTemperature;
    }
}
