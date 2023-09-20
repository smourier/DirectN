// generated from <Windows SDK Path>\um\d3d12.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct D3D12_SUBOBJECT_TO_EXPORTS_ASSOCIATION
    {
        public IntPtr pSubobjectToAssociate;
        public uint NumExports;
        public IntPtr pExports;
    }
}
