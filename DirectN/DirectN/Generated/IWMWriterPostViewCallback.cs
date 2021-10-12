// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\wmsdkidl.h(9658,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [ComImport, Guid("d9d6549d-a193-4f24-b308-03123d9b7f8d"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IWMWriterPostViewCallback : IWMStatusCallback
    {
        // IWMStatusCallback
        [PreserveSig]
        new HRESULT OnStatus(/* [in] */ WMT_STATUS Status, /* [in] */ HRESULT hr, /* [in] */ WMT_ATTR_DATATYPE dwType, /* [in] */ ref byte pValue, /* [in] */ IntPtr pvContext);
        
        // IWMWriterPostViewCallback
        [PreserveSig]
        HRESULT OnPostViewSample(/* [in] */ ushort wStreamNumber, /* [in] */ ulong cnsSampleTime, /* [in] */ ulong cnsSampleDuration, /* [in] */ uint dwFlags, /* [in] */ INSSBuffer pSample, /* [in] */ IntPtr pvContext);
        
        [PreserveSig]
        HRESULT AllocateForPostView(/* [in] */ ushort wStreamNum, /* [in] */ uint cbBuffer, /* [out] */ out INSSBuffer ppBuffer, /* [in] */ IntPtr pvContext);
    }
}
