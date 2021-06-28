// c:\program files (x86)\windows kits\10\include\10.0.19041.0\um\dxgiddi.h(684,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct DXGI1_2_DDI_BASE_FUNCTIONS
    {
        public IntPtr pfnPresent;
        public IntPtr pfnGetGammaCaps;
        public IntPtr pfnSetDisplayMode;
        public IntPtr pfnSetResourcePriority;
        public IntPtr pfnQueryResourceResidency;
        public IntPtr pfnRotateResourceIdentities;
        public IntPtr pfnBlt;
        public IntPtr pfnResolveSharedResource;
        public IntPtr pfnBlt1;
        public IntPtr pfnOfferResources;
        public IntPtr pfnReclaimResources;
        public IntPtr pfnGetMultiplaneOverlayCaps;
        public IntPtr pfnGetMultiplaneOverlayFilterRange;
        public IntPtr pfnCheckMultiplaneOverlaySupport;
        public IntPtr pfnPresentMultiplaneOverlay;
    }
}
