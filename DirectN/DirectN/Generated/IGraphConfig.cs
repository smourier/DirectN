// generated from <Windows SDK Path>\um\strmif.h
using System;
using System.Runtime.InteropServices;
using REFERENCE_TIME = System.Int64;

namespace DirectN
{
    [ComImport, Guid("03a1eb8e-32bf-4245-8502-114d08a9cb88"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IGraphConfig
    {
        [PreserveSig]
        HRESULT Reconnect(/* [in] */ IPin pOutputPin, /* [in] */ IPin pInputPin, /* [in] */ ref _AMMediaType pmtFirstConnection, /* [in] */ IBaseFilter pUsingFilter, /* [in] */ IntPtr hAbortEvent, /* [in] */ uint dwFlags);
        
        [PreserveSig]
        HRESULT Reconfigure(/* [in] */ IGraphConfigCallback pCallback, /* [in] */ IntPtr pvContext, /* [in] */ uint dwFlags, /* [in] */ IntPtr hAbortEvent);
        
        [PreserveSig]
        HRESULT AddFilterToCache(/* [in] */ IBaseFilter pFilter);
        
        [PreserveSig]
        HRESULT EnumCacheFilter(/* [out] */ out IEnumFilters pEnum);
        
        [PreserveSig]
        HRESULT RemoveFilterFromCache(/* [in] */ IBaseFilter pFilter);
        
        [PreserveSig]
        HRESULT GetStartTime(/* [out] */ out REFERENCE_TIME prtStart);
        
        [PreserveSig]
        HRESULT PushThroughData(/* [in] */ IPin pOutputPin, /* [in] */ IPinConnection pConnection, /* [in] */ IntPtr hEventAbort);
        
        [PreserveSig]
        HRESULT SetFilterFlags(/* [in] */ IBaseFilter pFilter, /* [in] */ uint dwFlags);
        
        [PreserveSig]
        HRESULT GetFilterFlags(/* [in] */ IBaseFilter pFilter, /* [out] */ out uint pdwFlags);
        
        [PreserveSig]
        HRESULT RemoveFilterEx(/* [in] */ IBaseFilter pFilter, uint Flags);
    }
}
