// c:\program files (x86)\windows kits\10\include\10.0.17763.0\um\dxcapi.h(117,1)
using System;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.ComTypes;

namespace DirectN
{
    [Guid("e5204dc7-d18c-4c3c-bdfb-851673980fe7"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IDxcLibrary
    {
        [PreserveSig]
        HRESULT SetMalloc(/* _In_opt_ */ ref IMalloc pMalloc);
        
        [PreserveSig]
        HRESULT CreateBlobFromBlob(/* _In_ */ IDxcBlob pBlob, uint offset, uint length, /* _COM_Outptr_ */ out IDxcBlob ppResult);
        
        [PreserveSig]
        HRESULT CreateBlobFromFile([MarshalAs(UnmanagedType.LPWStr)] string pFileName, /* _In_opt_ */ ref uint codePage, /* _COM_Outptr_ */ out IDxcBlobEncoding pBlobEncoding);
        
        [PreserveSig]
        HRESULT CreateBlobWithEncodingFromPinned(/* _In_bytecount_(size) */ IntPtr pText, uint size, uint codePage, /* _COM_Outptr_ */ out IDxcBlobEncoding pBlobEncoding);
        
        [PreserveSig]
        HRESULT CreateBlobWithEncodingOnHeapCopy(/* _In_bytecount_(size) */ IntPtr pText, uint size, uint codePage, /* _COM_Outptr_ */ out IDxcBlobEncoding pBlobEncoding);
        
        [PreserveSig]
        HRESULT CreateBlobWithEncodingOnMalloc(/* _In_bytecount_(size) */ IntPtr pText, ref IMalloc pIMalloc, uint size, uint codePage, /* _COM_Outptr_ */ out IDxcBlobEncoding pBlobEncoding);
        
        [PreserveSig]
        HRESULT CreateIncludeHandler(/* _COM_Outptr_ */ out IDxcIncludeHandler ppResult);
        
        [PreserveSig]
        HRESULT CreateStreamFromBlobReadOnly(/* _In_ */ IDxcBlob pBlob, /* _COM_Outptr_ */ out IStream ppStream);
        
        [PreserveSig]
        HRESULT GetBlobAsUtf8(/* _In_ */ IDxcBlob pBlob, /* _COM_Outptr_ */ out IDxcBlobEncoding pBlobEncoding);
        
        [PreserveSig]
        HRESULT GetBlobAsUtf16(/* _In_ */ IDxcBlob pBlob, /* _COM_Outptr_ */ out IDxcBlobEncoding pBlobEncoding);
    }
}
