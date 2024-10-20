// generated from <Windows SDK Path>\um\dxcapi.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    /// <summary>
    /// Interface to DXC shader validator.
    /// </summary>
    [ComImport, Guid("a6e82bd2-1fd7-4826-9811-2857e797f49a"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IDxcValidator
    {
        /// <summary>
        /// Validate a shader.
        /// </summary>
        [PreserveSig]
        HRESULT Validate(/* _In_ */ IDxcBlob pShader, /* ///< Shader to validate. _In_ */ uint Flags, /* ///< Validation flags. _COM_Outptr_ */ out IDxcOperationResult ppResult);
    }
}
