// generated from <Windows SDK Path>\shared\ks.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct KSSTREAM_METADATA_INFO
    {
        public uint BufferSize;
        public uint UsedSize;
        public IntPtr Data;
        public IntPtr SystemVa;
        public uint Flags;
        public uint Reserved;
    }
}
