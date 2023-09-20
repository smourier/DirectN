// generated from <Windows SDK Path>\shared\d3dkmddi.h
using System;
using System.Runtime.InteropServices;
using DXGKDDI_MONITORDESCRIPTORSET_ACQUIREFIRSTDESCRIPTORINFO = System.IntPtr;
using DXGKDDI_MONITORDESCRIPTORSET_ACQUIRENEXTDESCRIPTORINFO = System.IntPtr;
using DXGKDDI_MONITORDESCRIPTORSET_GETNUMDESCRIPTORS = System.IntPtr;
using DXGKDDI_MONITORDESCRIPTORSET_RELEASEDESCRIPTORINFO = System.IntPtr;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _DXGK_MONITORDESCRIPTORSET_INTERFACE
    {
        public IntPtr pfnGetNumDescriptors;
        public IntPtr pfnAcquireFirstDescriptorInfo;
        public IntPtr pfnAcquireNextDescriptorInfo;
        public IntPtr pfnReleaseDescriptorInfo;
    }
}
