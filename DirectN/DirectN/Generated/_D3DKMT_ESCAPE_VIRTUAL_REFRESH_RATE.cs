// c:\program files (x86)\windows kits\10\include\10.0.22000.0\shared\d3dkmthk.h(2692,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _D3DKMT_ESCAPE_VIRTUAL_REFRESH_RATE
    {
        public _D3DKMT_ESCAPE_VIRTUAL_REFRESH_RATE_TYPE Type;
        public uint VidPnSourceId;
        public byte ProcessBoostEligible;
        public uint VSyncMultiplier;
        public uint BaseDesktopDuration;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 16)] 
        public byte[] Reserved;
    }
}
