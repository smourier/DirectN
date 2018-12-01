// c:\program files (x86)\windows kits\10\include\10.0.17763.0\um\strmif.h(5848,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [Guid("56a868a1-0ad4-11ce-b03a-0020af0ba770"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IOverlay
    {
        [PreserveSig]
        HRESULT GetPalette(/* [annotation][out] _Inout_ */ ref uint pdwColors, /* [annotation][size_is][size_is][out] _Outptr_result_buffer_to_(*pdwColors, *pdwColors) */ out tagPALETTEENTRY[] ppPalette);
        
        [PreserveSig]
        HRESULT SetPalette(/* [in] */ uint dwColors, /* [annotation][size_is][in] _In_reads_(dwColors) */ [In, Out, MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 0)] tagPALETTEENTRY[] pPalette);
        
        [PreserveSig]
        HRESULT GetDefaultColorKey(/* [annotation][out] _Out_ */ out tagCOLORKEY pColorKey);
        
        [PreserveSig]
        HRESULT GetColorKey(/* [annotation][out] _Out_ */ out tagCOLORKEY pColorKey);
        
        [PreserveSig]
        HRESULT SetColorKey(/* [out][in] */ ref tagCOLORKEY pColorKey);
        
        [PreserveSig]
        HRESULT GetWindowHandle(/* [annotation][out] _Out_ */ out IntPtr pHwnd);
        
        [PreserveSig]
        HRESULT GetClipList(/* [annotation][out] _Out_ */ out tagRECT pSourceRect, /* [annotation][out] _Out_ */ out tagRECT pDestinationRect, /* [annotation][out] _Out_ */ out _RGNDATA ppRgnData);
        
        [PreserveSig]
        HRESULT GetVideoPosition(/* [annotation][out] _Out_ */ out tagRECT pSourceRect, /* [annotation][out] _Out_ */ out tagRECT pDestinationRect);
        
        [PreserveSig]
        HRESULT Advise(/* [in] */ IOverlayNotify pOverlayNotify, /* [in] */ uint dwInterests);
        
        [PreserveSig]
        HRESULT Unadvise();
    }
}
