// c:\program files (x86)\windows kits\10\include\10.0.18362.0\um\d3d12.h(13247,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct D3D12_DRED_ALLOCATION_NODE
    {
        [MarshalAs(UnmanagedType.LPStr)] 
        public byte ObjectNameA;
        [MarshalAs(UnmanagedType.LPWStr)] 
        public char ObjectNameW;
        public D3D12_DRED_ALLOCATION_TYPE AllocationType;
        public IntPtr pNext;
    }
}
