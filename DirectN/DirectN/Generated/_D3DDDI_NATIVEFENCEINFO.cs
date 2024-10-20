// generated from <Windows SDK Path>\shared\d3dukmdt.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _D3DDDI_NATIVEFENCEINFO
    {
        public ulong InitialFenceValue;
        public uint EngineAffinity;
        public _D3DDDI_NATIVEFENCE_TYPE Type;
        public _D3DDDI_SYNCHRONIZATIONOBJECT_FLAGS Flags;
        public _D3DDDI_NATIVEFENCEMAPPING NativeFenceMapping;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 28)] 
        public byte[] Reserved;
    }
}
