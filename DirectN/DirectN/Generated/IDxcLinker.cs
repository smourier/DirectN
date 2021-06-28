// c:\program files (x86)\windows kits\10\include\10.0.19041.0\um\dxcapi.h(236,1)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [ComImport, Guid("f1b5be2a-62dd-4327-a1c2-42ac1e1e78e6"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IDxcLinker
    {
        [PreserveSig]
        HRESULT RegisterLibrary(/* _In_opt_ */ [MarshalAs(UnmanagedType.LPWStr)] string pLibName, /* // Name of the library. _In_ */ IDxcBlob pLib);
        
        [PreserveSig]
        HRESULT Link(/* _In_opt_ */ [MarshalAs(UnmanagedType.LPWStr)] string pEntryName, /* // Entry point name _In_ */ [MarshalAs(UnmanagedType.LPWStr)] string pTargetProfile, /* // shader profile to link _In_count_(libCount) */ IntPtr pLibNames, /* // Array of library names to link */ uint libCount, /* // Number of libraries to link _In_count_(argCount) */ IntPtr pArguments, /* // Array of pointers to arguments _In_ */ uint argCount, /* // Number of arguments _COM_Outptr_ */ out IDxcOperationResult ppResult);
    }
}
