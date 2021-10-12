// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\dwrite_3.h(2272,1)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    /// <summary>
    /// The IDWriteInMemoryFontFileLoader interface enables clients to reference in-memory fonts without having to implement a custom loader. The IDWriteFactory5::CreateInMemoryFontFileLoader method returns an instance of this interface, which the client is responsible for registering and unregistering using IDWriteFactory::RegisterFontFileLoader and IDWriteFactory::UnregisterFontFileLoader.
    /// </summary>
    [ComImport, Guid("dc102f47-a12d-4b1c-822d-9e117e33043f"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IDWriteInMemoryFontFileLoader : IDWriteFontFileLoader
    {
        // IDWriteFontFileLoader
        [PreserveSig]
        new HRESULT CreateStreamFromKey(/* _In_reads_bytes_(fontFileReferenceKeySize) */ IntPtr fontFileReferenceKey, uint fontFileReferenceKeySize, /* _COM_Outptr_ */ out IDWriteFontFileStream fontFileStream);
        
        // IDWriteInMemoryFontFileLoader
        [PreserveSig]
        HRESULT CreateInMemoryFontFileReference(IDWriteFactory factory, /* _In_reads_bytes_(fontDataSize) */ IntPtr fontData, uint fontDataSize, /* _In_opt_ */ [MarshalAs(UnmanagedType.IUnknown)] object ownerObject, /* _COM_Outptr_ */ out IDWriteFontFile fontFile);
        
        [PreserveSig]
        uint GetFileCount();
    }
}
