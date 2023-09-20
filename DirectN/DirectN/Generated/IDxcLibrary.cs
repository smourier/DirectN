// generated from <Windows SDK Path>\um\dxcapi.h
using System;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.ComTypes;

namespace DirectN
{
    [ComImport, Guid("e5204dc7-d18c-4c3c-bdfb-851673980fe7"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IDxcLibrary
    {
        [PreserveSig]
        HRESULT SetMalloc(/* optional(IMalloc) */ IntPtr pMalloc);
        
        [PreserveSig]
        HRESULT CreateBlobFromBlob(/* _In_ */ IDxcBlob pBlob, uint offset, uint length, /* _COM_Outptr_ */ out IDxcBlob ppResult);
        
        [PreserveSig]
        HRESULT CreateBlobFromFile(/* _In_z_ */ [MarshalAs(UnmanagedType.LPWStr)] string pFileName, /* optional(UINT32) */ IntPtr codePage, /* _COM_Outptr_ */ out IDxcBlobEncoding pBlobEncoding);
        
        [PreserveSig]
        HRESULT CreateBlobWithEncodingFromPinned(/* _In_bytecount_(size) */ [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 1)] IntPtr[] pText, int size, uint codePage, /* _COM_Outptr_ */ out IDxcBlobEncoding pBlobEncoding);
        
        [PreserveSig]
        HRESULT CreateBlobWithEncodingOnHeapCopy(/* _In_bytecount_(size) */ [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 1)] IntPtr[] pText, int size, uint codePage, /* _COM_Outptr_ */ out IDxcBlobEncoding pBlobEncoding);
        
        [PreserveSig]
        HRESULT CreateBlobWithEncodingOnMalloc(/* _In_bytecount_(size) */ [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 2)] IntPtr[] pText, ref IMalloc pIMalloc, int size, uint codePage, /* _COM_Outptr_ */ out IDxcBlobEncoding pBlobEncoding);
        
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
