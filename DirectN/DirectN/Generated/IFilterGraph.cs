// c:\program files (x86)\windows kits\10\include\10.0.17763.0\um\strmif.h(1745,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [Guid("56a8689f-0ad4-11ce-b03a-0020af0ba770"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IFilterGraph
    {
        [PreserveSig]
        HRESULT AddFilter(/* [in] */ IBaseFilter pFilter, /* [string][in] */ [MarshalAs(UnmanagedType.LPWStr)] string pName);
        
        [PreserveSig]
        HRESULT RemoveFilter(/* [in] */ IBaseFilter pFilter);
        
        [PreserveSig]
        HRESULT EnumFilters(/* [annotation][out] _Out_ */ out IEnumFilters ppEnum);
        
        [PreserveSig]
        HRESULT FindFilterByName(/* [string][in] */ [MarshalAs(UnmanagedType.LPWStr)] string pName, /* [annotation][out] _Out_ */ out IBaseFilter ppFilter);
        
        [PreserveSig]
        HRESULT ConnectDirect(/* [in] */ IPin ppinOut, /* [in] */ IPin ppinIn, /* [annotation][unique][in] _In_opt_ */ ref _AMMediaType pmt);
        
        [PreserveSig]
        HRESULT Reconnect(/* [in] */ IPin ppin);
        
        [PreserveSig]
        HRESULT Disconnect(/* [in] */ IPin ppin);
        
        [PreserveSig]
        HRESULT SetDefaultSyncSource();
    }
}
