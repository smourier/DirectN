// generated from <Windows SDK Path>\shared\d3dkmdt.h
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
