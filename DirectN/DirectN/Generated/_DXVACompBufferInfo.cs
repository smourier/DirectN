// generated from <Windows SDK Path>\um\dxva9typ.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _DXVACompBufferInfo
    {
        public uint NumCompBuffers;
        public uint WidthToCreate;
        public uint HeightToCreate;
        public uint BytesToAllocate;
        public uint Usage;
        public int Pool;
        public int Format;
    }
}
