// generated from <Windows SDK Path>\um\ddkernel.h
using System;
using System.Runtime.InteropServices;
using LPDDKERNELCAPS = DirectN._DDKERNELCAPS;

namespace DirectN
{
    [ComImport, Guid("8d56c120-6a08-11d0-9b06-00a0c903a3b8"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IDirectDrawKernel
    {
        [PreserveSig]
        HRESULT GetCaps(ref LPDDKERNELCAPS unnamed__0);
        
        [PreserveSig]
        HRESULT GetKernelHandle(ref ulong unnamed__0);
        
        [PreserveSig]
        HRESULT ReleaseKernelHandle();
    }
}
