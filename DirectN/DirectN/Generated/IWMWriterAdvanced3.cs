// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\wmsdkidl.h(9296,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [ComImport, Guid("2cd6492d-7c37-4e76-9d3b-59261183a22e"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IWMWriterAdvanced3 : IWMWriterAdvanced2
    {
        // IWMWriterAdvanced
        [PreserveSig]
        new HRESULT GetSinkCount(/* [out] */ out uint pcSinks);
        
        [PreserveSig]
        new HRESULT GetSink(/* [in] */ uint dwSinkNum, /* [out] */ out IWMWriterSink ppSink);
        
        [PreserveSig]
        new HRESULT AddSink(/* [in] */ IWMWriterSink pSink);
        
        [PreserveSig]
        new HRESULT RemoveSink(/* [in] */ IWMWriterSink pSink);
        
        [PreserveSig]
        new HRESULT WriteStreamSample(/* [in] */ ushort wStreamNum, /* [in] */ ulong cnsSampleTime, /* [in] */ uint msSampleSendTime, /* [in] */ ulong cnsSampleDuration, /* [in] */ uint dwFlags, /* [in] */ INSSBuffer pSample);
        
        [PreserveSig]
        new HRESULT SetLiveSource(bool fIsLiveSource);
        
        [PreserveSig]
        new HRESULT IsRealTime(/* [out] */ out bool pfRealTime);
        
        [PreserveSig]
        new HRESULT GetWriterTime(/* [out] */ out ulong pcnsCurrentTime);
        
        [PreserveSig]
        new HRESULT GetStatistics(/* [in] */ ushort wStreamNum, /* [out] */ out _WMWriterStatistics pStats);
        
        [PreserveSig]
        new HRESULT SetSyncTolerance(/* [in] */ uint msWindow);
        
        [PreserveSig]
        new HRESULT GetSyncTolerance(/* [out] */ out uint pmsWindow);
        
        // IWMWriterAdvanced2
        [PreserveSig]
        new HRESULT GetInputSetting(/* [in] */ uint dwInputNum, /* [in] */ [MarshalAs(UnmanagedType.LPWStr)] string pszName, /* [out] */ out WMT_ATTR_DATATYPE pType, /* [size_is][out] */ [Out, MarshalAs(UnmanagedType.LPArray)] byte[] pValue, /* [out][in] */ ref ushort pcbLength);
        
        [PreserveSig]
        new HRESULT SetInputSetting(/* [in] */ uint dwInputNum, /* [in] */ [MarshalAs(UnmanagedType.LPWStr)] string pszName, /* [in] */ WMT_ATTR_DATATYPE Type, /* [size_is][in] */ [MarshalAs(UnmanagedType.LPArray)] byte[] pValue, /* [in] */ ushort cbLength);
        
        // IWMWriterAdvanced3
        [PreserveSig]
        HRESULT GetStatisticsEx(/* [in] */ ushort wStreamNum, /* [out] */ out _WMWriterStatisticsEx pStats);
        
        [PreserveSig]
        HRESULT SetNonBlocking();
    }
}
