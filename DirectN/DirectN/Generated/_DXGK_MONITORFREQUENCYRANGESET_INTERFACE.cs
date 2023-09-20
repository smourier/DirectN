// generated from <Windows SDK Path>\shared\d3dkmddi.h
using System;
using System.Runtime.InteropServices;
using DXGKDDI_MONITORFREQUENCYRANGESET_ACQUIREFIRSTFREQUENCYRANGEINFO = System.IntPtr;
using DXGKDDI_MONITORFREQUENCYRANGESET_ACQUIRENEXTFREQUENCYRANGEINFO = System.IntPtr;
using DXGKDDI_MONITORFREQUENCYRANGESET_GETNUMFREQUENCYRANGES = System.IntPtr;
using DXGKDDI_MONITORFREQUENCYRANGESET_RELEASEFREQUENCYRANGEINFO = System.IntPtr;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _DXGK_MONITORFREQUENCYRANGESET_INTERFACE
    {
        public IntPtr pfnGetNumFrequencyRanges;
        public IntPtr pfnAcquireFirstFrequencyRangeInfo;
        public IntPtr pfnAcquireNextFrequencyRangeInfo;
        public IntPtr pfnReleaseFrequencyRangeInfo;
    }
}
