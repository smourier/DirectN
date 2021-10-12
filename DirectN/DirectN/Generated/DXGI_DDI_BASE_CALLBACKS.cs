// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\dxgiddi.h(988,9)
using System;
using System.Runtime.InteropServices;
using PFNDDXGIDDI_PRESENT_MULTIPLANE_OVERLAY1CB = System.IntPtr;
using PFNDDXGIDDI_PRESENT_MULTIPLANE_OVERLAYCB = System.IntPtr;
using PFNDDXGIDDI_PRESENTCB = System.IntPtr;
using PFNDDXGIDDI_SUBMITPRESENTBLTTOHWQUEUECB = System.IntPtr;
using PFNDDXGIDDI_SUBMITPRESENTTOHWQUEUECB = System.IntPtr;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct DXGI_DDI_BASE_CALLBACKS
    {
        public IntPtr pfnPresentCb;
        public IntPtr pfnPresentMultiplaneOverlayCb;
        public IntPtr pfnPresentMultiplaneOverlay1Cb;
        public IntPtr pfnSubmitPresentBltToHwQueueCb;
        public IntPtr pfnSubmitPresentToHwQueueCb;
    }
}
