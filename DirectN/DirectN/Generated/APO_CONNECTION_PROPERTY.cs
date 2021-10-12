// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\audioapotypes.h(50,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct APO_CONNECTION_PROPERTY
    {
        public IntPtr pBuffer;
        public uint u32ValidFrameCount;
        public APO_BUFFER_FLAGS u32BufferFlags;
        public uint u32Signature;
    }
}
