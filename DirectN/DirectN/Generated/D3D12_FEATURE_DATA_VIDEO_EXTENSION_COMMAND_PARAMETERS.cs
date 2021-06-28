// c:\program files (x86)\windows kits\10\include\10.0.19041.0\um\d3d12video.h(3493,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct D3D12_FEATURE_DATA_VIDEO_EXTENSION_COMMAND_PARAMETERS
    {
        public Guid CommandId;
        public D3D12_VIDEO_EXTENSION_COMMAND_PARAMETER_STAGE Stage;
        public uint ParameterCount;
        public IntPtr pParameterInfos;
    }
}
