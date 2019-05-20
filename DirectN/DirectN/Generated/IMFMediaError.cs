// c:\program files (x86)\windows kits\10\include\10.0.18362.0\um\mfmediaengine.h(440,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [Guid("fc0e10d2-ab2a-4501-a951-06bb1075184c"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IMFMediaError
    {
        [PreserveSig]
        ushort GetErrorCode();
        
        [PreserveSig]
        HRESULT GetExtendedErrorCode();
        
        [PreserveSig]
        HRESULT SetErrorCode(/* [annotation][in] _In_ */ MF_MEDIA_ENGINE_ERR error);
        
        [PreserveSig]
        HRESULT SetExtendedErrorCode(/* [annotation][in] _In_ */ HRESULT error);
    }
}
