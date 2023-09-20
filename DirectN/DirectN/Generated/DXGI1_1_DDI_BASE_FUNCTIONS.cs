// generated from <Windows SDK Path>\um\dxgiddi.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct DXGI1_1_DDI_BASE_FUNCTIONS
    {
        public IntPtr pfnPresent;
        public IntPtr pfnGetGammaCaps;
        public IntPtr pfnSetDisplayMode;
        public IntPtr pfnSetResourcePriority;
        public IntPtr pfnQueryResourceResidency;
        public IntPtr pfnRotateResourceIdentities;
        public IntPtr pfnBlt;
        public IntPtr pfnResolveSharedResource;
    }
}
