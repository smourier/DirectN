// c:\program files (x86)\windows kits\10\include\10.0.22000.0\shared\d3dkmdt.h(1263,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _D3DKMDT_MONITOR_DESCRIPTOR
    {
        public uint Id;
        public _D3DKMDT_MONITOR_DESCRIPTOR_TYPE Type;
        public IntPtr DataSize;
        public IntPtr pData;
        public _D3DKMDT_MONITOR_CAPABILITIES_ORIGIN Origin;
    }
}
