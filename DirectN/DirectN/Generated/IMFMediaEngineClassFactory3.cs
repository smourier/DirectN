// c:\program files (x86)\windows kits\10\include\10.0.17763.0\um\mfmediaengine.h(8325,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [Guid("3787614f-65f7-4003-b673-ead8293a0e60"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IMFMediaEngineClassFactory3
    {
        [PreserveSig]
        HRESULT CreateMediaKeySystemAccess(/* [annotation] _In_ */ [MarshalAs(UnmanagedType.BStr)] string keySystem, /* [annotation] _In_count_(uSize) */ out IntPtr ppSupportedConfigurationsArray, /* [annotation] _In_ */ uint uSize, /* [annotation] _COM_Outptr_ */ out IMFMediaKeySystemAccess ppKeyAccess);
    }
}
