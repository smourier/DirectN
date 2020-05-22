// c:\program files (x86)\windows kits\10\include\10.0.19041.0\um\wmnetsourcecreator.h(94,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [Guid("0c0e4080-9081-11d2-beec-0060082f2054"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface INSNetSourceCreator
    {
        [PreserveSig]
        HRESULT Initialize();
        
        [PreserveSig]
        HRESULT CreateNetSource(/* [in] __RPC__in */ [MarshalAs(UnmanagedType.LPWStr)] string pszStreamName, /* [in] __RPC__in_opt */ [MarshalAs(UnmanagedType.IUnknown)] object pMonitor, /* [in] __RPC__in */ ref byte pData, /* [in] __RPC__in_opt */ [MarshalAs(UnmanagedType.IUnknown)] object pUserContext, /* [in] __RPC__in_opt */ [MarshalAs(UnmanagedType.IUnknown)] object pCallback, /* [in] */ ulong qwContext);
        
        [PreserveSig]
        HRESULT GetNetSourceProperties(/* [in] __RPC__in */ [MarshalAs(UnmanagedType.LPWStr)] string pszStreamName, /* [out] __RPC__deref_out_opt */ [MarshalAs(UnmanagedType.IUnknown)] out object ppPropertiesNode);
        
        [PreserveSig]
        HRESULT GetNetSourceSharedNamespace(/* [out] __RPC__deref_out_opt */ [MarshalAs(UnmanagedType.IUnknown)] out object ppSharedNamespace);
        
        [PreserveSig]
        HRESULT GetNetSourceAdminInterface(/* [in] __RPC__in */ [MarshalAs(UnmanagedType.LPWStr)] string pszStreamName, /* [out] __RPC__out */ out IntPtr pVal);
        
        [PreserveSig]
        HRESULT GetNumProtocolsSupported(/* [out] __RPC__out */ out uint pcProtocols);
        
        [PreserveSig]
        HRESULT GetProtocolName(/* [in] */ uint dwProtocolNum, /* [out] __RPC__out */ [MarshalAs(UnmanagedType.LPWStr)] out string pwszProtocolName, /* [out][in] __RPC__inout */ ref ushort pcchProtocolName);
        
        [PreserveSig]
        HRESULT Shutdown();
    }
}
