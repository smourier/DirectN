// generated from <Windows SDK Path>\um\d3d12video.h
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct D3D12_VIDEO_PROCESS_OUTPUT_STREAM_ARGUMENTS
    {
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)] 
        public D3D12_VIDEO_PROCESS_OUTPUT_STREAM[] OutputStream;
        public tagRECT TargetRectangle;
    }
}
