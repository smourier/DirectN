// c:\program files (x86)\windows kits\10\include\10.0.19041.0\um\d3d12.h(12219,9)
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
