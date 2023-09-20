// generated from <Windows SDK Path>\um\d3d12umddi.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct D3D12DDI_VIDEO_EXTENSION_COMMAND_PARAMETERS_DATA_0063
    {
        public Guid CommandId;
        public D3D12DDI_VIDEO_EXTENSION_COMMAND_PARAMETER_STAGE_0063 Stage;
        public uint ParameterCount;
        public IntPtr pParameterInfos;
    }
}
