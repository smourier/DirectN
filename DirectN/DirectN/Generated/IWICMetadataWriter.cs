// generated from <Windows SDK Path>\um\wincodecsdk.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [ComImport, Guid("f7836e16-3be0-470b-86bb-160d0aecd7de"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IWICMetadataWriter : IWICMetadataReader
    {
        // IWICMetadataReader
        [PreserveSig]
        new HRESULT GetMetadataFormat(/* [out] __RPC__out */ out Guid pguidMetadataFormat);
        
        [PreserveSig]
        new HRESULT GetMetadataHandlerInfo(/* [out] __RPC__deref_out_opt */ out IWICMetadataHandlerInfo ppIHandler);
        
        [PreserveSig]
        new HRESULT GetCount(/* [out] __RPC__out */ out uint pcCount);
        
        [PreserveSig]
        new HRESULT GetValueByIndex(/* [in] */ uint nIndex, /* [unique][out][in] __RPC__inout_opt */ [In, Out] PROPVARIANT pvarSchema, /* [unique][out][in] __RPC__inout_opt */ [In, Out] PROPVARIANT pvarId, /* [unique][out][in] __RPC__inout_opt */ [In, Out] PROPVARIANT pvarValue);
        
        [PreserveSig]
        new HRESULT GetValue(/* [unique][in] __RPC__in_opt */ [In, Out] PROPVARIANT pvarSchema, /* [in] __RPC__in */ [In, Out] PROPVARIANT pvarId, /* [unique][out][in] __RPC__inout_opt */ [In, Out] PROPVARIANT pvarValue);
        
        [PreserveSig]
        new HRESULT GetEnumerator(/* [out] __RPC__deref_out_opt */ out IWICEnumMetadataItem ppIEnumMetadata);
        
        // IWICMetadataWriter
        [PreserveSig]
        HRESULT SetValue(/* [unique][in] __RPC__in_opt */ [In, Out] PROPVARIANT pvarSchema, /* [in] __RPC__in */ [In, Out] PROPVARIANT pvarId, /* [in] __RPC__in */ [In, Out] PROPVARIANT pvarValue);
        
        [PreserveSig]
        HRESULT SetValueByIndex(/* [in] */ uint nIndex, /* [unique][in] __RPC__in_opt */ [In, Out] PROPVARIANT pvarSchema, /* [in] __RPC__in */ [In, Out] PROPVARIANT pvarId, /* [in] __RPC__in */ [In, Out] PROPVARIANT pvarValue);
        
        [PreserveSig]
        HRESULT RemoveValue(/* [unique][in] __RPC__in_opt */ [In, Out] PROPVARIANT pvarSchema, /* [in] __RPC__in */ [In, Out] PROPVARIANT pvarId);
        
        [PreserveSig]
        HRESULT RemoveValueByIndex(/* [in] */ uint nIndex);
    }
}
