// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\d3d12umddi.h(1858,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct D3D12DDI_CONSTANT_BUFFER_VIEW_DESC
    {
        public ulong BufferLocation;
        public uint SizeInBytes;
        public uint Padding;
    }
}
