// c:\program files (x86)\windows kits\10\include\10.0.17763.0\um\shtypes.h(119,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _SHITEMID
    {
        public ushort cb;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 1)] 
        public byte abID;
    }
}
