// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\d3d12umddi.h(11063,9)
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct D3D12DDIARG_VIDEO_PROCESS_OUTPUT_STREAM_ARGUMENTS_0032
    {
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)] 
        public D3D12DDI_VIDEO_PROCESS_OUTPUT_STREAM_0020[] OutputStream;
        public tagRECT TargetRectangle;
    }
}
