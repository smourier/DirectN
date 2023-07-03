// c:\program files (x86)\windows kits\10\include\10.0.22621.0\um\wingdi.h(4458,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct tagAXESLISTW
    {
        public uint axlReserved;
        public uint axlNumAxes;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 16)] 
        public tagAXISINFOW[] axlAxisInfo;
    }
}
