using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [Guid("739d886a-cef5-47dc-8769-1a8b41bebbb0"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public interface IDWriteFontFile
    {
        [PreserveSig]
        HRESULT GetReferenceKey(out IntPtr fontFileReferenceKey, out int fontFileReferenceKeySize);

        [PreserveSig]
        HRESULT GetLoader(out IDWriteFontFileLoader fontFileLoader);

        [PreserveSig]
        HRESULT Analyze(out bool isSupportedFontType, out DWRITE_FONT_FILE_TYPE fontFileType, out DWRITE_FONT_FACE_TYPE fontFaceType, out int numberOfFaces);
    }
}
