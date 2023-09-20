// generated from <Windows SDK Path>\um\wmpservices.h
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
