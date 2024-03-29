﻿// generated from <Windows SDK Path>\um\wincodec.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [ComImport, Guid("dc2bb46d-3f07-481e-8625-220c4aedbb33"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IWICEnumMetadataItem
    {
        [PreserveSig]
        HRESULT Next(/* [in] */ uint celt, /* [size_is][unique][out][in] __RPC__inout_ecount_full_opt(celt) */ [In, Out] PROPVARIANT rgeltSchema, /* [size_is][out][in] __RPC__inout_ecount_full(celt) */ [In, Out] PROPVARIANT rgeltId, /* [size_is][optional][out][in] __RPC__inout_ecount_full(celt) */ [In, Out] PROPVARIANT rgeltValue, /* [optional][out] __RPC__out */ out uint pceltFetched);
        
        [PreserveSig]
        HRESULT Skip(/* [in] */ uint celt);
        
        [PreserveSig]
        HRESULT Reset();
        
        [PreserveSig]
        HRESULT Clone(/* [out] __RPC__deref_out_opt */ out IWICEnumMetadataItem ppIEnumMetadataItem);
    }
}
