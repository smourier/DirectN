// generated from <Windows SDK Path>\um\d3d12umddi.h
using System;
using System.Runtime.InteropServices;
using PFND3D12DDI_PINRESOURCES_CB_0076 = System.IntPtr;
using PFND3D12DDI_UNPINRESOURCES_CB_0076 = System.IntPtr;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct D3D12DDI_PIN_RESOURCES_CALLBACKS_0076
    {
        public IntPtr pfnPinResourcesCb;
        public IntPtr pfnUnpinResourcesCb;
    }
}
