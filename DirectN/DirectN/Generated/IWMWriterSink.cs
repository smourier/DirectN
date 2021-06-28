// c:\program files (x86)\windows kits\10\include\10.0.19041.0\um\wmsdkidl.h(9436,5)
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
