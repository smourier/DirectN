// c:\program files (x86)\windows kits\10\include\10.0.18362.0\um\d3d12umddi.h(10082,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct D3D12DDI_VIDEO_EXTENSION_COMMAND_INFO_0063
    {
        public Guid CommandId;
        [MarshalAs(UnmanagedType.LPWStr)] 
        public string Name;
        public D3D12DDI_COMMAND_QUEUE_FLAGS CommandQueueFlags;
    }
}
