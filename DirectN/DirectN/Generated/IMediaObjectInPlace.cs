// generated from <Windows SDK Path>\um\mediaobj.h
using System;
using System.Runtime.InteropServices;
using REFERENCE_TIME = System.Int64;

namespace DirectN
{
    [ComImport, Guid("651b9ad0-0fc7-4aa9-9538-d89931010741"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IMediaObjectInPlace
    {
        [PreserveSig]
        HRESULT Process(/* [in] */ int ulSize, /* [annotation][size_is][out][in] _Out_writes_bytes_(ulSize) */ [In, Out, MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 0)] byte[] pData, /* [in] */ long refTimeStart, /* [in] */ uint dwFlags);
        
        [PreserveSig]
        HRESULT Clone(/* [annotation][out] _Out_ */ out IMediaObjectInPlace ppMediaObject);
        
        [PreserveSig]
        HRESULT GetLatency(/* [annotation][out] _Out_ */ out REFERENCE_TIME pLatencyTime);
    }
}
