// c:\program files (x86)\windows kits\10\include\10.0.19041.0\um\mfobjects.h(5630,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [Guid("5c6c44bf-1db6-435b-9249-e8cd10fdec96"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IMFPluginControl
    {
        [PreserveSig]
        HRESULT GetPreferredClsid(uint pluginType, /* [annotation] _In_ */ [MarshalAs(UnmanagedType.LPWStr)] string selector, /* [annotation] _Out_ */ out Guid clsid);
        
        [PreserveSig]
        HRESULT GetPreferredClsidByIndex(uint pluginType, uint index, /* [annotation] _Out_ */ out IntPtr selector, /* [annotation] _Out_ */ out Guid clsid);
        
        [PreserveSig]
        HRESULT SetPreferredClsid(uint pluginType, /* [annotation] _In_ */ [MarshalAs(UnmanagedType.LPWStr)] string selector, /* optional(CLSID) */ IntPtr clsid);
        
        [PreserveSig]
        HRESULT IsDisabled(uint pluginType, [MarshalAs(UnmanagedType.LPStruct)] Guid clsid);
        
        [PreserveSig]
        HRESULT GetDisabledByIndex(uint pluginType, uint index, /* [annotation] _Out_ */ out Guid clsid);
        
        [PreserveSig]
        HRESULT SetDisabled(uint pluginType, [MarshalAs(UnmanagedType.LPStruct)] Guid clsid, bool disabled);
    }
}
