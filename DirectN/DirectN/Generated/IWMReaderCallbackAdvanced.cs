// c:\program files (x86)\windows kits\10\include\10.0.18362.0\um\wmsdkidl.h(13299,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [Guid("96406beb-2b2b-11d3-b36b-00c04f6108ff"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IWMReaderCallbackAdvanced
    {
        [PreserveSig]
        HRESULT OnStreamSample(/* [in] */ ushort wStreamNum, /* [in] */ ulong cnsSampleTime, /* [in] */ ulong cnsSampleDuration, /* [in] */ uint dwFlags, /* [in] */ INSSBuffer pSample, /* [in] */ [MarshalAs(UnmanagedType.IUnknown)] object pvContext);
        
        [PreserveSig]
        HRESULT OnTime(/* [in] */ ulong cnsCurrentTime, /* [in] */ [MarshalAs(UnmanagedType.IUnknown)] object pvContext);
        
        [PreserveSig]
        HRESULT OnStreamSelection(/* [in] */ ushort wStreamCount, /* [in] */ ref ushort pStreamNumbers, /* [in] */ ref WMT_STREAM_SELECTION pSelections, /* [in] */ [MarshalAs(UnmanagedType.IUnknown)] object pvContext);
        
        [PreserveSig]
        HRESULT OnOutputPropsChanged(/* [in] */ uint dwOutputNum, /* [in] */ ref _WMMediaType pMediaType, /* [in] */ [MarshalAs(UnmanagedType.IUnknown)] object pvContext);
        
        [PreserveSig]
        HRESULT AllocateForStream(/* [in] */ ushort wStreamNum, /* [in] */ uint cbBuffer, /* [out] */ out INSSBuffer ppBuffer, /* [in] */ [MarshalAs(UnmanagedType.IUnknown)] object pvContext);
        
        [PreserveSig]
        HRESULT AllocateForOutput(/* [in] */ uint dwOutputNum, /* [in] */ uint cbBuffer, /* [out] */ out INSSBuffer ppBuffer, /* [in] */ [MarshalAs(UnmanagedType.IUnknown)] object pvContext);
    }
}
