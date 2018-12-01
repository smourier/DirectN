// c:\program files (x86)\windows kits\10\include\10.0.17763.0\um\dwrite_3.h(791,1)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [Guid("53585141-d9f8-4095-8321-d73cf6bd116c"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IDWriteFontCollection1
    {
        [PreserveSig]
        HRESULT GetFontSet(/* _COM_Outptr_ */ out IDWriteFontSet fontSet);
        
        [PreserveSig]
        HRESULT GetFontFamily(uint index, /* _COM_Outptr_ */ out IDWriteFontFamily1 fontFamily);
    }
}
