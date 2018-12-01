// c:\program files (x86)\windows kits\10\include\10.0.17763.0\um\audioengineendpoint.h(1042,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [Guid("f8520dd3-8f9d-4437-9861-62f584c33dd6"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IAudioEndpointLastBufferControl
    {
        [PreserveSig]
        bool IsLastBufferControlSupported();
        
        [PreserveSig]
        void ReleaseOutputDataPointerForLastBuffer(/* [in] */ ref APO_CONNECTION_PROPERTY pConnectionProperty);
    }
}
