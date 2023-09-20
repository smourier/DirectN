// generated from <Windows SDK Path>\shared\dxgitype.h
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
