// generated from <Windows SDK Path>\shared\d3dkmddi.h
using System;
using System.Runtime.InteropServices;
using DXGKDDI_FEATURE_SAMPLE_ADDVALUE = System.IntPtr;
using DXGKDDI_FEATURE_SAMPLE_SUBTRACTVALUE = System.IntPtr;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _DXGKDDIINT_FEATURE_SAMPLE_5
    {
        public IntPtr AddValue;
        public IntPtr SubtractValue;
    }
}
