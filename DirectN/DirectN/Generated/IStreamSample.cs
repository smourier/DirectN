// c:\program files (x86)\windows kits\10\include\10.0.17763.0\um\mmstream.h(470,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [Guid("b502d1be-9a57-11d0-8fde-00c04fd9189d"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IStreamSample
    {
        [PreserveSig]
        HRESULT GetMediaStream(/* [in] */ IMediaStream ppMediaStream);
        
        [PreserveSig]
        HRESULT GetSampleTimes(/* [out] */ out long pStartTime, /* [out] */ out long pEndTime, /* [out] */ out long pCurrentTime);
        
        [PreserveSig]
        HRESULT SetSampleTimes(/* [in] */ ref long pStartTime, /* [in] */ ref long pEndTime);
        
        [PreserveSig]
        HRESULT Update(/* [in] */ uint dwFlags, /* [in] */ IntPtr hEvent, /* [in] */ IntPtr pfnAPC, /* [in] */ ulong dwAPCData);
        
        [PreserveSig]
        HRESULT CompletionStatus(/* [in] */ uint dwFlags, /* [in] */ uint dwMilliseconds);
    }
}
