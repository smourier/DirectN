// c:\program files (x86)\windows kits\10\include\10.0.17763.0\um\mfidl.h(15687,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [Guid("4adfdba3-7ab0-4953-a62b-461e7ff3da1e"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IMFTranscodeProfile
    {
        [PreserveSig]
        HRESULT SetAudioAttributes(/* optional(IMFAttributes) */ IntPtr pAttrs);
        
        [PreserveSig]
        HRESULT GetAudioAttributes(/* [annotation][out] _Outptr_result_maybenull_ */ out IntPtr ppAttrs);
        
        [PreserveSig]
        HRESULT SetVideoAttributes(/* optional(IMFAttributes) */ IntPtr pAttrs);
        
        [PreserveSig]
        HRESULT GetVideoAttributes(/* [annotation][out] _Outptr_result_maybenull_ */ out IntPtr ppAttrs);
        
        [PreserveSig]
        HRESULT SetContainerAttributes(/* optional(IMFAttributes) */ IntPtr pAttrs);
        
        [PreserveSig]
        HRESULT GetContainerAttributes(/* [annotation][out] _Outptr_result_maybenull_ */ out IntPtr ppAttrs);
    }
}
