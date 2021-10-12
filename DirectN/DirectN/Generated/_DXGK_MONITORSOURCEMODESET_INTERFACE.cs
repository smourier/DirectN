// c:\program files (x86)\windows kits\10\include\10.0.22000.0\shared\d3dkmddi.h(7164,9)
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
