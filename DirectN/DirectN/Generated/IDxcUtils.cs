// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\dxcapi.h(357,1)
using System;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.ComTypes;

namespace DirectN
{
    [ComImport, Guid("4605C4CB-2019-492A-ADA4-65F20BB7D67F"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IDxcUtils
    {
        [PreserveSig]
        HRESULT CreateBlobFromBlob(/* _In_ */ IDxcBlob pBlob, uint offset, uint length, /* _COM_Outptr_ */ out IDxcBlob ppResult);
        
        [PreserveSig]
        HRESULT CreateBlobFromPinned(/* _In_bytecount_(size) */ [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 1)] IntPtr[] pData, int size, uint codePage, /* _COM_Outptr_ */ out IDxcBlobEncoding pBlobEncoding);
        
        [PreserveSig]
        HRESULT MoveToBlob(/* _In_bytecount_(size) */ [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 2)] IntPtr[] pData, ref IMalloc pIMalloc, int size, uint codePage, /* _COM_Outptr_ */ out IDxcBlobEncoding pBlobEncoding);
        
        [PreserveSig]
        HRESULT CreateBlob(/* _In_bytecount_(size) */ [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 1)] IntPtr[] pData, int size, uint codePage, /* _COM_Outptr_ */ out IDxcBlobEncoding pBlobEncoding);
        
        [PreserveSig]
        HRESULT LoadFile(/* _In_z_ */ [MarshalAs(UnmanagedType.LPWStr)] string pFileName, /* optional(UINT32) */ IntPtr pCodePage, /* _COM_Outptr_ */ out IDxcBlobEncoding pBlobEncoding);
        
        [PreserveSig]
        HRESULT CreateReadOnlyStreamFromBlob(/* _In_ */ IDxcBlob pBlob, /* _COM_Outptr_ */ out IStream ppStream);
        
        [PreserveSig]
        HRESULT CreateDefaultIncludeHandler(/* _COM_Outptr_ */ out IDxcIncludeHandler ppResult);
        
        [PreserveSig]
        HRESULT GetBlobAsUtf8(/* _In_ */ IDxcBlob pBlob, /* _COM_Outptr_ */ out IDxcBlobUtf8 pBlobEncoding);
        
        [PreserveSig]
        HRESULT GetBlobAsUtf16(/* _In_ */ IDxcBlob pBlob, /* _COM_Outptr_ */ out IDxcBlobUtf16 pBlobEncoding);
        
        [PreserveSig]
        HRESULT GetDxilContainerPart(/* _In_ */ ref DxcBuffer pShader, /* _In_ */ uint DxcPart, /* _Outptr_result_nullonfailure_ */ out IntPtr ppPartData, /* _Out_ */ out uint pPartSizeInBytes);
        
        [PreserveSig]
        HRESULT CreateReflection(/* _In_ */ ref DxcBuffer pData, [MarshalAs(UnmanagedType.LPStruct)] Guid iid, IntPtr ppvReflection);
        
        [PreserveSig]
        HRESULT BuildArguments(/* _In_opt_z_ */ [MarshalAs(UnmanagedType.LPWStr)] string pSourceName, /* // Optional file name for pSource. Used in errors and include handlers. _In_opt_z_ */ [MarshalAs(UnmanagedType.LPWStr)] string pEntryPoint, /* // Entry point name. (-E) _In_z_ */ [MarshalAs(UnmanagedType.LPWStr)] string pTargetProfile, /* optional(LPCWSTR) */ IntPtr pArguments, /* // Array of pointers to arguments _In_ */ uint argCount, /* // Number of arguments _In_count_(defineCount) */ [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 6)] DxcDefine[] pDefines, /* // Array of defines _In_ */ int defineCount, /* // Number of defines _COM_Outptr_ */ out IDxcCompilerArgs ppArgs);
        
        [PreserveSig]
        HRESULT GetPDBContents(/* _In_ */ IDxcBlob pPDBBlob, /* _COM_Outptr_ */ out IDxcBlob ppHash, /* _COM_Outptr_ */ out IDxcBlob ppContainer);
    }
}
