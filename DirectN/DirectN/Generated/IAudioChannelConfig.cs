// generated from <Windows SDK Path>\um\devicetopology.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [ComImport, Guid("bb11c46f-ec28-493c-b88a-5db88062ce98"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IAudioChannelConfig
    {
        [PreserveSig]
        HRESULT SetChannelConfig(/* [in] */ uint dwConfig, /* optional(LPCGUID) */ IntPtr pguidEventContext);
        
        [PreserveSig]
        HRESULT GetChannelConfig(/* [retval][out] */ out uint pdwConfig);
    }
}
