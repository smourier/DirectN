// generated from <Windows SDK Path>\um\wmsdkidl.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [ComImport, Guid("96406be5-2b2b-11d3-b36b-00c04f6108ff"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IWMWriterFileSink : IWMWriterSink
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
        HRESULT Open(/* [in] */ [MarshalAs(UnmanagedType.LPWStr)] string pwszFilename);
    }
}
