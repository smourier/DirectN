// c:\program files (x86)\windows kits\10\include\10.0.17763.0\um\dxcapi.h(146,1)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [Guid("cedb484a-d4e9-445a-b991-ca21ca157dc2"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IDxcOperationResult
    {
        [PreserveSig]
        HRESULT GetStatus(/* _Out_ */ out HRESULT pStatus);
        
        [PreserveSig]
        HRESULT GetResult(/* _COM_Outptr_result_maybenull_ */ out IDxcBlob pResult);
        
        [PreserveSig]
        HRESULT GetErrorBuffer(/* _COM_Outptr_result_maybenull_ */ out IDxcBlobEncoding pErrors);
    }
}
