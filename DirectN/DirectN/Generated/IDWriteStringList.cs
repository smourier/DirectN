// generated from <Windows SDK Path>\um\dwrite_3.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    /// <summary>
    /// Represents a collection of strings indexed by number. An IDWriteStringList is otherwise identical to IDWriteLocalizedStrings except for the semantics, where localized strings are indexed on language (each language has one string property) whereas a string list may contain multiple strings of the same language, such as a string list of family names from a font set. You can QueryInterface from an IDWriteLocalizedStrings to an IDWriteStringList.
    /// </summary>
    [ComImport, Guid("cfee3140-1157-47ca-8b85-31bfcf3f2d0e"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IDWriteStringList
    {
        [PreserveSig]
        uint GetCount();
        
        [PreserveSig]
        HRESULT GetLocaleNameLength(uint listIndex, /* _Out_ */ out uint length);
        
        [PreserveSig]
        HRESULT GetLocaleName(uint listIndex, /* _Out_writes_z_(size) */ [MarshalAs(UnmanagedType.LPWStr)] string localeName, uint size);
        
        [PreserveSig]
        HRESULT GetStringLength(uint listIndex, /* _Out_ */ out uint length);
        
        [PreserveSig]
        HRESULT GetString(uint listIndex, /* _Out_writes_z_(stringBufferSize) */ [MarshalAs(UnmanagedType.LPWStr)] string stringBuffer, uint stringBufferSize);
    }
}
