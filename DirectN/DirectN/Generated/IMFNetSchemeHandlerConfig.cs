// generated from <Windows SDK Path>\um\mfidl.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [ComImport, Guid("7be19e73-c9bf-468a-ac5a-a5e8653bec87"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IMFNetSchemeHandlerConfig
    {
        [PreserveSig]
        HRESULT GetNumberOfSupportedProtocols(/* [annotation][out] _Out_ */ out uint pcProtocols);
        
        [PreserveSig]
        HRESULT GetSupportedProtocolType(/* [in] */ uint nProtocolIndex, /* [annotation][out] _Out_ */ out _MFNETSOURCE_PROTOCOL_TYPE pnProtocolType);
        
        [PreserveSig]
        HRESULT ResetProtocolRolloverSettings();
    }
}
