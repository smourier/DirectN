// c:\program files (x86)\windows kits\10\include\10.0.18362.0\shared\d3dkmddi.h(3787,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _DXGK_BUILDPAGINGBUFFER_FLUSHTLB
    {
        public _D3DGPU_PHYSICAL_ADDRESS RootPageTableAddress;
        public IntPtr hProcess;
        public ulong StartVirtualAddress;
        public ulong EndVirtualAddress;
    }
}
