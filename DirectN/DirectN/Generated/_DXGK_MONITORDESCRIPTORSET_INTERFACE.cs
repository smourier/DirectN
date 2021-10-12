// c:\program files (x86)\windows kits\10\include\10.0.22000.0\shared\d3dkmddi.h(7286,9)
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
