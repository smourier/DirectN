// generated from <Windows SDK Path>\um\dxcapi.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [ComImport, Guid("73effe2a-70dc-45f8-9690-eff64c02429d"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IDxcCompilerArgs
    {
        [PreserveSig]
        string GetArguments();
        
        [PreserveSig]
        uint GetCount();
        
        [PreserveSig]
        HRESULT AddArguments(/* optional(LPCWSTR) */ IntPtr pArguments, /* // Array of pointers to arguments to add _In_ */ uint argCount);
        
        [PreserveSig]
        HRESULT AddArgumentsUTF8(/* optional(LPCSTR) */ IntPtr pArguments, /* // Array of pointers to UTF-8 arguments to add _In_ */ uint argCount);
        
        [PreserveSig]
        HRESULT AddDefines(/* _In_count_(defineCount) */ [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 1)] DxcDefine[] pDefines, /* // Array of defines _In_ */ int defineCount);
    }
}
