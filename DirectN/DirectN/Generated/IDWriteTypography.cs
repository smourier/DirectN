// c:\program files (x86)\windows kits\10\include\10.0.19041.0\um\dwrite.h(2295,1)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    /// <summary>
    /// Font typography setting.
    /// </summary>
    [ComImport, Guid("55f1112b-1dc2-4b3c-9541-f46894ed85b6"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IDWriteTypography
    {
        [PreserveSig]
        HRESULT AddFontFeature(DWRITE_FONT_FEATURE fontFeature);
        
        [PreserveSig]
        uint GetFontFeatureCount();
        
        [PreserveSig]
        HRESULT GetFontFeature(uint fontFeatureIndex, /* _Out_ */ out DWRITE_FONT_FEATURE fontFeature);
    }
}
