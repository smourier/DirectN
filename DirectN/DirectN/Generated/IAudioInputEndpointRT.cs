// c:\program files (x86)\windows kits\10\include\10.0.19041.0\um\audioengineendpoint.h(428,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [ComImport, Guid("8026ab61-92b2-43c1-a1df-5c37ebd08d82"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IAudioInputEndpointRT
    {
        [PreserveSig]
        void GetInputDataPointer(/* [out][in] */ ref APO_CONNECTION_PROPERTY pConnectionProperty, /* [out][in] */ ref AE_CURRENT_POSITION pAeTimeStamp);
        
        [PreserveSig]
        void ReleaseInputDataPointer(/* [in] */ uint u32FrameCount, /* [in] */ IntPtr pDataPointer);
        
        [PreserveSig]
        void PulseEndpoint();
    }
}
