// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\dwrite_3.h(2202,1)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    /// <summary>
    /// The IDWriteRemoteFontFileLoader interface represents a font file loader that can access remote (i.e., downloadable) fonts. The IDWriteFactory5::CreateHttpFontFileLoader method returns an instance of this interface, or a client can create its own implementation.  <remarks> Calls to a remote file loader or stream should never block waiting for network operations. Any call that cannot succeeded immediately using local (e.g., cached) must should return DWRITE_E_REMOTEFONT. This error signifies to DWrite that it should add requests to the font download queue. </remarks>
    /// </summary>
    [ComImport, Guid("68648c83-6ede-46c0-ab46-20083a887fde"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IDWriteRemoteFontFileLoader : IDWriteFontFileLoader
    {
        // IDWriteFontFileLoader
        [PreserveSig]
        new HRESULT CreateStreamFromKey(/* _In_reads_bytes_(fontFileReferenceKeySize) */ IntPtr fontFileReferenceKey, uint fontFileReferenceKeySize, /* _COM_Outptr_ */ out IDWriteFontFileStream fontFileStream);
        
        // IDWriteRemoteFontFileLoader
        [PreserveSig]
        HRESULT CreateRemoteStreamFromKey(/* _In_reads_bytes_(fontFileReferenceKeySize) */ IntPtr fontFileReferenceKey, uint fontFileReferenceKeySize, /* _COM_Outptr_ */ out IDWriteRemoteFontFileStream fontFileStream);
        
        [PreserveSig]
        HRESULT GetLocalityFromKey(/* _In_reads_bytes_(fontFileReferenceKeySize) */ IntPtr fontFileReferenceKey, uint fontFileReferenceKeySize, /* _Out_ */ out DWRITE_LOCALITY locality);
        
        [PreserveSig]
        HRESULT CreateFontFileReferenceFromUrl(IDWriteFactory factory, /* _In_opt_z_ */ [MarshalAs(UnmanagedType.LPWStr)] string baseUrl, /* _In_z_ */ [MarshalAs(UnmanagedType.LPWStr)] string fontFileUrl, /* _COM_Outptr_ */ out IDWriteFontFile fontFile);
    }
}
