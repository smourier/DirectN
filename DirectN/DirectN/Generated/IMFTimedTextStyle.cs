// c:\program files (x86)\windows kits\10\include\10.0.19041.0\um\mfmediaengine.h(7178,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [ComImport, Guid("09b2455d-b834-4f01-a347-9052e21c450e"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IMFTimedTextStyle
    {
        [PreserveSig]
        HRESULT GetName(/* [annotation][out] _Outptr_ */ out IntPtr name);
        
        [PreserveSig]
        bool IsExternal();
        
        [PreserveSig]
        HRESULT GetFontFamily(/* [annotation][out] _Outptr_ */ out IntPtr fontFamily);
        
        [PreserveSig]
        HRESULT GetFontSize(/* [annotation][out] _Out_ */ out double fontSize, /* [annotation][out] _Out_ */ out MF_TIMED_TEXT_UNIT_TYPE unitType);
        
        [PreserveSig]
        HRESULT GetColor(/* [annotation][out] _Out_ */ out _MFARGB color);
        
        [PreserveSig]
        HRESULT GetBackgroundColor(/* [annotation][out] _Out_ */ out _MFARGB bgColor);
        
        [PreserveSig]
        HRESULT GetShowBackgroundAlways(/* [annotation][out] _Out_ */ out bool showBackgroundAlways);
        
        [PreserveSig]
        HRESULT GetFontStyle(/* [annotation][out] _Out_ */ out MF_TIMED_TEXT_FONT_STYLE fontStyle);
        
        [PreserveSig]
        HRESULT GetBold(/* [annotation][out] _Out_ */ out bool bold);
        
        [PreserveSig]
        HRESULT GetRightToLeft(/* [annotation][out] _Out_ */ out bool rightToLeft);
        
        [PreserveSig]
        HRESULT GetTextAlignment(/* [annotation][out] _Out_ */ out MF_TIMED_TEXT_ALIGNMENT textAlign);
        
        [PreserveSig]
        HRESULT GetTextDecoration(/* [annotation][out] _Out_ */ out uint textDecoration);
        
        [PreserveSig]
        HRESULT GetTextOutline(/* [annotation][out] _Out_ */ out _MFARGB color, /* [annotation][out] _Out_ */ out double thickness, /* [annotation][out] _Out_ */ out double blurRadius, /* [annotation][out] _Out_ */ out MF_TIMED_TEXT_UNIT_TYPE unitType);
    }
}
