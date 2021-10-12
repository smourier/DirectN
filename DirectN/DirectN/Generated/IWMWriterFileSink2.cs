// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\wmsdkidl.h(10326,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [ComImport, Guid("14282ba7-4aef-4205-8ce5-c229035a05bc"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IWMWriterFileSink2 : IWMWriterFileSink
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
        HRESULT Start(/* [in] */ ulong cnsStartTime);
        
        [PreserveSig]
        HRESULT Stop(/* [in] */ ulong cnsStopTime);
        
        [PreserveSig]
        HRESULT IsStopped(/* [out] */ out bool pfStopped);
        
        [PreserveSig]
        HRESULT GetFileDuration(/* [out] */ out ulong pcnsDuration);
        
        [PreserveSig]
        HRESULT GetFileSize(/* [out] */ out ulong pcbFile);
        
        [PreserveSig]
        HRESULT Close();
        
        [PreserveSig]
        HRESULT IsClosed(/* [out] */ out bool pfClosed);
    }
}
