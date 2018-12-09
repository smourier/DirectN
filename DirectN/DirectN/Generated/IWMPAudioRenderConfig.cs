// c:\program files (x86)\windows kits\10\include\10.0.17763.0\um\wmprealestate.h(926,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [Guid("e79c6349-5997-4ce4-917c-22a3391ec564"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IWMPAudioRenderConfig
    {
        [PreserveSig]
        HRESULT get_audioOutputDevice(/* [retval][out] */ out IntPtr pbstrOutputDevice);
        
        [PreserveSig]
        HRESULT put_audioOutputDevice(/* [unique][in] */ [MarshalAs(UnmanagedType.BStr)] string bstrOutputDevice);
    }
}
