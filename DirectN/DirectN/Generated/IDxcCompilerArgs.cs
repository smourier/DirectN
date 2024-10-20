// generated from <Windows SDK Path>\um\dxcapi.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    /// <summary>
    /// Interface for managing arguments passed to DXC.
    /// </summary>
    [ComImport, Guid("73effe2a-70dc-45f8-9690-eff64c02429d"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IDxcCompilerArgs
    {
        /// <summary>
        /// Retrieve the array of arguments.
        /// </summary>
        [PreserveSig]
        string GetArguments();
        
        /// <summary>
        /// Retrieve the number of arguments.
        /// </summary>
        [PreserveSig]
        uint GetCount();
        
        /// <summary>
        /// Add additional arguments to this list of compiler arguments.
        /// </summary>
        [PreserveSig]
        HRESULT AddArguments(/* optional(LPCWSTR) */ IntPtr pArguments, /* ///< Array of pointers to arguments to add. _In_ */ uint argCount);
        
        /// <summary>
        /// Add additional UTF-8 encoded arguments to this list of compiler arguments.
        /// </summary>
        [PreserveSig]
        HRESULT AddArgumentsUTF8(/* optional(LPCSTR) */ IntPtr pArguments, /* ///< Array of pointers to UTF-8 arguments to add. _In_ */ uint argCount);
        
        /// <summary>
        /// Add additional defines to this list of compiler arguments.
        /// </summary>
        [PreserveSig]
        HRESULT AddDefines(/* _In_count_(defineCount) */ [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 1)] DxcDefine[] pDefines, /* ///< Array of defines. _In_ */ int defineCount);
    }
}
