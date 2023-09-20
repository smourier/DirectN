// generated from <Windows SDK Path>\um\strmif.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [ComImport, Guid("c6e13340-30ac-11d0-a18c-00a0c9118956"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IAMStreamConfig
    {
        [PreserveSig]
        HRESULT SetFormat(/* [in] */ ref _AMMediaType pmt);
        
        [PreserveSig]
        HRESULT GetFormat(/* [annotation][out] _Out_ */ out IntPtr ppmt);
        
        [PreserveSig]
        HRESULT GetNumberOfCapabilities(/* [annotation][out] _Out_ */ out int piCount, /* [annotation][out] _Out_ */ out int piSize);
        
        [PreserveSig]
        HRESULT GetStreamCaps(/* [in] */ int iIndex, /* [annotation][out] _Out_ */ out IntPtr ppmt, /* [annotation][out] _Out_ */ out byte pSCC);
    }
}
