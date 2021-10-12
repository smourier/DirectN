// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\d3d12umddi.h(4789,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct D3D12DDICB_DEALLOCATE_0022
    {
        public IntPtr hResource;
        public uint NumAllocations;
        public IntPtr HandleList;
        public D3D12DDI_DEALLOCATE_FLAGS_0022 Flags;
    }
}
