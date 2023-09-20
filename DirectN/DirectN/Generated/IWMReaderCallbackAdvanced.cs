// generated from <Windows SDK Path>\um\wmsdkidl.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [ComImport, Guid("96406beb-2b2b-11d3-b36b-00c04f6108ff"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IWMReaderCallbackAdvanced
    {
        [PreserveSig]
        HRESULT OnStreamSample(/* [in] */ ushort wStreamNum, /* [in] */ ulong cnsSampleTime, /* [in] */ ulong cnsSampleDuration, /* [in] */ uint dwFlags, /* [in] */ INSSBuffer pSample, /* [in] */ IntPtr pvContext);
        
        [PreserveSig]
        HRESULT OnTime(/* [in] */ ulong cnsCurrentTime, /* [in] */ IntPtr pvContext);
        
        [PreserveSig]
        HRESULT OnStreamSelection(/* [in] */ ushort wStreamCount, /* [in] */ ref ushort pStreamNumbers, /* [in] */ ref WMT_STREAM_SELECTION pSelections, /* [in] */ IntPtr pvContext);
        
        [PreserveSig]
        HRESULT OnOutputPropsChanged(/* [in] */ uint dwOutputNum, /* [in] */ ref _WMMediaType pMediaType, /* [in] */ IntPtr pvContext);
        
        [PreserveSig]
        HRESULT AllocateForStream(/* [in] */ ushort wStreamNum, /* [in] */ uint cbBuffer, /* [out] */ out INSSBuffer ppBuffer, /* [in] */ IntPtr pvContext);
        
        [PreserveSig]
        HRESULT AllocateForOutput(/* [in] */ uint dwOutputNum, /* [in] */ uint cbBuffer, /* [out] */ out INSSBuffer ppBuffer, /* [in] */ IntPtr pvContext);
    }
}
