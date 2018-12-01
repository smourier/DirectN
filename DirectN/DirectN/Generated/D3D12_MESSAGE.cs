// c:\program files (x86)\windows kits\10\include\10.0.17763.0\um\d3d12sdklayers.h(2732,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct D3D12_MESSAGE
    {
        public D3D12_MESSAGE_CATEGORY Category;
        public D3D12_MESSAGE_SEVERITY Severity;
        public D3D12_MESSAGE_ID ID;
        public IntPtr pDescription;
        public IntPtr DescriptionByteLength;
    }
}
