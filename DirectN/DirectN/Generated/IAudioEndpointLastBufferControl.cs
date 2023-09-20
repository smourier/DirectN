// generated from <Windows SDK Path>\um\audioengineendpoint.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [ComImport, Guid("f8520dd3-8f9d-4437-9861-62f584c33dd6"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IAudioEndpointLastBufferControl
    {
        [PreserveSig]
        bool IsLastBufferControlSupported();
        
        [PreserveSig]
        void ReleaseOutputDataPointerForLastBuffer(/* [in] */ ref APO_CONNECTION_PROPERTY pConnectionProperty);
    }
}
