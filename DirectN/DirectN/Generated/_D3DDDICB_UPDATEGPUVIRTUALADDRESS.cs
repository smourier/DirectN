// generated from <Windows SDK Path>\um\d3dumddi.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _D3DDDICB_UPDATEGPUVIRTUALADDRESS
    {
        public IntPtr hContext;
        public uint hFenceObject;
        public uint NumOperations;
        public IntPtr Operations;
        public uint Reserved0;
        public ulong Reserved1;
        public ulong FenceValue;
        public _D3DDDICB_UPDATEGPUVIRTUALADDRESS__union_0 Flags;
    }
}
