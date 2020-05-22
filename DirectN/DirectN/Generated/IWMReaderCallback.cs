// c:\program files (x86)\windows kits\10\include\10.0.19041.0\um\wmsdkidl.h(4480,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [Guid("96406bd8-2b2b-11d3-b36b-00c04f6108ff"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IWMReaderCallback : IWMStatusCallback
    {
        // IWMStatusCallback
        [PreserveSig]
        new HRESULT OnStatus(/* [in] */ WMT_STATUS Status, /* [in] */ HRESULT hr, /* [in] */ WMT_ATTR_DATATYPE dwType, /* [in] */ ref byte pValue, /* [in] */ IntPtr pvContext);
        
        // IWMReaderCallback
        [PreserveSig]
        HRESULT OnSample(/* [in] */ uint dwOutputNum, /* [in] */ ulong cnsSampleTime, /* [in] */ ulong cnsSampleDuration, /* [in] */ uint dwFlags, /* [in] */ INSSBuffer pSample, /* [in] */ IntPtr pvContext);
    }
}
