// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\dwrite.h(1337,1)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    /// <summary>
    /// The font file enumerator interface encapsulates a collection of font files. The font system uses this interface to enumerate font files when building a font collection.
    /// </summary>
    [ComImport, Guid("72755049-5ff7-435d-8348-4be97cfa6c7c"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IDWriteFontFileEnumerator
    {
        [PreserveSig]
        HRESULT MoveNext(/* _Out_ */ out bool hasCurrentFile);
        
        [PreserveSig]
        HRESULT GetCurrentFontFile(/* _COM_Outptr_ */ out IDWriteFontFile fontFile);
    }
}
