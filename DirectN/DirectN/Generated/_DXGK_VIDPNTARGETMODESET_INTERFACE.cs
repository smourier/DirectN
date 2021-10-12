// c:\program files (x86)\windows kits\10\include\10.0.22000.0\shared\d3dkmddi.h(6861,9)
using System;
using System.Runtime.InteropServices;
using DXGKDDI_VIDPNTARGETMODESET_ACQUIREFIRSTMODEINFO = System.IntPtr;
using DXGKDDI_VIDPNTARGETMODESET_ACQUIRENEXTMODEINFO = System.IntPtr;
using DXGKDDI_VIDPNTARGETMODESET_ACQUIREPINNEDMODEINFO = System.IntPtr;
using DXGKDDI_VIDPNTARGETMODESET_ADDMODE = System.IntPtr;
using DXGKDDI_VIDPNTARGETMODESET_CREATENEWMODEINFO = System.IntPtr;
using DXGKDDI_VIDPNTARGETMODESET_GETNUMMODES = System.IntPtr;
using DXGKDDI_VIDPNTARGETMODESET_PINMODE = System.IntPtr;
using DXGKDDI_VIDPNTARGETMODESET_RELEASEMODEINFO = System.IntPtr;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _DXGK_VIDPNTARGETMODESET_INTERFACE
    {
        public IntPtr pfnGetNumModes;
        public IntPtr pfnAcquireFirstModeInfo;
        public IntPtr pfnAcquireNextModeInfo;
        public IntPtr pfnAcquirePinnedModeInfo;
        public IntPtr pfnReleaseModeInfo;
        public IntPtr pfnCreateNewModeInfo;
        public IntPtr pfnAddMode;
        public IntPtr pfnPinMode;
    }
}
