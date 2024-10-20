// generated from <Windows SDK Path>\shared\d3dkmthk.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _D3DKMT_OPENSYNCOBJECTFROMSYNCFILE
    {
        public ulong hSyncFile;
        public uint hDevice;
        public uint hSyncObject;
        public ulong FenceValue;
        public IntPtr FenceValueCPUVirtualAddress;
        public ulong FenceValueGPUVirtualAddress;
    }
}
