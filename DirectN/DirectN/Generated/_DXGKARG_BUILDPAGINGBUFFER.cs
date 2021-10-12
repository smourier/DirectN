// c:\program files (x86)\windows kits\10\include\10.0.22000.0\shared\d3dkmddi.h(4325,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _DXGKARG_BUILDPAGINGBUFFER
    {
        public IntPtr pDmaBuffer;
        public uint DmaSize;
        public IntPtr pDmaBufferPrivateData;
        public uint DmaBufferPrivateDataSize;
        public _DXGK_BUILDPAGINGBUFFER_OPERATION Operation;
        public uint MultipassOffset;
        public _DXGKARG_BUILDPAGINGBUFFER__union_0 __union_6;
        public IntPtr hSystemContext;
        public ulong DmaBufferGpuVirtualAddress;
        public uint DmaBufferWriteOffset;
    }
}
