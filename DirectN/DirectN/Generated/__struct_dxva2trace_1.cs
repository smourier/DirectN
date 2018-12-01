// c:\program files (x86)\windows kits\10\include\10.0.17763.0\um\dxva2trace.h(38,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct __struct_dxva2trace_1
    {
        public int wmiHeader;
        public ulong pObject;
        public ulong pD3DDevice;
        public Guid DeviceGuid;
        public uint Width;
        public uint Height;
        public bool Enter;
    }
}
