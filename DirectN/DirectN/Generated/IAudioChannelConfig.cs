// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\devicetopology.h(1031,5)
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
