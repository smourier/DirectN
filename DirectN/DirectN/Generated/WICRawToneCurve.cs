// generated from <Windows SDK Path>\um\wincodec.h
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
