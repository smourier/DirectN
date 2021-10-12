// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\d3d12.h(13093,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct D3D12_STATE_OBJECT_DESC
    {
        public D3D12_STATE_OBJECT_TYPE Type;
        public uint NumSubobjects;
        public IntPtr pSubobjects;
    }
}
