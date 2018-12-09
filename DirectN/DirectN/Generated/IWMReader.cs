// c:\program files (x86)\windows kits\10\include\10.0.17763.0\um\wmsdkidl.h(3417,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [Guid("96406bd6-2b2b-11d3-b36b-00c04f6108ff"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IWMReader
    {
        [PreserveSig]
        HRESULT Open(/* [in] */ [MarshalAs(UnmanagedType.LPWStr)] string pwszURL, /* [in] */ IWMReaderCallback pCallback, /* [in] */ [MarshalAs(UnmanagedType.IUnknown)] object pvContext);
        
        [PreserveSig]
        HRESULT Close();
        
        [PreserveSig]
        HRESULT GetOutputCount(/* [out] */ out uint pcOutputs);
        
        [PreserveSig]
        HRESULT GetOutputProps(/* [in] */ uint dwOutputNum, /* [out] */ out IWMOutputMediaProps ppOutput);
        
        [PreserveSig]
        HRESULT SetOutputProps(/* [in] */ uint dwOutputNum, /* [in] */ IWMOutputMediaProps pOutput);
        
        [PreserveSig]
        HRESULT GetOutputFormatCount(/* [in] */ uint dwOutputNumber, /* [out] */ out uint pcFormats);
        
        [PreserveSig]
        HRESULT GetOutputFormat(/* [in] */ uint dwOutputNumber, /* [in] */ uint dwFormatNumber, /* [out] */ out IWMOutputMediaProps ppProps);
        
        [PreserveSig]
        HRESULT Start(/* [in] */ ulong cnsStart, /* [in] */ ulong cnsDuration, /* [in] */ float fRate, /* [in] */ [MarshalAs(UnmanagedType.IUnknown)] object pvContext);
        
        [PreserveSig]
        HRESULT Stop();
        
        [PreserveSig]
        HRESULT Pause();
        
        [PreserveSig]
        HRESULT Resume();
    }
}
