// generated from <Windows SDK Path>\shared\d3dukmdt.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _D3DDDI_CREATENATIVEFENCEINFO
    {
        public ulong InitialFenceValue;
        public IntPtr pPrivateDriverData;
        public uint PrivateDriverDataSize;
        public uint EngineAffinity;
        public _D3DDDI_SYNCHRONIZATIONOBJECT_FLAGS Flags;
        public uint hSyncObject;
        public _D3DDDI_NATIVEFENCEMAPPING NativeFenceMapping;
    }
}
