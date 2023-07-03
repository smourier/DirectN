// c:\program files (x86)\windows kits\10\include\10.0.22621.0\shared\d3dukmdt.h(1887,9)
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
