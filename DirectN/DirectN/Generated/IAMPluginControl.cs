// c:\program files (x86)\windows kits\10\include\10.0.17763.0\um\strmif.h(17676,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [Guid("0e26a181-f40c-4635-8786-976284b52981"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IAMPluginControl
    {
        [PreserveSig]
        HRESULT GetPreferredClsid(/* [annotation] _In_ */ [MarshalAs(UnmanagedType.LPStruct)] Guid subType, /* [annotation] _Out_ */ out Guid clsid);
        
        [PreserveSig]
        HRESULT GetPreferredClsidByIndex(uint index, /* [annotation] _Out_ */ out Guid subType, /* [annotation] _Out_ */ out Guid clsid);
        
        [PreserveSig]
        HRESULT SetPreferredClsid(/* [annotation] _In_ */ [MarshalAs(UnmanagedType.LPStruct)] Guid subType, /* [annotation] _In_opt_ */ [MarshalAs(UnmanagedType.LPStruct)] Guid clsid);
        
        [PreserveSig]
        HRESULT IsDisabled([MarshalAs(UnmanagedType.LPStruct)] Guid clsid);
        
        [PreserveSig]
        HRESULT GetDisabledByIndex(uint index, /* [annotation] _Out_ */ out Guid clsid);
        
        [PreserveSig]
        HRESULT SetDisabled([MarshalAs(UnmanagedType.LPStruct)] Guid clsid, bool disabled);
        
        [PreserveSig]
        HRESULT IsLegacyDisabled([MarshalAs(UnmanagedType.LPWStr)] string dllName);
    }
}
