// generated from <Windows SDK Path>\um\dxcapi.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    /// <summary>
    /// The results of a DXC operation.
    /// </summary>
    [ComImport, Guid("cedb484a-d4e9-445a-b991-ca21ca157dc2"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IDxcOperationResult
    {
        /// <summary>
        /// Retrieve the overall status of the operation.
        /// </summary>
        [PreserveSig]
        HRESULT GetStatus(/* _Out_ */ out HRESULT pStatus);
        
        /// <summary>
        /// Retrieve the primary output of the operation.
        /// </summary>
        [PreserveSig]
        HRESULT GetResult(/* _COM_Outptr_result_maybenull_ */ out IDxcBlob ppResult);
        
        /// <summary>
        /// Retrieves the error buffer from the operation, if there is one.
        /// </summary>
        [PreserveSig]
        HRESULT GetErrorBuffer(/* _COM_Outptr_result_maybenull_ */ out IDxcBlobEncoding ppErrors);
    }
}
