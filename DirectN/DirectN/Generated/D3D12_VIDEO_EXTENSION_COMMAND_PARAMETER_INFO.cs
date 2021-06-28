// c:\program files (x86)\windows kits\10\include\10.0.19041.0\um\d3d12video.h(3486,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct D3D12_VIDEO_EXTENSION_COMMAND_PARAMETER_INFO
    {
        [MarshalAs(UnmanagedType.LPWStr)] 
        public string Name;
        public D3D12_VIDEO_EXTENSION_COMMAND_PARAMETER_TYPE Type;
        public D3D12_VIDEO_EXTENSION_COMMAND_PARAMETER_FLAGS Flags;
    }
}
