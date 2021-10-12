// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\d3d12umddi.h(11844,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct D3D12DDI_VIDEO_EXTENSION_COMMAND_CAPS_DATA_0063
    {
        public uint NodeIndex;
        public Guid CommandId;
        public IntPtr pInputData;
        public IntPtr InputDataSizeInBytes;
        public IntPtr pOutputData;
        public IntPtr OutputDataSizeInBytes;
    }
}
