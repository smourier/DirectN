// c:\program files (x86)\windows kits\10\include\10.0.19041.0\shared\d3dkmthk.h(3942,9)
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
        public uint Reserved0;
        public ulong Reserved1;
        public ulong FenceValue;
        public _D3DKMT_UPDATEGPUVIRTUALADDRESS__union_0 Flags;
    }
}
