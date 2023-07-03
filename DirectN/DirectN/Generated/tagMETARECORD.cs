// c:\program files (x86)\windows kits\10\include\10.0.22621.0\um\wingdi.h(1018,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct tagMETARECORD
    {
        public uint rdSize;
        public ushort rdFunction;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 1)] 
        public ushort[] rdParm;
    }
}
