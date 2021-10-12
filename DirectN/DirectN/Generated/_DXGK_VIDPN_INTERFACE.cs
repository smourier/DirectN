// c:\program files (x86)\windows kits\10\include\10.0.22000.0\shared\d3dkmddi.h(7030,9)
using System;
using System.Runtime.InteropServices;
using DXGKDDI_VIDPN_ACQUIRESOURCEMODESET = System.IntPtr;
using DXGKDDI_VIDPN_ACQUIRETARGETMODESET = System.IntPtr;
using DXGKDDI_VIDPN_ASSIGNMULTISAMPLINGMETHODSET = System.IntPtr;
using DXGKDDI_VIDPN_ASSIGNSOURCEMODESET = System.IntPtr;
using DXGKDDI_VIDPN_ASSIGNTARGETMODESET = System.IntPtr;
using DXGKDDI_VIDPN_CREATENEWSOURCEMODESET = System.IntPtr;
using DXGKDDI_VIDPN_CREATENEWTARGETMODESET = System.IntPtr;
using DXGKDDI_VIDPN_GETTOPOLOGY = System.IntPtr;
using DXGKDDI_VIDPN_RELEASESOURCEMODESET = System.IntPtr;
using DXGKDDI_VIDPN_RELEASETARGETMODESET = System.IntPtr;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _DXGK_VIDPN_INTERFACE
    {
        public _DXGK_VIDPN_INTERFACE_VERSION Version;
        public IntPtr pfnGetTopology;
        public IntPtr pfnAcquireSourceModeSet;
        public IntPtr pfnReleaseSourceModeSet;
        public IntPtr pfnCreateNewSourceModeSet;
        public IntPtr pfnAssignSourceModeSet;
        public IntPtr pfnAssignMultisamplingMethodSet;
        public IntPtr pfnAcquireTargetModeSet;
        public IntPtr pfnReleaseTargetModeSet;
        public IntPtr pfnCreateNewTargetModeSet;
        public IntPtr pfnAssignTargetModeSet;
    }
}
