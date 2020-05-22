// c:\program files (x86)\windows kits\10\include\10.0.19041.0\shared\dxgitype.h(99,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct DXGI_JPEG_AC_HUFFMAN_TABLE
    {
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 16)] 
        public byte[] CodeCounts;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 162)] 
        public byte[] CodeValues;
    }
}
