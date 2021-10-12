// c:\program files (x86)\windows kits\10\include\10.0.22000.0\shared\d3dkmddi.h(6631,9)
using System;
using System.Runtime.InteropServices;
using DXGKDDI_VIDPNTOPOLOGY_ACQUIREFIRSTPATHINFO = System.IntPtr;
using DXGKDDI_VIDPNTOPOLOGY_ACQUIRENEXTPATHINFO = System.IntPtr;
using DXGKDDI_VIDPNTOPOLOGY_ACQUIREPATHINFO = System.IntPtr;
using DXGKDDI_VIDPNTOPOLOGY_ADDPATH = System.IntPtr;
using DXGKDDI_VIDPNTOPOLOGY_CREATENEWPATHINFO = System.IntPtr;
using DXGKDDI_VIDPNTOPOLOGY_ENUMPATHTARGETSFROMSOURCE = System.IntPtr;
using DXGKDDI_VIDPNTOPOLOGY_GETNUMPATHS = System.IntPtr;
using DXGKDDI_VIDPNTOPOLOGY_GETNUMPATHSFROMSOURCE = System.IntPtr;
using DXGKDDI_VIDPNTOPOLOGY_GETPATHSOURCEFROMTARGET = System.IntPtr;
using DXGKDDI_VIDPNTOPOLOGY_RELEASEPATHINFO = System.IntPtr;
using DXGKDDI_VIDPNTOPOLOGY_REMOVEPATH = System.IntPtr;
using DXGKDDI_VIDPNTOPOLOGY_UPDATEPATHSUPPORTINFO = System.IntPtr;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _DXGK_VIDPNTOPOLOGY_INTERFACE
    {
        public IntPtr pfnGetNumPaths;
        public IntPtr pfnGetNumPathsFromSource;
        public IntPtr pfnEnumPathTargetsFromSource;
        public IntPtr pfnGetPathSourceFromTarget;
        public IntPtr pfnAcquirePathInfo;
        public IntPtr pfnAcquireFirstPathInfo;
        public IntPtr pfnAcquireNextPathInfo;
        public IntPtr pfnUpdatePathSupportInfo;
        public IntPtr pfnReleasePathInfo;
        public IntPtr pfnCreateNewPathInfo;
        public IntPtr pfnAddPath;
        public IntPtr pfnRemovePath;
    }
}
