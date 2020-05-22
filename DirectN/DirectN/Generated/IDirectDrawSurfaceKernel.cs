// c:\program files (x86)\windows kits\10\include\10.0.19041.0\um\ddkernel.h(91,1)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [Guid("60755da0-6a40-11d0-9b06-00a0c903a3b8"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IDirectDrawSurfaceKernel
    {
        [PreserveSig]
        HRESULT GetKernelHandle(ref ulong unnamed__0);
        
        [PreserveSig]
        HRESULT ReleaseKernelHandle();
    }
}
