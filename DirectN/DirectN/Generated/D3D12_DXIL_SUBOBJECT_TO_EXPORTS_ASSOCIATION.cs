// generated from <Windows SDK Path>\um\d3d12.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct D3D12_DXIL_SUBOBJECT_TO_EXPORTS_ASSOCIATION
    {
        [MarshalAs(UnmanagedType.LPWStr)] 
        public string SubobjectToAssociate;
        public uint NumExports;
        public IntPtr pExports;
    }
}
