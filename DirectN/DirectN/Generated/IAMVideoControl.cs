// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\strmif.h(11279,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [ComImport, Guid("6a2e0670-28e4-11d0-a18c-00a0c9118956"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IAMVideoControl
    {
        [PreserveSig]
        HRESULT GetCaps(/* [in] */ IPin pPin, /* [annotation][out] _Out_ */ out long pCapsFlags);
        
        [PreserveSig]
        HRESULT SetMode(/* [in] */ IPin pPin, /* [in] */ int Mode);
        
        [PreserveSig]
        HRESULT GetMode(/* [in] */ IPin pPin, /* [annotation][out] _Out_ */ out long Mode);
        
        [PreserveSig]
        HRESULT GetCurrentActualFrameRate(/* [in] */ IPin pPin, /* [annotation][out] _Out_ */ out long ActualFrameRate);
        
        [PreserveSig]
        HRESULT GetMaxAvailableFrameRate(/* [in] */ IPin pPin, /* [in] */ int iIndex, /* [in] */ tagSIZE Dimensions, /* [annotation][out] _Out_ */ out long MaxAvailableFrameRate);
        
        [PreserveSig]
        HRESULT GetFrameRateList(/* [in] */ IPin pPin, /* [in] */ int iIndex, /* [in] */ tagSIZE Dimensions, /* [annotation][out] _Out_ */ out long ListSize, /* [annotation][out] _Out_ */ out IntPtr FrameRates);
    }
}
