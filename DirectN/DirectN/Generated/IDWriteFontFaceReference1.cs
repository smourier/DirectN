// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\dwrite_3.h(2916,1)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [ComImport, Guid("c081fe77-2fd1-41ac-a5a3-34983c4ba61a"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IDWriteFontFaceReference1 : IDWriteFontFaceReference
    {
        // IDWriteFontFaceReference
        [PreserveSig]
        new HRESULT CreateFontFace(/* _COM_Outptr_ */ out IDWriteFontFace3 fontFace);
        
        [PreserveSig]
        new HRESULT CreateFontFaceWithSimulations(DWRITE_FONT_SIMULATIONS fontFaceSimulationFlags, /* _COM_Outptr_ */ out IDWriteFontFace3 fontFace);
        
        [PreserveSig]
        new bool Equals(IDWriteFontFaceReference fontFaceReference);
        
        [PreserveSig]
        new uint GetFontFaceIndex();
        
        [PreserveSig]
        new DWRITE_FONT_SIMULATIONS GetSimulations();
        
        [PreserveSig]
        new HRESULT GetFontFile(/* _COM_Outptr_ */ out IDWriteFontFile fontFile);
        
        [PreserveSig]
        new ulong GetLocalFileSize();
        
        [PreserveSig]
        new ulong GetFileSize();
        
        [PreserveSig]
        new HRESULT GetFileTime(/* _Out_ */ out long lastWriteTime);
        
        [PreserveSig]
        new DWRITE_LOCALITY GetLocality();
        
        [PreserveSig]
        new HRESULT EnqueueFontDownloadRequest();
        
        [PreserveSig]
        new HRESULT EnqueueCharacterDownloadRequest(/* _In_reads_(characterCount) */ [MarshalAs(UnmanagedType.LPWStr)] string characters, uint characterCount);
        
        [PreserveSig]
        new HRESULT EnqueueGlyphDownloadRequest(/* _In_reads_(glyphCount) */ [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 1)] ushort[] glyphIndices, int glyphCount);
        
        [PreserveSig]
        new HRESULT EnqueueFileFragmentDownloadRequest(ulong fileOffset, ulong fragmentSize);
        
        // IDWriteFontFaceReference1
        [PreserveSig]
        HRESULT CreateFontFace(/* _COM_Outptr_ */ out IDWriteFontFace5 fontFace);
        
        [PreserveSig]
        uint GetFontAxisValueCount();
        
        [PreserveSig]
        HRESULT GetFontAxisValues(/* _Out_writes_(fontAxisValueCount) */ [Out, MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 1)] DWRITE_FONT_AXIS_VALUE[] fontAxisValues, int fontAxisValueCount);
    }
}
