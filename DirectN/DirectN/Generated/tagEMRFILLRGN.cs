// c:\program files (x86)\windows kits\10\include\10.0.18362.0\um\wingdi.h(5762,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct tagEMRFILLRGN
    {
        public tagEMR emr;
        public _RECTL rclBounds;
        public uint cbRgnData;
        public uint ihBrush;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 1)] 
        public byte[] RgnData;
    }
}
