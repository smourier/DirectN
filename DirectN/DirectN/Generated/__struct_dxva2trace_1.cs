// generated from <Windows SDK Path>\um\dxva2trace.h
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
