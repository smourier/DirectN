// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\d3d12umddi.h(14235,9)
using System;
using System.Runtime.InteropServices;
using PFND3D12DDI_CREATESYNCHRONIZATIONOBJECT2CB = System.IntPtr;
using PFND3D12DDI_SIGNALSYNCHRONIZATIONOBJECT2CB = System.IntPtr;
using PFND3D12DDI_WAITFORSYNCHRONIZATIONOBJECT2CB = System.IntPtr;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct D3D12DDI_DOWNLEVEL_SUPPORT_CALLBACKS_0054
    {
        public IntPtr pfnCreateSynchronizationObject2Cb;
        public IntPtr pfnWaitForSynchronizationObject2Cb;
        public IntPtr pfnSignalSynchronizationObject2Cb;
    }
}
