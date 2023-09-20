// generated from <Windows SDK Path>\um\strmif.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [ComImport, Guid("c6e13350-30ac-11d0-a18c-00a0c9118956"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IAMAnalogVideoDecoder
    {
        [PreserveSig]
        HRESULT get_AvailableTVFormats(/* [annotation][out] _Out_ */ out long lAnalogVideoStandard);
        
        [PreserveSig]
        HRESULT put_TVFormat(/* [in] */ int lAnalogVideoStandard);
        
        [PreserveSig]
        HRESULT get_TVFormat(/* [annotation][out] _Out_ */ out long plAnalogVideoStandard);
        
        [PreserveSig]
        HRESULT get_HorizontalLocked(/* [annotation][out] _Out_ */ out long plLocked);
        
        [PreserveSig]
        HRESULT put_VCRHorizontalLocking(/* [in] */ int lVCRHorizontalLocking);
        
        [PreserveSig]
        HRESULT get_VCRHorizontalLocking(/* [annotation][out] _Out_ */ out long plVCRHorizontalLocking);
        
        [PreserveSig]
        HRESULT get_NumberOfLines(/* [annotation][out] _Out_ */ out long plNumberOfLines);
        
        [PreserveSig]
        HRESULT put_OutputEnable(/* [in] */ int lOutputEnable);
        
        [PreserveSig]
        HRESULT get_OutputEnable(/* [annotation][out] _Out_ */ out long plOutputEnable);
    }
}
