// c:\program files (x86)\windows kits\10\include\10.0.18362.0\um\d3d12umddi.h(7168,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct D3D12DDIARG_META_COMMAND_PARAMETER_DESC
    {
        [MarshalAs(UnmanagedType.LPWStr)] 
        public string Name;
        public D3D12DDI_META_COMMAND_PARAMETER_TYPE Type;
        public D3D12DDI_META_COMMAND_PARAMETER_FLAGS Flags;
        public D3D12DDI_RESOURCE_STATES RequiredResourceState;
    }
}
