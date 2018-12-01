// c:\program files (x86)\windows kits\10\include\10.0.17763.0\um\dwrite_1.h(1802,1)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    /// <summary>
    /// The IDWriteTextLayout1 interface represents a block of text after it has been fully analyzed and formatted.
    /// </summary>
    [Guid("9064d822-80a7-465c-a986-df65f78b8feb"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IDWriteTextLayout1
    {
        [PreserveSig]
        HRESULT SetPairKerning(bool isPairKerningEnabled, DWRITE_TEXT_RANGE textRange);
        
        [PreserveSig]
        HRESULT GetPairKerning(uint currentPosition, /* _Out_ */ out bool isPairKerningEnabled, /* _Out_opt_ */ out DWRITE_TEXT_RANGE textRange);
        
        [PreserveSig]
        HRESULT SetCharacterSpacing(float leadingSpacing, float trailingSpacing, float minimumAdvanceWidth, DWRITE_TEXT_RANGE textRange);
        
        [PreserveSig]
        HRESULT GetCharacterSpacing(uint currentPosition, /* _Out_ */ out float leadingSpacing, /* _Out_ */ out float trailingSpacing, /* _Out_ */ out float minimumAdvanceWidth, /* _Out_opt_ */ out DWRITE_TEXT_RANGE textRange);
    }
}
