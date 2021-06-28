// c:\program files (x86)\windows kits\10\include\10.0.19041.0\um\wmsdkidl.h(9948,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [ComImport, Guid("3fea4feb-2945-47a7-a1dd-c53a8fc4c45c"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IWMWriterFileSink3 : IWMWriterFileSink2
    {
        // IWMWriterSink
        [PreserveSig]
        new HRESULT OnHeader(/* [in] */ INSSBuffer pHeader);
        
        [PreserveSig]
        new HRESULT IsRealTime(/* [out] */ out bool pfRealTime);
        
        [PreserveSig]
        new HRESULT AllocateDataUnit(/* [in] */ uint cbDataUnit, /* [out] */ out INSSBuffer ppDataUnit);
        
        [PreserveSig]
        new HRESULT OnDataUnit(/* [in] */ INSSBuffer pDataUnit);
        
        [PreserveSig]
        new HRESULT OnEndWriting();
        
        // IWMWriterFileSink
        [PreserveSig]
        new HRESULT Open(/* [in] */ [MarshalAs(UnmanagedType.LPWStr)] string pwszFilename);
        
        // IWMWriterFileSink2
        [PreserveSig]
        new HRESULT Start(/* [in] */ ulong cnsStartTime);
        
        [PreserveSig]
        new HRESULT Stop(/* [in] */ ulong cnsStopTime);
        
        [PreserveSig]
        new HRESULT IsStopped(/* [out] */ out bool pfStopped);
        
        [PreserveSig]
        new HRESULT GetFileDuration(/* [out] */ out ulong pcnsDuration);
        
        [PreserveSig]
        new HRESULT GetFileSize(/* [out] */ out ulong pcbFile);
        
        [PreserveSig]
        new HRESULT Close();
        
        [PreserveSig]
        new HRESULT IsClosed(/* [out] */ out bool pfClosed);
        
        // IWMWriterFileSink3
        [PreserveSig]
        HRESULT SetAutoIndexing(/* [in] */ bool fDoAutoIndexing);
        
        [PreserveSig]
        HRESULT GetAutoIndexing(/* [out] */ out bool pfAutoIndexing);
        
        [PreserveSig]
        HRESULT SetControlStream(/* [in] */ ushort wStreamNumber, /* [in] */ bool fShouldControlStartAndStop);
        
        [PreserveSig]
        HRESULT GetMode(/* [out] */ out uint pdwFileSinkMode);
        
        [PreserveSig]
        HRESULT OnDataUnitEx(/* [in] */ ref _WMT_FILESINK_DATA_UNIT pFileSinkDataUnit);
        
        [PreserveSig]
        HRESULT SetUnbufferedIO(/* [in] */ bool fUnbufferedIO, /* [in] */ bool fRestrictMemUsage);
        
        [PreserveSig]
        HRESULT GetUnbufferedIO(/* [out] */ out bool pfUnbufferedIO);
        
        [PreserveSig]
        HRESULT CompleteOperations();
    }
}
