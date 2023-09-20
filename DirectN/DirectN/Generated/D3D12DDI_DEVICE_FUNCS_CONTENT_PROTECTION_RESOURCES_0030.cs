// generated from <Windows SDK Path>\um\d3d12umddi.h
using System;
using System.Runtime.InteropServices;
using PFND3D12DDI_CALCPRIVATEOPENEDPROTECTEDRESOURCESESSIONSIZE_0030 = System.IntPtr;
using PFND3D12DDI_CALCPRIVATEPROTECTEDRESOURCESESSIONSIZE_0030 = System.IntPtr;
using PFND3D12DDI_CREATEPROTECTEDRESOURCESESSION_0030 = System.IntPtr;
using PFND3D12DDI_DESTROYPROTECTEDRESOURCESESSION_0030 = System.IntPtr;
using PFND3D12DDI_OPENPROTECTEDRESOURCESESSION_0030 = System.IntPtr;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct D3D12DDI_DEVICE_FUNCS_CONTENT_PROTECTION_RESOURCES_0030
    {
        public IntPtr pfnCalcPrivateProtectedResourceSessionSize;
        public IntPtr pfnCreateProtectedResourceSession;
        public IntPtr pfnCalcPrivateOpenedProtectedResourceSessionSize;
        public IntPtr pfnOpenProtectedResourceSession;
        public IntPtr pfnDestroyProtectedResourceSession;
    }
}
