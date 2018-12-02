// c:\program files (x86)\windows kits\10\include\10.0.17763.0\um\mfmediaengine.h(7409,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [Guid("c8d22afc-bc47-4bdf-9b04-787e49ce3f58"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IMFTimedTextRegion
    {
        [PreserveSig]
        HRESULT GetName(/* [annotation][out] _Outptr_ */ out IntPtr name);
        
        [PreserveSig]
        HRESULT GetPosition(/* [annotation][out] _Out_ */ out double pX, /* [annotation][out] _Out_ */ out double pY, /* [annotation][out] _Out_ */ out MF_TIMED_TEXT_UNIT_TYPE unitType);
        
        [PreserveSig]
        HRESULT GetExtent(/* [annotation][out] _Out_ */ out double pWidth, /* [annotation][out] _Out_ */ out double pHeight, /* [annotation][out] _Out_ */ out MF_TIMED_TEXT_UNIT_TYPE unitType);
        
        [PreserveSig]
        HRESULT GetBackgroundColor(/* [annotation][out] _Out_ */ out _MFARGB bgColor);
        
        [PreserveSig]
        HRESULT GetWritingMode(/* [annotation][out] _Out_ */ out MF_TIMED_TEXT_WRITING_MODE writingMode);
        
        [PreserveSig]
        HRESULT GetDisplayAlignment(/* [annotation][out] _Out_ */ out MF_TIMED_TEXT_DISPLAY_ALIGNMENT displayAlign);
        
        [PreserveSig]
        HRESULT GetLineHeight(/* [annotation][out] _Out_ */ out double pLineHeight, /* [annotation][out] _Out_ */ out MF_TIMED_TEXT_UNIT_TYPE unitType);
        
        [PreserveSig]
        HRESULT GetClipOverflow(/* [annotation][out] _Out_ */ out bool clipOverflow);
        
        [PreserveSig]
        HRESULT GetPadding(/* [annotation][out] _Out_ */ out double before, /* [annotation][out] _Out_ */ out double start, /* [annotation][out] _Out_ */ out double after, /* [annotation][out] _Out_ */ out double end, /* [annotation][out] _Out_ */ out MF_TIMED_TEXT_UNIT_TYPE unitType);
        
        [PreserveSig]
        HRESULT GetWrap(/* [annotation][out] _Out_ */ out bool wrap);
        
        [PreserveSig]
        HRESULT GetZIndex(/* [annotation][out] _Out_ */ out int zIndex);
        
        [PreserveSig]
        HRESULT GetScrollMode(/* [annotation][out] _Out_ */ out MF_TIMED_TEXT_SCROLL_MODE scrollMode);
    }
}
