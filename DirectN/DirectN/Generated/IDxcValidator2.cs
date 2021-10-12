// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\dxcapi.h(514,1)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [ComImport, Guid("458e1fd1-b1b2-4750-a6e1-9c10f03bed92"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IDxcValidator2 : IDxcValidator
    {
        // IDxcValidator
        [PreserveSig]
        new HRESULT Validate(/* _In_ */ IDxcBlob pShader, /* // Shader to validate. _In_ */ uint Flags, /* // Validation flags. _COM_Outptr_ */ out IDxcOperationResult ppResult);
        
        // IDxcValidator2
        [PreserveSig]
        HRESULT ValidateWithDebug(/* _In_ */ IDxcBlob pShader, /* // Shader to validate. _In_ */ uint Flags, /* optional(DxcBuffer) */ IntPtr pOptDebugBitcode, /* // Optional debug module bitcode to provide line numbers _COM_Outptr_ */ out IDxcOperationResult ppResult);
    }
}
