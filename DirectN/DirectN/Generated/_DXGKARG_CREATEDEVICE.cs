// generated from <Windows SDK Path>\shared\d3dkmddi.h
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
