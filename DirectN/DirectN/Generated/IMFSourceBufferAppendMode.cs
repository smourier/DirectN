// c:\program files (x86)\windows kits\10\include\10.0.19041.0\um\mfmediaengine.h(3643,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [Guid("19666fb4-babe-4c55-bc03-0a074da37e2a"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IMFSourceBufferAppendMode
    {
        [PreserveSig]
        MF_MSE_APPEND_MODE GetAppendMode();
        
        [PreserveSig]
        HRESULT SetAppendMode(/* [annotation][in] _In_ */ MF_MSE_APPEND_MODE mode);
    }
}
