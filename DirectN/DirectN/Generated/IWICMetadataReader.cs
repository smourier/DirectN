// c:\program files (x86)\windows kits\10\include\10.0.18362.0\um\wincodecsdk.h(560,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [Guid("9204fe99-d8fc-4fd5-a001-9536b067a899"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IWICMetadataReader
    {
        [PreserveSig]
        HRESULT GetMetadataFormat(/* [out] __RPC__out */ out Guid pguidMetadataFormat);
        
        [PreserveSig]
        HRESULT GetMetadataHandlerInfo(/* [out] __RPC__deref_out_opt */ out IWICMetadataHandlerInfo ppIHandler);
        
        [PreserveSig]
        HRESULT GetCount(/* [out] __RPC__out */ out uint pcCount);
        
        [PreserveSig]
        HRESULT GetValueByIndex(/* [in] */ uint nIndex, /* [unique][out][in] __RPC__inout_opt */ [In, Out] PropVariant pvarSchema, /* [unique][out][in] __RPC__inout_opt */ [In, Out] PropVariant pvarId, /* [unique][out][in] __RPC__inout_opt */ [In, Out] PropVariant pvarValue);
        
        [PreserveSig]
        HRESULT GetValue(/* [unique][in] __RPC__in_opt */ [In, Out] PropVariant pvarSchema, /* [in] __RPC__in */ [In, Out] PropVariant pvarId, /* [unique][out][in] __RPC__inout_opt */ [In, Out] PropVariant pvarValue);
        
        [PreserveSig]
        HRESULT GetEnumerator(/* [out] __RPC__deref_out_opt */ out IWICEnumMetadataItem ppIEnumMetadata);
    }
}
