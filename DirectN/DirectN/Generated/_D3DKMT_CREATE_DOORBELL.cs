// generated from <Windows SDK Path>\shared\d3dkmthk.h
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
