// c:\program files (x86)\windows kits\10\include\10.0.19041.0\um\audioenginebaseapo.h(170,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct APO_CONNECTION_DESCRIPTOR
    {
        public APO_CONNECTION_BUFFER_TYPE Type;
        public IntPtr pBuffer;
        public uint u32MaxFrameCount;
        public IntPtr pFormat;
        public uint u32Signature;
    }
}
