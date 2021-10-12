// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\wmsdkidl.h(9089,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [ComImport, Guid("962dc1ec-c046-4db8-9cc7-26ceae500817"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IWMWriterAdvanced2 : IWMWriterAdvanced
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
        HRESULT GetInputSetting(/* [in] */ uint dwInputNum, /* [in] */ [MarshalAs(UnmanagedType.LPWStr)] string pszName, /* [out] */ out WMT_ATTR_DATATYPE pType, /* [size_is][out] */ [Out, MarshalAs(UnmanagedType.LPArray)] byte[] pValue, /* [out][in] */ ref ushort pcbLength);
        
        [PreserveSig]
        HRESULT SetInputSetting(/* [in] */ uint dwInputNum, /* [in] */ [MarshalAs(UnmanagedType.LPWStr)] string pszName, /* [in] */ WMT_ATTR_DATATYPE Type, /* [size_is][in] */ [MarshalAs(UnmanagedType.LPArray)] byte[] pValue, /* [in] */ ushort cbLength);
    }
}
