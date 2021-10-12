// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\d3d12.h(15727,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct D3D12_FEATURE_DATA_PROTECTED_RESOURCE_SESSION_TYPES
    {
        public uint NodeIndex;
        public uint Count;
        public IntPtr pTypes;
    }
}
