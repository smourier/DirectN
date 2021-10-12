// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\d3dumddi.h(1156,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _DXVADDI_DECODEBUFFERDESC
    {
        public IntPtr hBuffer;
        public _D3DDDIFORMAT CompressedBufferType;
        public uint BufferIndex;
        public uint DataOffset;
        public uint DataSize;
        public uint FirstMBaddress;
        public uint NumMBsInBuffer;
        public uint Width;
        public uint Height;
        public uint Stride;
        public uint ReservedBits;
        public IntPtr pCipherCounter;
    }
}
