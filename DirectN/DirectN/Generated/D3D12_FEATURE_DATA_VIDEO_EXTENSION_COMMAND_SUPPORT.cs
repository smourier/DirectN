// c:\program files (x86)\windows kits\10\include\10.0.19041.0\um\d3d12video.h(3501,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct D3D12_FEATURE_DATA_VIDEO_EXTENSION_COMMAND_SUPPORT
    {
        public uint NodeIndex;
        public Guid CommandId;
        public IntPtr pInputData;
        public IntPtr InputDataSizeInBytes;
        public IntPtr pOutputData;
        public IntPtr OutputDataSizeInBytes;
    }
}
