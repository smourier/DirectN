// c:\program files (x86)\windows kits\10\include\10.0.17763.0\um\strmif.h(2211,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [Guid("56a86895-0ad4-11ce-b03a-0020af0ba770"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IBaseFilter : IMediaFilter
    {
        // IMediaFilter
        [PreserveSig]
        new HRESULT Stop();
        
        [PreserveSig]
        new HRESULT Pause();
        
        [PreserveSig]
        new HRESULT Run(long tStart);
        
        [PreserveSig]
        new HRESULT GetState(/* [in] */ uint dwMilliSecsTimeout, /* [annotation][out] _Out_ */ out _FilterState State);
        
        [PreserveSig]
        new HRESULT SetSyncSource(/* [annotation][in] _In_opt_ */ IReferenceClock pClock);
        
        [PreserveSig]
        new HRESULT GetSyncSource(/* [annotation][out] _Outptr_result_maybenull_ */ out IReferenceClock pClock);
        
        // IBaseFilter
        [PreserveSig]
        HRESULT EnumPins(/* [annotation][out] _Out_ */ out IEnumPins ppEnum);
        
        [PreserveSig]
        HRESULT FindPin(/* [string][in] */ [MarshalAs(UnmanagedType.LPWStr)] string Id, /* [annotation][out] _Out_ */ out IPin ppPin);
        
        [PreserveSig]
        HRESULT QueryFilterInfo(/* [annotation][out] _Out_ */ out _FilterInfo pInfo);
        
        [PreserveSig]
        HRESULT JoinFilterGraph(/* [annotation][in] _In_opt_ */ IFilterGraph pGraph, /* [annotation][string][in] _In_opt_ */ [MarshalAs(UnmanagedType.LPWStr)] string pName);
        
        [PreserveSig]
        HRESULT QueryVendorInfo(/* [annotation][string][out] _Out_ */ out IntPtr pVendorInfo);
    }
}
