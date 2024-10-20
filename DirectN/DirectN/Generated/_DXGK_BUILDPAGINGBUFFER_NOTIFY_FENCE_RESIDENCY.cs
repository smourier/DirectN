// generated from <Windows SDK Path>\shared\d3dkmddi.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _DXGK_BUILDPAGINGBUFFER_NOTIFY_FENCE_RESIDENCY
    {
        public uint NumFences;
        public _DXGK_BUILDPAGINGBUFFER_NOTIFY_FENCE_RESIDENCY__union_0 Flags;
        public IntPtr FenceResidencyInfo;
    }
}
