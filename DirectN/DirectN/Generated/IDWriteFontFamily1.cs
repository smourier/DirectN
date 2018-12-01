// c:\program files (x86)\windows kits\10\include\10.0.17763.0\um\dwrite_3.h(825,1)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    /// <summary>
    /// The IDWriteFontFamily interface represents a set of fonts that share the same design but are differentiated by weight, stretch, and style.
    /// </summary>
    [Guid("da20d8ef-812a-4c43-9802-62ec4abd7adf"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IDWriteFontFamily1
    {
        [PreserveSig]
        DWRITE_LOCALITY GetFontLocality(uint listIndex);
        
        [PreserveSig]
        HRESULT GetFont(uint listIndex, /* _COM_Outptr_ */ out IDWriteFont3 font);
        
        [PreserveSig]
        HRESULT GetFontFaceReference(uint listIndex, /* _COM_Outptr_ */ out IDWriteFontFaceReference fontFaceReference);
    }
}
