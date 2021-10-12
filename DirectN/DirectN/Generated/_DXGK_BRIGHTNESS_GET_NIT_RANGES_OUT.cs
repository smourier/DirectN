// c:\program files (x86)\windows kits\10\include\10.0.22000.0\shared\d3dkmdt.h(1916,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public partial struct _DXGK_BRIGHTNESS_GET_NIT_RANGES_OUT
    {
        public uint NormalRangeCount;
        public uint RangeCount;
        public uint PreferredMaximumBrightness;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 16)] 
        public _DXGK_BRIGHTNESS_NIT_RANGE[] SupportedRanges;
    }
}
