// generated from <Windows SDK Path>\um\dxcapi.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    /// <summary>
    /// Result of a DXC operation.
    /// </summary>
    [ComImport, Guid("58346cda-dde7-4497-9461-6f87af5e0659"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IDxcResult : IDxcOperationResult
    {
        // IDxcOperationResult
        /// <summary>
        /// Retrieve the overall status of the operation.
        /// </summary>
        [PreserveSig]
        new HRESULT GetStatus(/* _Out_ */ out HRESULT pStatus);
        
        /// <summary>
        /// Retrieve the primary output of the operation.
        /// </summary>
        [PreserveSig]
        new HRESULT GetResult(/* _COM_Outptr_result_maybenull_ */ out IDxcBlob ppResult);
        
        /// <summary>
        /// Retrieves the error buffer from the operation, if there is one.
        /// </summary>
        [PreserveSig]
        new HRESULT GetErrorBuffer(/* _COM_Outptr_result_maybenull_ */ out IDxcBlobEncoding ppErrors);
        
        // IDxcResult
        /// <summary>
        /// Determines whether or not this result has the specified output.
        /// </summary>
        [PreserveSig]
        bool HasOutput(/* _In_ */ DXC_OUT_KIND dxcOutKind);
        
        /// <summary>
        /// Retrieves the specified output.
        /// </summary>
        [PreserveSig]
        HRESULT GetOutput(/* _In_ */ DXC_OUT_KIND dxcOutKind, /* _In_ */ [MarshalAs(UnmanagedType.LPStruct)] Guid iid, /* _COM_Outptr_opt_result_maybenull_ */ [MarshalAs(UnmanagedType.IUnknown)] out object ppvObject, /* _COM_Outptr_ */ out IDxcBlobWide ppOutputName);
        
        /// <summary>
        /// Retrieves the number of outputs available in this result.
        /// </summary>
        [PreserveSig]
        uint GetNumOutputs();
        
        /// <summary>
        /// Retrieves the output kind at the specified index.
        /// </summary>
        [PreserveSig]
        DXC_OUT_KIND GetOutputByIndex(uint Index);
        
        /// <summary>
        /// Retrieves the primary output kind for this result.
        /// </summary>
        [PreserveSig]
        DXC_OUT_KIND PrimaryOutput();
    }
}
