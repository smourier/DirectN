// generated from <Windows SDK Path>\um\ddkernel.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [ComImport, Guid("60755da0-6a40-11d0-9b06-00a0c903a3b8"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IDirectDrawSurfaceKernel
    {
        [PreserveSig]
        HRESULT GetKernelHandle(ref ulong unnamed__0);
        
        [PreserveSig]
        HRESULT ReleaseKernelHandle();
    }
}
