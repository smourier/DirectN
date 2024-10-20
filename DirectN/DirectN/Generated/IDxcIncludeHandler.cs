// generated from <Windows SDK Path>\um\dxcapi.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    /// <summary>
    /// Interface for handling include directives.
    /// </summary>
    [ComImport, Guid("7f61fc7d-950d-467f-b3e3-3c02fb49187c"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IDxcIncludeHandler
    {
        /// <summary>
        /// Load a source file to be included by the compiler.
        /// </summary>
        [PreserveSig]
        HRESULT LoadSource(/* _In_z_ */ [MarshalAs(UnmanagedType.LPWStr)] string pFilename, /* _COM_Outptr_result_maybenull_ */ out IDxcBlob ppIncludeSource);
    }
}
