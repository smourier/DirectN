// generated from <Windows SDK Path>\um\dxcapi.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [ComImport, Guid("a005a9d9-b8bb-4594-b5c9-0e633bec4d37"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IDxcCompiler2 : IDxcCompiler
    {
        // IDxcCompiler
        /// <summary>
        /// Compile a single entry point to the target shader model.
        /// </summary>
        [PreserveSig]
        new HRESULT Compile(/* _In_ */ IDxcBlob pSource, /* // Source text to compile. _In_opt_z_ */ [MarshalAs(UnmanagedType.LPWStr)] string pSourceName, /* // Optional file name for pSource. Used in errors and include handlers. _In_opt_z_ */ [MarshalAs(UnmanagedType.LPWStr)] string pEntryPoint, /* // Entry point name. _In_z_ */ [MarshalAs(UnmanagedType.LPWStr)] string pTargetProfile, /* optional(LPCWSTR) */ IntPtr pArguments, /* // Array of pointers to arguments. _In_ */ uint argCount, /* // Number of arguments. _In_count_(defineCount) */ [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 7)] DxcDefine[] pDefines, /* // Array of defines. _In_ */ int defineCount, /* // Number of defines. _In_opt_ */ IDxcIncludeHandler pIncludeHandler, /* // User-provided interface to handle #include directives (optional). _COM_Outptr_ */ out IDxcOperationResult ppResult);
        
        /// <summary>
        /// Preprocess source text.
        /// </summary>
        [PreserveSig]
        new HRESULT Preprocess(/* _In_ */ IDxcBlob pSource, /* // Source text to preprocess. _In_opt_z_ */ [MarshalAs(UnmanagedType.LPWStr)] string pSourceName, /* optional(LPCWSTR) */ IntPtr pArguments, /* // Array of pointers to arguments. _In_ */ uint argCount, /* // Number of arguments. _In_count_(defineCount) */ [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 5)] DxcDefine[] pDefines, /* // Array of defines. _In_ */ int defineCount, /* // Number of defines. _In_opt_ */ IDxcIncludeHandler pIncludeHandler, /* // user-provided interface to handle #include directives (optional). _COM_Outptr_ */ out IDxcOperationResult ppResult);
        
        /// <summary>
        /// Disassemble a program.
        /// </summary>
        [PreserveSig]
        new HRESULT Disassemble(/* _In_ */ IDxcBlob pSource, /* // Program to disassemble. _COM_Outptr_ */ out IDxcBlobEncoding ppDisassembly);
        
        // IDxcCompiler2
        /// <summary>
        /// Compile a single entry point to the target shader model with debug information.
        /// </summary>
        [PreserveSig]
        HRESULT CompileWithDebug(/* _In_ */ IDxcBlob pSource, /* // Source text to compile. _In_opt_z_ */ [MarshalAs(UnmanagedType.LPWStr)] string pSourceName, /* // Optional file name for pSource. Used in errors and include handlers. _In_opt_z_ */ [MarshalAs(UnmanagedType.LPWStr)] string pEntryPoint, /* // Entry point name. _In_z_ */ [MarshalAs(UnmanagedType.LPWStr)] string pTargetProfile, /* optional(LPCWSTR) */ IntPtr pArguments, /* // Array of pointers to arguments. _In_ */ uint argCount, /* // Number of arguments. _In_count_(defineCount) */ [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 7)] DxcDefine[] pDefines, /* // Array of defines. _In_ */ int defineCount, /* // Number of defines. _In_opt_ */ IDxcIncludeHandler pIncludeHandler, /* // user-provided interface to handle #include directives (optional). _COM_Outptr_ */ out IDxcOperationResult ppResult, /* optional(LPWSTR) */ out IntPtr ppDebugBlobName, /* // Suggested file name for debug blob. Must be CoTaskMemFree()'d. _COM_Outptr_opt_ */ out IDxcBlob ppDebugBlob);
    }
}
