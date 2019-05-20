// c:\program files (x86)\windows kits\10\include\10.0.18362.0\um\dxcapi.h(263,1)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [Guid("a6e82bd2-1fd7-4826-9811-2857e797f49a"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IDxcValidator
    {
        [PreserveSig]
        HRESULT Validate(/* _In_ */ IDxcBlob pShader, /* // Shader to validate. _In_ */ uint Flags, /* // Validation flags. _COM_Outptr_ */ out IDxcOperationResult ppResult);
    }
}
