// c:\program files (x86)\windows kits\10\include\10.0.18362.0\um\d3d12.h(12092,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct D3D12_EXISTING_COLLECTION_DESC
    {
        public IntPtr pExistingCollection;
        public uint NumExports;
        public IntPtr pExports;
    }
}
