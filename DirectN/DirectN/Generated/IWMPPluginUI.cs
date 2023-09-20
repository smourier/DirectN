// generated from <Windows SDK Path>\um\wmpplug.h
using System;
using System.Runtime.InteropServices;
using LPMSG = DirectN.tagMSG;

namespace DirectN
{
    [ComImport, Guid("4c5e8f9f-ad3e-4bf9-9753-fcd30d6d38dd"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IWMPPluginUI
    {
        [PreserveSig]
        HRESULT SetCore(/* [in] */ IWMPCore pCore);
        
        [PreserveSig]
        HRESULT Create(/* [in] */ IntPtr hwndParent, /* [out] */ out IntPtr phwndWindow);
        
        [PreserveSig]
        HRESULT Destroy();
        
        [PreserveSig]
        HRESULT DisplayPropertyPage(/* [in] */ IntPtr hwndParent);
        
        [PreserveSig]
        HRESULT GetProperty(/* [in] */ [MarshalAs(UnmanagedType.LPWStr)] string pwszName, /* [out] */ out IntPtr pvarProperty);
        
        [PreserveSig]
        HRESULT SetProperty(/* [in] */ [MarshalAs(UnmanagedType.LPWStr)] string pwszName, /* [in] */ IntPtr pvarProperty);
        
        [PreserveSig]
        HRESULT TranslateAcceleratorW(/* [in] */ ref LPMSG lpmsg);
    }
}
