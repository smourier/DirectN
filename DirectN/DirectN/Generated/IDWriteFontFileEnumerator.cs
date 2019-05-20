// c:\program files (x86)\windows kits\10\include\10.0.18362.0\um\dwrite.h(1337,1)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [Guid("72755049-5ff7-435d-8348-4be97cfa6c7c"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IDWriteFontFileEnumerator
    {
        [PreserveSig]
        HRESULT MoveNext(/* _Out_ */ out bool hasCurrentFile);
        
        [PreserveSig]
        HRESULT GetCurrentFontFile(/* _COM_Outptr_ */ out IDWriteFontFile fontFile);
    }
}
