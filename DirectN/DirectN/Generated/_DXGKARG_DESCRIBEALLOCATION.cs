// generated from <Windows SDK Path>\shared\d3dkmddi.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _DXGKARG_DESCRIBEALLOCATION
    {
        public IntPtr hAllocation;
        public uint Width;
        public uint Height;
        public _D3DDDIFORMAT Format;
        public _D3DDDI_MULTISAMPLINGMETHOD MultisampleMethod;
        public _D3DDDI_RATIONAL RefreshRate;
        public uint PrivateDriverFormatAttribute;
        public _DXGK_DESCRIBEALLOCATIONFLAGS Flags;
        public _D3DDDI_ROTATION Rotation;
    }
}
