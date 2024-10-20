// generated from <Windows SDK Path>\shared\d3dukmdt.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _D3DDDI_DRIVERESCAPE_BUILDTESTCOMMANDBUFFER
    {
        public _D3DDDI_DRIVERESCAPETYPE EscapeType;
        public uint hDevice;
        public uint hContext;
        public _D3DDDI_BUILDTESTCOMMANDBUFFERFLAGS Flags;
        public _D3DDDI_TESTCOMMANDBUFFER Command;
        public IntPtr pDmaBuffer;
        public IntPtr pDmaBufferPrivateData;
        public uint DmaBufferSize;
        public uint DmaBufferPrivateDataSize;
    }
}
