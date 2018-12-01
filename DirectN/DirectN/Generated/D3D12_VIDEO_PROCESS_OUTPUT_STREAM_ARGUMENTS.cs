// c:\program files (x86)\windows kits\10\include\10.0.17763.0\um\d3d12video.h(1251,9)
using System.Runtime.InteropServices;
using D3D12_RECT = DirectN.tagRECT;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct D3D12_VIDEO_PROCESS_OUTPUT_STREAM_ARGUMENTS
    {
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)] 
        public D3D12_VIDEO_PROCESS_OUTPUT_STREAM[] OutputStream;
        public D3D12_RECT TargetRectangle;
    }
}
