// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\d3d12umddi.h(350,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct D3D12DDI_HANDLE_AND_TYPE
    {
        public IntPtr Handle;
        public D3D12DDI_HANDLETYPE Type;
    }
}
