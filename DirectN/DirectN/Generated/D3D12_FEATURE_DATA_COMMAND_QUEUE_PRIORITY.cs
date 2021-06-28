// c:\program files (x86)\windows kits\10\include\10.0.19041.0\um\d3d12.h(2286,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct D3D12_FEATURE_DATA_COMMAND_QUEUE_PRIORITY
    {
        public D3D12_COMMAND_LIST_TYPE CommandListType;
        public uint Priority;
        public bool PriorityForTypeIsSupported;
    }
}
