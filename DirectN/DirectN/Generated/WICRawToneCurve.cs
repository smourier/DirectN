// c:\program files (x86)\windows kits\10\include\10.0.19041.0\um\wincodec.h(7157,24)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct WICRawToneCurve
    {
        public uint cPoints;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 1)] 
        public WICRawToneCurvePoint[] aPoints;
    }
}
