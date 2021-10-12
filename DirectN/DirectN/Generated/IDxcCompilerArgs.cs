// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\dxcapi.h(199,1)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [ComImport, Guid("73EFFE2A-70DC-45F8-9690-EFF64C02429D"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
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
