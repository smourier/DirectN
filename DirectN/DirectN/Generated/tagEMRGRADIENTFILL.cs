// generated from <Windows SDK Path>\um\wingdi.h
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
