// generated from <Windows SDK Path>\um\strmif.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [ComImport, Guid("9fd52741-176d-4b36-8f51-ca8f933223be"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IAMClockSlave
    {
        [PreserveSig]
        HRESULT SetErrorTolerance(/* [in] */ uint dwTolerance);
        
        [PreserveSig]
        HRESULT GetErrorTolerance(/* [annotation][out] _Out_ */ out uint pdwTolerance);
    }
}
