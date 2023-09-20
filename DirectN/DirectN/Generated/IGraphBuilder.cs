// generated from <Windows SDK Path>\um\strmif.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [ComImport, Guid("56a868a9-0ad4-11ce-b03a-0020af0ba770"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IGraphBuilder : IFilterGraph
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
        HRESULT Connect(/* [in] */ IPin ppinOut, /* [in] */ IPin ppinIn);
        
        [PreserveSig]
        HRESULT Render(/* [in] */ IPin ppinOut);
        
        [PreserveSig]
        HRESULT RenderFile(/* [in] */ [MarshalAs(UnmanagedType.LPWStr)] string lpcwstrFile, /* [annotation][unique][in] _In_opt_ */ [MarshalAs(UnmanagedType.LPWStr)] string lpcwstrPlayList);
        
        [PreserveSig]
        HRESULT AddSourceFilter(/* [in] */ [MarshalAs(UnmanagedType.LPWStr)] string lpcwstrFileName, /* [annotation][unique][in] _In_opt_ */ [MarshalAs(UnmanagedType.LPWStr)] string lpcwstrFilterName, /* [annotation][out] _Out_ */ out IBaseFilter ppFilter);
        
        [PreserveSig]
        HRESULT SetLogFile(/* [in] */ IntPtr hFile);
        
        [PreserveSig]
        HRESULT Abort();
        
        [PreserveSig]
        HRESULT ShouldOperationContinue();
    }
}
