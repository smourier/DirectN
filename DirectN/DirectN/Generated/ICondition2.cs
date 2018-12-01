// c:\program files (x86)\windows kits\10\include\10.0.17763.0\um\structuredquerycondition.h(460,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [Guid("0db8851d-2e5b-47eb-9208-d28c325a01d7"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface ICondition2 : ICondition
    {
        // ICondition
        [PreserveSig]
        new HRESULT GetConditionType(/* [retval][out] __RPC__out */ out tagCONDITION_TYPE pNodeType);
        
        [PreserveSig]
        new HRESULT GetSubConditions(/* [in] __RPC__in */ [MarshalAs(UnmanagedType.LPStruct)] Guid riid, /* [iid_is][retval][out] __RPC__deref_out_opt */ [MarshalAs(UnmanagedType.IUnknown)] out object ppv);
        
        [PreserveSig]
        new HRESULT GetComparisonInfo(/* [annotation][unique][out] _Outptr_opt_result_maybenull_ */ out IntPtr ppszPropertyName, /* [annotation][unique][out] _Out_opt_ */ out tagCONDITION_OPERATION pcop, /* [annotation][unique][out] _Out_opt_ */ out PropVariant ppropvar);
        
        [PreserveSig]
        new HRESULT GetValueType(/* [retval][out] __RPC__deref_out_opt */ out IntPtr ppszValueTypeName);
        
        [PreserveSig]
        new HRESULT GetValueNormalization(/* [retval][out] __RPC__deref_out_opt */ out IntPtr ppszNormalization);
        
        [PreserveSig]
        new HRESULT GetInputTerms(/* [annotation][unique][out] _Out_opt_ */ out IRichChunk ppPropertyTerm, /* [annotation][unique][out] _Out_opt_ */ out IRichChunk ppOperationTerm, /* [annotation][unique][out] _Out_opt_ */ out IRichChunk ppValueTerm);
        
        [PreserveSig]
        new HRESULT Clone(/* [retval][out] __RPC__deref_out_opt */ out ICondition ppc);
        
        // ICondition2
        [PreserveSig]
        HRESULT GetLocale(/* [out] __RPC__deref_out_opt */ out IntPtr ppszLocaleName);
        
        [PreserveSig]
        HRESULT GetLeafConditionInfo(/* [annotation][out] _Out_opt_ */ out _tagpropertykey ppropkey, /* [annotation][out] _Out_opt_ */ out tagCONDITION_OPERATION pcop, /* [annotation][out] _Out_opt_ */ out PropVariant ppropvar);
    }
}
