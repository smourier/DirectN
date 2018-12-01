// c:\program files (x86)\windows kits\10\include\10.0.17763.0\um\d3d12video.h(1228,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct D3D12_VIDEO_PROCESS_INPUT_STREAM
    {
        public IntPtr pTexture2D;
        public uint Subresource;
        public D3D12_VIDEO_PROCESS_REFERENCE_SET ReferenceSet;
    }
}
