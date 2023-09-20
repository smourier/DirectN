// generated from <Windows SDK Path>\um\dxcapi.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [ComImport, Guid("8c210bf3-011f-4422-8d70-6f9acb8db617"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IDxcCompiler3
    {
        [PreserveSig]
        HRESULT Compile(/* _In_ */ ref DxcBuffer pSource, /* optional(LPCWSTR) */ IntPtr pArguments, /* // Array of pointers to arguments _In_ */ uint argCount, /* // Number of arguments _In_opt_ */ IDxcIncludeHandler pIncludeHandler, /* // user-provided interface to handle #include directives (optional) _In_ */ [MarshalAs(UnmanagedType.LPArray)] Guid[] riid, /* _Out_ */ out IntPtr ppResult);
        
        [PreserveSig]
        HRESULT Disassemble(/* _In_ */ ref DxcBuffer pObject, /* // Program to disassemble: dxil container or bitcode. _In_ */ [MarshalAs(UnmanagedType.LPStruct)] Guid riid, /* _Out_ */ out IntPtr ppResult);
    }
}
