// c:\program files (x86)\windows kits\10\include\10.0.17763.0\um\dwrite_3.h(3232,1)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [Guid("c0763a34-77af-445a-b735-08c37b0a5bf5"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IDWriteFontList2 : IDWriteFontList1
    {
        // IDWriteFontList1
        [PreserveSig]
        new DWRITE_LOCALITY GetFontLocality(uint listIndex);
        
        [PreserveSig]
        new HRESULT GetFont(uint listIndex, /* _COM_Outptr_ */ out IDWriteFont3 font);
        
        [PreserveSig]
        new HRESULT GetFontFaceReference(uint listIndex, /* _COM_Outptr_ */ out IDWriteFontFaceReference fontFaceReference);
        
        // IDWriteFontList2
        [PreserveSig]
        HRESULT GetFontSet(/* _COM_Outptr_ */ out IDWriteFontSet1 fontSet);
    }
}
