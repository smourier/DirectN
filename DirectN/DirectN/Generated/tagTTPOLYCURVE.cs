// c:\program files (x86)\windows kits\10\include\10.0.19041.0\um\wingdi.h(3491,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct tagTTPOLYCURVE
    {
        public ushort wType;
        public ushort cpfx;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 1)] 
        public tagPOINTFX[] apfx;
    }
}
