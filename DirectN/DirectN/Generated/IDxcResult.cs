// generated from <Windows SDK Path>\um\dxcapi.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [ComImport, Guid("58346CDA-DDE7-4497-9461-6F87AF5E0659"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IDxcResult : IDxcOperationResult
    {
        // IDxcOperationResult
        [PreserveSig]
        new HRESULT GetStatus(/* _Out_ */ out HRESULT pStatus);
        
        [PreserveSig]
        new HRESULT GetResult(/* _COM_Outptr_result_maybenull_ */ out IDxcBlob ppResult);
        
        [PreserveSig]
        new HRESULT GetErrorBuffer(/* _COM_Outptr_result_maybenull_ */ out IDxcBlobEncoding ppErrors);
        
        // IDxcResult
        [PreserveSig]
        bool HasOutput(/* _In_ */ DXC_OUT_KIND dxcOutKind);
        
        [PreserveSig]
        HRESULT GetOutput(/* _In_ */ DXC_OUT_KIND dxcOutKind, /* _In_ */ [MarshalAs(UnmanagedType.LPStruct)] Guid iid, /* _COM_Outptr_opt_result_maybenull_ */ [MarshalAs(UnmanagedType.IUnknown)] out object ppvObject, /* _COM_Outptr_ */ out IDxcBlobUtf16 ppOutputName);
        
        [PreserveSig]
        uint GetNumOutputs();
        
        [PreserveSig]
        DXC_OUT_KIND GetOutputByIndex(uint Index);
        
        [PreserveSig]
        DXC_OUT_KIND PrimaryOutput();
    }
}
