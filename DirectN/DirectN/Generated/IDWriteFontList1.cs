// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\dwrite_3.h(877,1)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    /// <summary>
    /// The IDWriteFontList interface represents a list of fonts.
    /// </summary>
    [ComImport, Guid("da20d8ef-812a-4c43-9802-62ec4abd7ade"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IDWriteFontList1 : IDWriteFontList
    {
        // IDWriteFontList
        [PreserveSig]
        new HRESULT GetFontCollection(/* _COM_Outptr_ */ out IDWriteFontCollection fontCollection);
        
        [PreserveSig]
        new uint GetFontCount();
        
        [PreserveSig]
        new HRESULT GetFont(uint index, /* _COM_Outptr_ */ out IDWriteFont font);
        
        // IDWriteFontList1
        [PreserveSig]
        DWRITE_LOCALITY GetFontLocality(uint listIndex);
        
        [PreserveSig]
        HRESULT GetFont(uint listIndex, /* _COM_Outptr_ */ out IDWriteFont3 font);
        
        [PreserveSig]
        HRESULT GetFontFaceReference(uint listIndex, /* _COM_Outptr_ */ out IDWriteFontFaceReference fontFaceReference);
    }
}
