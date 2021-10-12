// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\strmif.h(18814,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [ComImport, Guid("4a9a62d3-27d4-403d-91e9-89f540e55534"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IPinConnection
    {
        [PreserveSig]
        HRESULT DynamicQueryAccept(/* [in] */ ref _AMMediaType pmt);
        
        [PreserveSig]
        HRESULT NotifyEndOfStream(/* [in] */ IntPtr hNotifyEvent);
        
        [PreserveSig]
        HRESULT IsEndPin();
        
        [PreserveSig]
        HRESULT DynamicDisconnect();
    }
}
