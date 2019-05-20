// c:\program files (x86)\windows kits\10\include\10.0.18362.0\um\wmpservices.h(241,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [Guid("68e27045-05bd-40b2-9720-23088c78e390"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IWMPMediaPluginRegistrar
    {
        [PreserveSig]
        HRESULT WMPRegisterPlayerPlugin(/* [in] */ [MarshalAs(UnmanagedType.LPWStr)] string pwszFriendlyName, /* [in] */ [MarshalAs(UnmanagedType.LPWStr)] string pwszDescription, /* [in] */ [MarshalAs(UnmanagedType.LPWStr)] string pwszUninstallString, uint dwPriority, Guid guidPluginType, Guid clsid, uint cMediaTypes, IntPtr pMediaTypes);
        
        [PreserveSig]
        HRESULT WMPUnRegisterPlayerPlugin(Guid guidPluginType, Guid clsid);
    }
}
