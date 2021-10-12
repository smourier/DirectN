// c:\program files (x86)\windows kits\10\include\10.0.22000.0\shared\ks.h(2073,9)
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
