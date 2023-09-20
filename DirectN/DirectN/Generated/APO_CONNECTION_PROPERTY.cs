// generated from <Windows SDK Path>\um\audioapotypes.h
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
