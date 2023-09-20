// generated from <Windows SDK Path>\shared\d3dkmddi.h
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
