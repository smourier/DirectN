// generated from <Windows SDK Path>\um\dxcapi.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    /// <summary>
    /// DxcPdbUtils interface.
    /// </summary>
    [ComImport, Guid("4315d938-f369-4f93-95a2-252017cc3807"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IDxcPdbUtils2
    {
        [PreserveSig]
        HRESULT Load(/* _In_ */ IDxcBlob pPdbOrDxil);
        
        [PreserveSig]
        HRESULT GetSourceCount(/* _Out_ */ out uint pCount);
        
        [PreserveSig]
        HRESULT GetSource(/* _In_ */ uint uIndex, /* _COM_Outptr_ */ out IDxcBlobEncoding ppResult);
        
        [PreserveSig]
        HRESULT GetSourceName(/* _In_ */ uint uIndex, /* _COM_Outptr_ */ out IDxcBlobWide ppResult);
        
        [PreserveSig]
        HRESULT GetLibraryPDBCount(ref uint pCount);
        
        [PreserveSig]
        HRESULT GetLibraryPDB(/* _In_ */ uint uIndex, /* _COM_Outptr_ */ out IDxcPdbUtils2 ppOutPdbUtils, /* _COM_Outptr_opt_result_maybenull_ */ out IDxcBlobWide ppLibraryName);
        
        [PreserveSig]
        HRESULT GetFlagCount(/* _Out_ */ out uint pCount);
        
        [PreserveSig]
        HRESULT GetFlag(/* _In_ */ uint uIndex, /* _COM_Outptr_ */ out IDxcBlobWide ppResult);
        
        [PreserveSig]
        HRESULT GetArgCount(/* _Out_ */ out uint pCount);
        
        [PreserveSig]
        HRESULT GetArg(/* _In_ */ uint uIndex, /* _COM_Outptr_ */ out IDxcBlobWide ppResult);
        
        [PreserveSig]
        HRESULT GetArgPairCount(/* _Out_ */ out uint pCount);
        
        [PreserveSig]
        HRESULT GetArgPair(/* _In_ */ uint uIndex, /* _COM_Outptr_result_maybenull_ */ out IDxcBlobWide ppName, /* _COM_Outptr_result_maybenull_ */ out IDxcBlobWide ppValue);
        
        [PreserveSig]
        HRESULT GetDefineCount(/* _Out_ */ out uint pCount);
        
        [PreserveSig]
        HRESULT GetDefine(/* _In_ */ uint uIndex, /* _COM_Outptr_ */ out IDxcBlobWide ppResult);
        
        [PreserveSig]
        HRESULT GetTargetProfile(/* _COM_Outptr_result_maybenull_ */ out IDxcBlobWide ppResult);
        
        [PreserveSig]
        HRESULT GetEntryPoint(/* _COM_Outptr_result_maybenull_ */ out IDxcBlobWide ppResult);
        
        [PreserveSig]
        HRESULT GetMainFileName(/* _COM_Outptr_result_maybenull_ */ out IDxcBlobWide ppResult);
        
        [PreserveSig]
        HRESULT GetHash(/* _COM_Outptr_result_maybenull_ */ out IDxcBlob ppResult);
        
        [PreserveSig]
        HRESULT GetName(/* _COM_Outptr_result_maybenull_ */ out IDxcBlobWide ppResult);
        
        [PreserveSig]
        HRESULT GetVersionInfo(/* _COM_Outptr_result_maybenull_ */ out IDxcVersionInfo ppVersionInfo);
        
        [PreserveSig]
        HRESULT GetCustomToolchainID(/* _Out_ */ out uint pID);
        
        [PreserveSig]
        HRESULT GetCustomToolchainData(/* _COM_Outptr_result_maybenull_ */ out IDxcBlob ppBlob);
        
        [PreserveSig]
        HRESULT GetWholeDxil(/* _COM_Outptr_result_maybenull_ */ out IDxcBlob ppResult);
        
        [PreserveSig]
        bool IsFullPDB();
        
        [PreserveSig]
        bool IsPDBRef();
    }
}
