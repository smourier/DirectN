// c:\program files (x86)\windows kits\10\include\10.0.17763.0\um\structuredquerycondition.h(233,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [Guid("0fc988d4-c935-4b97-a973-46282ea175c8"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface ICondition
    {
        [PreserveSig]
        HRESULT GetConditionType(/* [retval][out] __RPC__out */ out tagCONDITION_TYPE pNodeType);
        
        [PreserveSig]
        HRESULT GetSubConditions(/* [in] __RPC__in */ [MarshalAs(UnmanagedType.LPStruct)] Guid riid, /* [iid_is][retval][out] __RPC__deref_out_opt */ [MarshalAs(UnmanagedType.IUnknown)] out object ppv);
        
        [PreserveSig]
        HRESULT GetComparisonInfo(/* optional(LPWSTR) */ out IntPtr ppszPropertyName, /* [annotation][unique][out] _Out_opt_ */ out tagCONDITION_OPERATION pcop, /* [annotation][unique][out] _Out_opt_ */ PropVariant ppropvar);
        
        [PreserveSig]
        HRESULT GetValueType(/* optional(LPWSTR) */ out IntPtr ppszValueTypeName);
        
        [PreserveSig]
        HRESULT GetValueNormalization(/* optional(LPWSTR) */ out IntPtr ppszNormalization);
        
        [PreserveSig]
        HRESULT GetInputTerms(/* [annotation][unique][out] _Out_opt_ */ out IRichChunk ppPropertyTerm, /* [annotation][unique][out] _Out_opt_ */ out IRichChunk ppOperationTerm, /* [annotation][unique][out] _Out_opt_ */ out IRichChunk ppValueTerm);
        
        [PreserveSig]
        HRESULT Clone(/* [retval][out] __RPC__deref_out_opt */ out ICondition ppc);
    }
}
