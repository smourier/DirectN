// c:\program files (x86)\windows kits\10\include\10.0.19041.0\um\audioengineendpoint.h(530,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [ComImport, Guid("8fa906e4-c31c-4e31-932e-19a66385e9aa"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IAudioOutputEndpointRT
    {
        [PreserveSig]
        IntPtr GetOutputDataPointer(/* [in] */ uint u32FrameCount, /* [in] */ ref AE_CURRENT_POSITION pAeTimeStamp);
        
        [PreserveSig]
        void ReleaseOutputDataPointer(/* [in] */ ref APO_CONNECTION_PROPERTY pConnectionProperty);
        
        [PreserveSig]
        void PulseEndpoint();
    }
}
