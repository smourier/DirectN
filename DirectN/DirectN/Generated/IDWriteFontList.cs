// c:\program files (x86)\windows kits\10\include\10.0.18362.0\um\dwrite.h(1508,1)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [Guid("1a0d8438-1d97-4ec1-aef9-a2fb86ed6acb"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IDWriteFontList
    {
        [PreserveSig]
        HRESULT GetFontCollection(/* _COM_Outptr_ */ out IDWriteFontCollection fontCollection);
        
        [PreserveSig]
        uint GetFontCount();
        
        [PreserveSig]
        HRESULT GetFont(uint index, /* _COM_Outptr_ */ out IDWriteFont font);
    }
}
