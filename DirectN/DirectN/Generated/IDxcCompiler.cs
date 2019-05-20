// c:\program files (x86)\windows kits\10\include\10.0.18362.0\um\dxcapi.h(172,1)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [Guid("8c210bf3-011f-4422-8d70-6f9acb8db617"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IDxcCompiler
    {
        [PreserveSig]
        HRESULT Compile(/* _In_ */ IDxcBlob pSource, /* // Source text to compile _In_opt_ */ [MarshalAs(UnmanagedType.LPWStr)] string pSourceName, /* // Optional file name for pSource. Used in errors and include handlers. _In_ */ [MarshalAs(UnmanagedType.LPWStr)] string pEntryPoint, /* // entry point name _In_ */ [MarshalAs(UnmanagedType.LPWStr)] string pTargetProfile, /* // shader profile to compile _In_count_(argCount) */ IntPtr pArguments, /* // Array of pointers to arguments _In_ */ uint argCount, /* // Number of arguments _In_count_(defineCount) */ [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 7)] DxcDefine[] pDefines, /* // Array of defines _In_ */ uint defineCount, /* // Number of defines _In_opt_ */ IDxcIncludeHandler pIncludeHandler, /* // user-provided interface to handle #include directives (optional) _COM_Outptr_ */ out IDxcOperationResult ppResult);
        
        [PreserveSig]
        HRESULT Preprocess(/* _In_ */ IDxcBlob pSource, /* // Source text to preprocess _In_opt_ */ [MarshalAs(UnmanagedType.LPWStr)] string pSourceName, /* // Optional file name for pSource. Used in errors and include handlers. _In_count_(argCount) */ IntPtr pArguments, /* // Array of pointers to arguments _In_ */ uint argCount, /* // Number of arguments _In_count_(defineCount) */ [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 5)] DxcDefine[] pDefines, /* // Array of defines _In_ */ uint defineCount, /* // Number of defines _In_opt_ */ IDxcIncludeHandler pIncludeHandler, /* // user-provided interface to handle #include directives (optional) _COM_Outptr_ */ out IDxcOperationResult ppResult);
        
        [PreserveSig]
        HRESULT Disassemble(/* _In_ */ IDxcBlob pSource, /* // Program to disassemble. _COM_Outptr_ */ out IDxcBlobEncoding ppDisassembly);
    }
}
