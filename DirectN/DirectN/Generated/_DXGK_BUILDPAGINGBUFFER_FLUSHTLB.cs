// generated from <Windows SDK Path>\shared\d3dkmddi.h
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
