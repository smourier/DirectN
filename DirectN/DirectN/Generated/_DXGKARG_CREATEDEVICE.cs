// c:\program files (x86)\windows kits\10\include\10.0.18362.0\shared\d3dkmddi.h(1216,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _DXGKARG_CREATEDEVICE
    {
        public IntPtr hDevice;
        public _DXGKARG_CREATEDEVICE__union_0 __union_1;
        public uint Pasid;
        public IntPtr hKmdProcess;
    }
}
