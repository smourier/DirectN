// c:\program files (x86)\windows kits\10\include\10.0.19041.0\um\amva.h(50,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _tag_AMVACompBufferInfo
    {
        public uint dwNumCompBuffers;
        public uint dwWidthToCreate;
        public uint dwHeightToCreate;
        public uint dwBytesToAllocate;
        public int ddCompCaps;
        public int ddPixelFormat;
    }
}
