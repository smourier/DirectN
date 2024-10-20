// generated from <Windows SDK Path>\um\dxva.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public partial struct _DXVA_HuffmanTable_MJPEG
    {
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 64)] 
        public byte[] bits_ac;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 1024)] 
        public byte[] table_ac;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 64)] 
        public byte[] bits_dc;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 1024)] 
        public byte[] table_dc;
    }
}
