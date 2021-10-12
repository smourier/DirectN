// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\d3d12umddi.h(11826,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct D3D12DDI_VIDEO_EXTENSION_COMMAND_PARAMETER_COUNT_DATA_0063
    {
        public Guid CommandId;
        public D3D12DDI_VIDEO_EXTENSION_COMMAND_PARAMETER_STAGE_0063 Stage;
        public uint ParameterCount;
        public uint ParameterPacking;
    }
}
