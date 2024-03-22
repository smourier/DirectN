// generated from <Windows SDK Path>\um\wincodecsdk.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [ComImport, Guid("9204fe99-d8fc-4fd5-a001-9536b067a899"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IWICMetadataReader
    {
        [PreserveSig]
        HRESULT GetMetadataFormat(/* [out] __RPC__out */ out Guid pguidMetadataFormat);
        
        [PreserveSig]
        HRESULT GetMetadataHandlerInfo(/* [out] __RPC__deref_out_opt */ out IWICMetadataHandlerInfo ppIHandler);
        
        [PreserveSig]
        HRESULT GetCount(/* [out] __RPC__out */ out uint pcCount);
        
        [PreserveSig]
        HRESULT GetValueByIndex(/* [in] */ uint nIndex, /* [unique][out][in] __RPC__inout_opt */ [In, Out] PROPVARIANT pvarSchema, /* [unique][out][in] __RPC__inout_opt */ [In, Out] PROPVARIANT pvarId, /* [unique][out][in] __RPC__inout_opt */ [In, Out] PROPVARIANT pvarValue);
        
        [PreserveSig]
        HRESULT GetValue(/* [unique][in] __RPC__in_opt */ [In, Out] PROPVARIANT pvarSchema, /* [in] __RPC__in */ [In, Out] PROPVARIANT pvarId, /* [unique][out][in] __RPC__inout_opt */ [In, Out] PROPVARIANT pvarValue);
        
        [PreserveSig]
        HRESULT GetEnumerator(/* [out] __RPC__deref_out_opt */ out IWICEnumMetadataItem ppIEnumMetadata);
    }
}
