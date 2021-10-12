// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\d3d12umddi.h(10647,9)
using System;
using System.Runtime.InteropServices;
using PFND3D12DDI_CALCPRIVATEOPENEDPROTECTEDRESOURCESESSIONSIZE_0030 = System.IntPtr;
using PFND3D12DDI_CALCPRIVATEPROTECTEDRESOURCESESSIONSIZE_0074 = System.IntPtr;
using PFND3D12DDI_CREATEPROTECTEDRESOURCESESSION_0074 = System.IntPtr;
using PFND3D12DDI_DESTROYPROTECTEDRESOURCESESSION_0030 = System.IntPtr;
using PFND3D12DDI_OPENPROTECTEDRESOURCESESSION_0030 = System.IntPtr;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct D3D12DDI_DEVICE_FUNCS_CONTENT_PROTECTION_RESOURCES_0074
    {
        public IntPtr pfnCalcPrivateProtectedResourceSessionSize;
        public IntPtr pfnCreateProtectedResourceSession;
        public IntPtr pfnCalcPrivateOpenedProtectedResourceSessionSize;
        public IntPtr pfnOpenProtectedResourceSession;
        public IntPtr pfnDestroyProtectedResourceSession;
    }
}
