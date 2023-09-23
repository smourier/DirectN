// generated from <Windows SDK Path>\shared\d3dkmthk.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _D3DKMT_UPDATEGPUVIRTUALADDRESS
    {
        public uint hDevice;
        public uint hContext;
        public uint hFenceObject;
        public uint NumOperations;
        public IntPtr Operations;
        public IntPtr Reserved0;
        public ulong Reserved1;
        public ulong FenceValue;
        public _D3DKMT_UPDATEGPUVIRTUALADDRESS__union_0 Flags;
    }
}
