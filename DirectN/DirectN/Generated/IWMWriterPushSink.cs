// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\wmsdkidl.h(17300,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [ComImport, Guid("dc10e6a5-072c-467d-bf57-6330a9dde12a"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IWMWriterPushSink : IWMWriterSink
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
        
        // IWMWriterPushSink
        [PreserveSig]
        HRESULT Connect(/* [in] */ [MarshalAs(UnmanagedType.LPWStr)] string pwszURL, /* [in] */ [MarshalAs(UnmanagedType.LPWStr)] string pwszTemplateURL, /* [in] */ bool fAutoDestroy);
        
        [PreserveSig]
        HRESULT Disconnect();
        
        [PreserveSig]
        HRESULT EndSession();
    }
}
