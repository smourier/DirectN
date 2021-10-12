// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\ksopmapi.h(104,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _OPM_STANDARD_INFORMATION
    {
        public _OPM_RANDOM_NUMBER rnRandomNumber;
        public uint ulStatusFlags;
        public uint ulInformation;
        public uint ulReserved;
        public uint ulReserved2;
    }
}
