// c:\program files (x86)\windows kits\10\include\10.0.22000.0\shared\d3d9types.h(1582,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential, Pack = 4)]
    public partial struct _D3DGAMMARAMP
    {
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 256)] 
        public ushort[] red;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 256)] 
        public ushort[] green;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 256)] 
        public ushort[] blue;
    }
}
