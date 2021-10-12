// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\wmpservices.h(379,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [ComImport, Guid("f1392a70-024c-42bb-a998-73dfdfe7d5a7"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IWMPPlugin
    {
        [PreserveSig]
        HRESULT Init(IntPtr dwPlaybackContext);
        
        [PreserveSig]
        HRESULT Shutdown();
        
        [PreserveSig]
        HRESULT GetID(/* [retval][out] */ out Guid pGUID);
        
        [PreserveSig]
        HRESULT GetCaps(/* [retval][out] */ out uint pdwFlags);
        
        [PreserveSig]
        HRESULT AdviseWMPServices(/* [in] */ IWMPServices pWMPServices);
        
        [PreserveSig]
        HRESULT UnAdviseWMPServices();
    }
}
