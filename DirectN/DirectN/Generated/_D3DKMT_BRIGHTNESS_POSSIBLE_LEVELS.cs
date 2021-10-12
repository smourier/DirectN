// c:\program files (x86)\windows kits\10\include\10.0.22000.0\shared\d3dkmthk.h(2898,9)
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
