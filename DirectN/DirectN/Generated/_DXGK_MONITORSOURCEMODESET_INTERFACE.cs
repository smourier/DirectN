// generated from <Windows SDK Path>\shared\d3dkmddi.h
using System;
using System.Runtime.InteropServices;
using DXGKDDI_MONITORSOURCEMODESET_ACQUIREFIRSTMODEINFO = System.IntPtr;
using DXGKDDI_MONITORSOURCEMODESET_ACQUIRENEXTMODEINFO = System.IntPtr;
using DXGKDDI_MONITORSOURCEMODESET_ACQUIREPREFERREDMODEINFO = System.IntPtr;
using DXGKDDI_MONITORSOURCEMODESET_ADDMODE = System.IntPtr;
using DXGKDDI_MONITORSOURCEMODESET_CREATENEWMODEINFO = System.IntPtr;
using DXGKDDI_MONITORSOURCEMODESET_GETNUMMODES = System.IntPtr;
using DXGKDDI_MONITORSOURCEMODESET_RELEASEMODEINFO = System.IntPtr;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _DXGK_MONITORSOURCEMODESET_INTERFACE
    {
        public IntPtr pfnGetNumModes;
        public IntPtr pfnAcquirePreferredModeInfo;
        public IntPtr pfnAcquireFirstModeInfo;
        public IntPtr pfnAcquireNextModeInfo;
        public IntPtr pfnCreateNewModeInfo;
        public IntPtr pfnAddMode;
        public IntPtr pfnReleaseModeInfo;
    }
}
