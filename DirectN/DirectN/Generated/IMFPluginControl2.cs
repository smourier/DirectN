// c:\program files (x86)\windows kits\10\include\10.0.17763.0\um\mfobjects.h(5808,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [Guid("c6982083-3ddc-45cb-af5e-0f7a8ce4de77"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IMFPluginControl2 : IMFPluginControl
    {
        // IMFPluginControl
        [PreserveSig]
        new HRESULT GetPreferredClsid(uint pluginType, /* [annotation] _In_ */ [MarshalAs(UnmanagedType.LPWStr)] string selector, /* [annotation] _Out_ */ out Guid clsid);
        
        [PreserveSig]
        new HRESULT GetPreferredClsidByIndex(uint pluginType, uint index, /* [annotation] _Out_ */ out IntPtr selector, /* [annotation] _Out_ */ out Guid clsid);
        
        [PreserveSig]
        new HRESULT SetPreferredClsid(uint pluginType, /* [annotation] _In_ */ [MarshalAs(UnmanagedType.LPWStr)] string selector, /* optional(CLSID) */ IntPtr clsid);
        
        [PreserveSig]
        new HRESULT IsDisabled(uint pluginType, [MarshalAs(UnmanagedType.LPStruct)] Guid clsid);
        
        [PreserveSig]
        new HRESULT GetDisabledByIndex(uint pluginType, uint index, /* [annotation] _Out_ */ out Guid clsid);
        
        [PreserveSig]
        new HRESULT SetDisabled(uint pluginType, [MarshalAs(UnmanagedType.LPStruct)] Guid clsid, bool disabled);
        
        // IMFPluginControl2
        [PreserveSig]
        HRESULT SetPolicy(/* [in] */ MF_PLUGIN_CONTROL_POLICY policy);
    }
}
