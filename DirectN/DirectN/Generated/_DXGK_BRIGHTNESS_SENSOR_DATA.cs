// generated from <Windows SDK Path>\shared\d3dkmdt.h
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
