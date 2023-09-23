// generated from <Windows SDK Path>\um\dxcapi.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [ComImport, Guid("e6c9647e-9d6a-4c3b-b94c-524b5a6c343d"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IDxcPdbUtils
    {
        [PreserveSig]
        HRESULT Load(/* _In_ */ IDxcBlob pPdbOrDxil);
        
        [PreserveSig]
        HRESULT GetSourceCount(/* _Out_ */ out uint pCount);
        
        [PreserveSig]
        HRESULT GetSource(/* _In_ */ uint uIndex, /* _COM_Outptr_ */ out IDxcBlobEncoding ppResult);
        
        [PreserveSig]
        HRESULT GetSourceName(/* _In_ */ uint uIndex, /* _Outptr_result_z_ */ out IntPtr pResult);
        
        [PreserveSig]
        HRESULT GetFlagCount(/* _Out_ */ out uint pCount);
        
        [PreserveSig]
        HRESULT GetFlag(/* _In_ */ uint uIndex, /* _Outptr_result_z_ */ out IntPtr pResult);
        
        [PreserveSig]
        HRESULT GetArgCount(/* _Out_ */ out uint pCount);
        
        [PreserveSig]
        HRESULT GetArg(/* _In_ */ uint uIndex, /* _Outptr_result_z_ */ out IntPtr pResult);
        
        [PreserveSig]
        HRESULT GetArgPairCount(/* _Out_ */ out uint pCount);
        
        [PreserveSig]
        HRESULT GetArgPair(/* _In_ */ uint uIndex, /* _Outptr_result_z_ */ out IntPtr pName, /* _Outptr_result_z_ */ out IntPtr pValue);
        
        [PreserveSig]
        HRESULT GetDefineCount(/* _Out_ */ out uint pCount);
        
        [PreserveSig]
        HRESULT GetDefine(/* _In_ */ uint uIndex, /* _Outptr_result_z_ */ out IntPtr pResult);
        
        [PreserveSig]
        HRESULT GetTargetProfile(/* _Outptr_result_z_ */ out IntPtr pResult);
        
        [PreserveSig]
        HRESULT GetEntryPoint(/* _Outptr_result_z_ */ out IntPtr pResult);
        
        [PreserveSig]
        HRESULT GetMainFileName(/* _Outptr_result_z_ */ out IntPtr pResult);
        
        [PreserveSig]
        HRESULT GetHash(/* _COM_Outptr_ */ out IDxcBlob ppResult);
        
        [PreserveSig]
        HRESULT GetName(/* _Outptr_result_z_ */ out IntPtr pResult);
        
        [PreserveSig]
        bool IsFullPDB();
        
        [PreserveSig]
        HRESULT GetFullPDB(/* _COM_Outptr_ */ out IDxcBlob ppFullPDB);
        
        [PreserveSig]
        HRESULT GetVersionInfo(/* _COM_Outptr_ */ out IDxcVersionInfo ppVersionInfo);
        
        [PreserveSig]
        HRESULT SetCompiler(/* _In_ */ IDxcCompiler3 pCompiler);
        
        [PreserveSig]
        HRESULT CompileForFullPDB(/* _COM_Outptr_ */ out IDxcResult ppResult);
        
        [PreserveSig]
        HRESULT OverrideArgs(/* _In_ */ ref DxcArgPair pArgPairs, uint uNumArgPairs);
        
        [PreserveSig]
        HRESULT OverrideRootSignature(/* _In_ */ [MarshalAs(UnmanagedType.LPWStr)] string pRootSignature);
    }
}
