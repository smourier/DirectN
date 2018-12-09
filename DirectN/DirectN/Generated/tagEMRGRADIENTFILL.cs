// c:\program files (x86)\windows kits\10\include\10.0.17763.0\um\wingdi.h(6156,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct tagEMRGRADIENTFILL
    {
        public tagEMR emr;
        public _RECTL rclBounds;
        public uint nVer;
        public uint nTri;
        public uint ulMode;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 1)] 
        public _TRIVERTEX[] Ver;
    }
}
