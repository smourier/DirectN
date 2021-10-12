// c:\program files (x86)\windows kits\10\include\10.0.22000.0\shared\d3dkmddi.h(3678,9)
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
