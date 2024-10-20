// generated from <Windows SDK Path>\shared\d3dkmddi.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _DXGKARG_BUILDTESTCOMMANDBUFFER
    {
        public IntPtr hContext;
        public _D3DDDI_TESTCOMMANDBUFFER Command;
        public IntPtr pDmaBuffer;
        public IntPtr pDmaBufferPrivateData;
        public uint DmaBufferSize;
        public uint DmaBufferPrivateDataSize;
        public _D3DDDI_BUILDTESTCOMMANDBUFFERFLAGS Flags;
    }
}
