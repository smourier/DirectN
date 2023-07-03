// c:\program files (x86)\windows kits\10\include\10.0.22621.0\shared\d3dkmthk.h(816,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _D3DKMT_CREATE_DOORBELL
    {
        public uint hHwQueue;
        public uint hRingBuffer;
        public uint hRingBufferControl;
        public _D3DKMT_CREATE_DOORBELL_FLAGS Flags;
        public uint PrivateDriverDataSize;
        public IntPtr PrivateDriverData;
        public IntPtr DoorbellCPUVirtualAddress;
        public IntPtr DoorbellSecondaryCPUVirtualAddress;
        public IntPtr DoorbellStatusCPUVirtualAddress;
    }
}
