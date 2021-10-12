// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\d3d12umddi.h(14310,9)
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
