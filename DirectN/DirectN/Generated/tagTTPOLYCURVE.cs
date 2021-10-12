// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\wingdi.h(3536,9)
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
