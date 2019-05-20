// c:\program files (x86)\windows kits\10\include\10.0.18362.0\um\strmif.h(20882,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct tagDVD_ATR
    {
        public uint ulCAT;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 768)] 
        public byte[] pbATRI;
    }
}
