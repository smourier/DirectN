// c:\program files (x86)\windows kits\10\include\10.0.19041.0\um\strmif.h(16707,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [Guid("9fd52741-176d-4b36-8f51-ca8f933223be"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IAMClockSlave
    {
        [PreserveSig]
        HRESULT SetErrorTolerance(/* [in] */ uint dwTolerance);
        
        [PreserveSig]
        HRESULT GetErrorTolerance(/* [annotation][out] _Out_ */ out uint pdwTolerance);
    }
}
