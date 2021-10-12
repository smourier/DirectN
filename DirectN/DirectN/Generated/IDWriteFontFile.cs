// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\dwrite.h(818,1)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    /// <summary>
    /// The interface that represents a reference to a font file.
    /// </summary>
    [ComImport, Guid("739d886a-cef5-47dc-8769-1a8b41bebbb0"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IDWriteFontFile
    {
        [PreserveSig]
        HRESULT GetReferenceKey(/* _Outptr_result_bytebuffer_(*fontFileReferenceKeySize) */ out IntPtr fontFileReferenceKey, /* _Out_ */ out uint fontFileReferenceKeySize);
        
        [PreserveSig]
        HRESULT GetLoader(/* _COM_Outptr_ */ out IDWriteFontFileLoader fontFileLoader);
        
        [PreserveSig]
        HRESULT Analyze(/* _Out_ */ out bool isSupportedFontType, /* _Out_ */ out DWRITE_FONT_FILE_TYPE fontFileType, /* optional(DWRITE_FONT_FACE_TYPE) */ IntPtr fontFaceType, /* _Out_ */ out uint numberOfFaces);
    }
}
