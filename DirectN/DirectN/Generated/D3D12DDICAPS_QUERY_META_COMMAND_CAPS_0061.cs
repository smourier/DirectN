// c:\program files (x86)\windows kits\10\include\10.0.18362.0\um\d3d12umddi.h(10255,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct D3D12DDICAPS_QUERY_META_COMMAND_CAPS_0061
    {
        public Guid CommandId;
        public IntPtr pQueryInputData;
        public IntPtr QueryInputDataSizeInBytes;
        public IntPtr pQueryOutputData;
        public IntPtr QueryOutputDataSizeInBytes;
    }
}
