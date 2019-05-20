// c:\program files (x86)\windows kits\10\include\10.0.18362.0\shared\d3dkmddi.h(4206,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _DXGKARG_SUBMITCOMMANDVIRTUAL
    {
        public IntPtr hContext;
        public ulong DmaBufferVirtualAddress;
        public uint DmaBufferSize;
        public IntPtr pDmaBufferPrivateData;
        public uint DmaBufferPrivateDataSize;
        public uint DmaBufferUmdPrivateDataSize;
        public uint SubmissionFenceId;
        public uint VidPnSourceId;
        public D3DDDI_FLIPINTERVAL_TYPE FlipInterval;
        public _DXGK_SUBMITCOMMANDFLAGS Flags;
        public uint EngineOrdinal;
        public uint NodeOrdinal;
    }
}
