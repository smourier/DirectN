// generated from <Windows SDK Path>\um\dxcapi.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    /// <summary>
    /// Interface to DxcAssembler.
    /// </summary>
    [ComImport, Guid("091f7a26-1c1f-4948-904b-e6e3a8a771d5"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IDxcAssembler
    {
        /// <summary>
        /// Assemble DXIL in LL or LLVM bitcode to DXIL container.
        /// </summary>
        [PreserveSig]
        HRESULT AssembleToContainer(/* _In_ */ IDxcBlob pShader, /* ///< Shader to assemble. _COM_Outptr_ */ out IDxcOperationResult ppResult);
    }
}
