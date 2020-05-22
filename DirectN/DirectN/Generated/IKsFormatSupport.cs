// c:\program files (x86)\windows kits\10\include\10.0.19041.0\um\devicetopology.h(2228,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [Guid("3cb4a69d-bb6f-4d2b-95b7-452d2c155db5"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IKsFormatSupport
    {
        [PreserveSig]
        HRESULT IsFormatSupported(/* [size_is][in] */ [MarshalAs(UnmanagedType.LPArray)] KSDATAFORMAT[] pKsFormat, /* [annotation][in] _In_ */ uint cbFormat, /* [annotation][out] _Out_ */ out bool pbSupported);
        
        [PreserveSig]
        HRESULT GetDevicePreferredFormat(/* [out] */ out IntPtr ppKsFormat);
    }
}
