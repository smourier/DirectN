// generated from <Windows SDK Path>\shared\d3dkmthk.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _D3DKMT_BRIGHTNESS_POSSIBLE_LEVELS
    {
        public byte LevelCount;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 256)] 
        public byte[] BrightnessLevels;
    }
}
