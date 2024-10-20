// generated from <Windows SDK Path>\um\dxcapi.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    /// <summary>
    /// DXC linker interface.
    /// </summary>
    [ComImport, Guid("f1b5be2a-62dd-4327-a1c2-42ac1e1e78e6"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IDxcLinker
    {
        /// <summary>
        /// Register a library with name to reference it later.
        /// </summary>
        [PreserveSig]
        HRESULT RegisterLibrary(/* _In_opt_ */ [MarshalAs(UnmanagedType.LPWStr)] string pLibName, /* ///< Name of the library. _In_ */ IDxcBlob pLib);
        
        /// <summary>
        /// Links the shader and produces a shader blob that the Direct3D runtime can use.
        /// </summary>
        [PreserveSig]
        HRESULT Link(/* _In_opt_ */ [MarshalAs(UnmanagedType.LPWStr)] string pEntryName, /* ///< Entry point name. _In_ */ [MarshalAs(UnmanagedType.LPWStr)] string pTargetProfile, /* ///< shader profile to link. _In_count_(libCount) */ IntPtr pLibNames, /* ///< Array of library names to link. _In_ */ uint libCount, /* optional(LPCWSTR) */ IntPtr pArguments, /* ///< Array of pointers to arguments. _In_ */ uint argCount, /* ///< Number of arguments. _COM_Outptr_ */ out IDxcOperationResult ppResult);
    }
}
