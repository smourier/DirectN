// c:\program files (x86)\windows kits\10\include\10.0.17763.0\um\mediaobj.h(814,5)
using System;
using System.Runtime.InteropServices;
using REFERENCE_TIME = System.Int64;

namespace DirectN
{
    [Guid("651b9ad0-0fc7-4aa9-9538-d89931010741"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IMediaObjectInPlace
    {
        [PreserveSig]
        HRESULT Process(/* [in] */ uint ulSize, /* [annotation][size_is][out][in] _Out_writes_bytes_(ulSize) */ [In, Out, MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 0)] byte[] pData, /* [in] */ long refTimeStart, /* [in] */ uint dwFlags);
        
        [PreserveSig]
        HRESULT Clone(/* [annotation][out] _Out_ */ out IMediaObjectInPlace ppMediaObject);
        
        [PreserveSig]
        HRESULT GetLatency(/* [annotation][out] _Out_ */ out REFERENCE_TIME pLatencyTime);
    }
}
