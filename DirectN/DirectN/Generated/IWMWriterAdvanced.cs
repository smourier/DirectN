// c:\program files (x86)\windows kits\10\include\10.0.19041.0\um\wmsdkidl.h(8417,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [ComImport, Guid("96406be3-2b2b-11d3-b36b-00c04f6108ff"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IWMWriterAdvanced
    {
        [PreserveSig]
        HRESULT GetSinkCount(/* [out] */ out uint pcSinks);
        
        [PreserveSig]
        HRESULT GetSink(/* [in] */ uint dwSinkNum, /* [out] */ out IWMWriterSink ppSink);
        
        [PreserveSig]
        HRESULT AddSink(/* [in] */ IWMWriterSink pSink);
        
        [PreserveSig]
        HRESULT RemoveSink(/* [in] */ IWMWriterSink pSink);
        
        [PreserveSig]
        HRESULT WriteStreamSample(/* [in] */ ushort wStreamNum, /* [in] */ ulong cnsSampleTime, /* [in] */ uint msSampleSendTime, /* [in] */ ulong cnsSampleDuration, /* [in] */ uint dwFlags, /* [in] */ INSSBuffer pSample);
        
        [PreserveSig]
        HRESULT SetLiveSource(bool fIsLiveSource);
        
        [PreserveSig]
        HRESULT IsRealTime(/* [out] */ out bool pfRealTime);
        
        [PreserveSig]
        HRESULT GetWriterTime(/* [out] */ out ulong pcnsCurrentTime);
        
        [PreserveSig]
        HRESULT GetStatistics(/* [in] */ ushort wStreamNum, /* [out] */ out _WMWriterStatistics pStats);
        
        [PreserveSig]
        HRESULT SetSyncTolerance(/* [in] */ uint msWindow);
        
        [PreserveSig]
        HRESULT GetSyncTolerance(/* [out] */ out uint pmsWindow);
    }
}
