// generated from <Windows SDK Path>\um\wmsdkidl.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [ComImport, Guid("96406be4-2b2b-11d3-b36b-00c04f6108ff"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IWMWriterSink
    {
        [PreserveSig]
        HRESULT OnHeader(/* [in] */ INSSBuffer pHeader);
        
        [PreserveSig]
        HRESULT IsRealTime(/* [out] */ out bool pfRealTime);
        
        [PreserveSig]
        HRESULT AllocateDataUnit(/* [in] */ uint cbDataUnit, /* [out] */ out INSSBuffer ppDataUnit);
        
        [PreserveSig]
        HRESULT OnDataUnit(/* [in] */ INSSBuffer pDataUnit);
        
        [PreserveSig]
        HRESULT OnEndWriting();
    }
}
