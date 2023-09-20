// generated from <Windows SDK Path>\um\dxcapi.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [ComImport, Guid("25740e2e-9cba-401b-9119-4fb42f39f270"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IDxcOptimizer
    {
        [PreserveSig]
        HRESULT GetAvailablePassCount(/* _Out_ */ out uint pCount);
        
        [PreserveSig]
        HRESULT GetAvailablePass(uint index, /* _COM_Outptr_ */ out IDxcOptimizerPass ppResult);
        
        [PreserveSig]
        HRESULT RunOptimizer(IDxcBlob pBlob, /* _In_count_(optionCount) */ IntPtr ppOptions, uint optionCount, /* _COM_Outptr_ */ out IDxcBlob pOutputModule, /* _COM_Outptr_opt_ */ out IDxcBlobEncoding ppOutputText);
    }
}
