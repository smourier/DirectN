// generated from <Windows SDK Path>\um\strmif.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [ComImport, Guid("60d32930-13da-11d3-9ec6-c4fcaef5c7be"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IAMVideoDecimationProperties
    {
        [PreserveSig]
        HRESULT QueryDecimationUsage(/* [annotation][out] _Out_ */ out _DECIMATION_USAGE lpUsage);
        
        [PreserveSig]
        HRESULT SetDecimationUsage(/* [in] */ _DECIMATION_USAGE Usage);
    }
}
