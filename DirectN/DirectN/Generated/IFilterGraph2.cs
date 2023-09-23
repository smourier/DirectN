// generated from <Windows SDK Path>\um\strmif.h
using System;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.ComTypes;

namespace DirectN
{
    [ComImport, Guid("36b73882-c2c8-11cf-8b46-00805f6cef60"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IFilterGraph2 : IGraphBuilder
    {
        // IFilterGraph
        [PreserveSig]
        new HRESULT AddFilter(/* [in] */ IBaseFilter pFilter, /* [string][in] */ [MarshalAs(UnmanagedType.LPWStr)] string pName);
        
        [PreserveSig]
        new HRESULT RemoveFilter(/* [in] */ IBaseFilter pFilter);
        
        [PreserveSig]
        new HRESULT EnumFilters(/* [annotation][out] _Out_ */ out IEnumFilters ppEnum);
        
        [PreserveSig]
        new HRESULT FindFilterByName(/* [string][in] */ [MarshalAs(UnmanagedType.LPWStr)] string pName, /* [annotation][out] _Out_ */ out IBaseFilter ppFilter);
        
        [PreserveSig]
        new HRESULT ConnectDirect(/* [in] */ IPin ppinOut, /* [in] */ IPin ppinIn, /* optional(_AMMediaType) */ IntPtr pmt);
        
        [PreserveSig]
        new HRESULT Reconnect(/* [in] */ IPin ppin);
        
        [PreserveSig]
        new HRESULT Disconnect(/* [in] */ IPin ppin);
        
        [PreserveSig]
        new HRESULT SetDefaultSyncSource();
        
        // IGraphBuilder
        [PreserveSig]
        new HRESULT Connect(/* [in] */ IPin ppinOut, /* [in] */ IPin ppinIn);
        
        [PreserveSig]
        new HRESULT Render(/* [in] */ IPin ppinOut);
        
        [PreserveSig]
        new HRESULT RenderFile(/* [in] */ [MarshalAs(UnmanagedType.LPWStr)] string lpcwstrFile, /* [annotation][unique][in] _In_opt_ */ [MarshalAs(UnmanagedType.LPWStr)] string lpcwstrPlayList);
        
        [PreserveSig]
        new HRESULT AddSourceFilter(/* [in] */ [MarshalAs(UnmanagedType.LPWStr)] string lpcwstrFileName, /* [annotation][unique][in] _In_opt_ */ [MarshalAs(UnmanagedType.LPWStr)] string lpcwstrFilterName, /* [annotation][out] _Out_ */ out IBaseFilter ppFilter);
        
        [PreserveSig]
        new HRESULT SetLogFile(/* [in] */ IntPtr hFile);
        
        [PreserveSig]
        new HRESULT Abort();
        
        [PreserveSig]
        new HRESULT ShouldOperationContinue();
        
        // IFilterGraph2
        [PreserveSig]
        HRESULT AddSourceFilterForMoniker(/* [in] */ IMoniker pMoniker, /* [in] */ IBindCtx pCtx, /* [unique][in] */ [MarshalAs(UnmanagedType.LPWStr)] string lpcwstrFilterName, /* [annotation][out] _Out_ */ out IBaseFilter ppFilter);
        
        [PreserveSig]
        HRESULT ReconnectEx(/* [in] */ IPin ppin, /* optional(_AMMediaType) */ IntPtr pmt);
        
        [PreserveSig]
        HRESULT RenderEx(/* [in] */ IPin pPinOut, /* [in] */ uint dwFlags, /* [annotation][out][in] _Reserved_ */ IntPtr pvContext);
    }
}
