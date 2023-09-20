// generated from <Windows SDK Path>\um\d3d12video.h
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
