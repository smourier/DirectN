// generated from <Windows SDK Path>\um\wingdi.h
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
