// c:\program files (x86)\windows kits\10\include\10.0.19041.0\um\dwrite_3.h(932,1)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    /// <summary>
    /// A uniquely identifying reference to a font, from which you can create a font face to query font metrics and use for rendering. A font face reference consists of a font file, font face index, and font face simulation. The file data may or may not be physically present on the local machine yet.
    /// </summary>
    [ComImport, Guid("5e7fa7ca-dde3-424c-89f0-9fcd6fed58cd"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IDWriteFontFaceReference
    {
        [PreserveSig]
        HRESULT CreateFontFace(/* _COM_Outptr_ */ out IDWriteFontFace3 fontFace);
        
        [PreserveSig]
        HRESULT CreateFontFaceWithSimulations(DWRITE_FONT_SIMULATIONS fontFaceSimulationFlags, /* _COM_Outptr_ */ out IDWriteFontFace3 fontFace);
        
        [PreserveSig]
        bool Equals(IDWriteFontFaceReference fontFaceReference);
        
        [PreserveSig]
        uint GetFontFaceIndex();
        
        [PreserveSig]
        DWRITE_FONT_SIMULATIONS GetSimulations();
        
        [PreserveSig]
        HRESULT GetFontFile(/* _COM_Outptr_ */ out IDWriteFontFile fontFile);
        
        [PreserveSig]
        ulong GetLocalFileSize();
        
        [PreserveSig]
        ulong GetFileSize();
        
        [PreserveSig]
        HRESULT GetFileTime(/* _Out_ */ out long lastWriteTime);
        
        [PreserveSig]
        DWRITE_LOCALITY GetLocality();
        
        [PreserveSig]
        HRESULT EnqueueFontDownloadRequest();
        
        [PreserveSig]
        HRESULT EnqueueCharacterDownloadRequest(/* _In_reads_(characterCount) */ [MarshalAs(UnmanagedType.LPWStr)] string characters, uint characterCount);
        
        [PreserveSig]
        HRESULT EnqueueGlyphDownloadRequest(/* _In_reads_(glyphCount) */ [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 1)] ushort[] glyphIndices, int glyphCount);
        
        [PreserveSig]
        HRESULT EnqueueFileFragmentDownloadRequest(ulong fileOffset, ulong fragmentSize);
    }
}
