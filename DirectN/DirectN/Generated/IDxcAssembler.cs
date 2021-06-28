// c:\program files (x86)\windows kits\10\include\10.0.19041.0\um\dxcapi.h(291,1)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [ComImport, Guid("091f7a26-1c1f-4948-904b-e6e3a8a771d5"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IDxcAssembler
    {
        [PreserveSig]
        HRESULT AssembleToContainer(/* _In_ */ IDxcBlob pShader, /* // Shader to assemble. _COM_Outptr_ */ out IDxcOperationResult ppResult);
    }
}
