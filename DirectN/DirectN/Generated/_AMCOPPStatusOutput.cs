// c:\program files (x86)\windows kits\10\include\10.0.19041.0\um\strmif.h(17435,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _AMCOPPStatusOutput
    {
        public Guid macKDI;
        public uint cbSizeData;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4076)] 
        public byte[] COPPStatus;
    }
}
