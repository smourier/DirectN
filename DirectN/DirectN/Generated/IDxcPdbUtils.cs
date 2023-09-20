// generated from <Windows SDK Path>\um\dxcapi.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [ComImport, Guid("E6C9647E-9D6A-4C3B-B94C-524B5A6C343D"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
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
