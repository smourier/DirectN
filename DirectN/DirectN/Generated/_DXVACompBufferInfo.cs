// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\dxva9typ.h(215,9)
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
