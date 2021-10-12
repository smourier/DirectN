// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\mfidl.h(16734,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [ComImport, Guid("4adfdba3-7ab0-4953-a62b-461e7ff3da1e"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IMFTranscodeProfile
    {
        [PreserveSig]
        HRESULT SetAudioAttributes(/* [annotation][in] _In_opt_ */ IMFAttributes pAttrs);
        
        [PreserveSig]
        HRESULT GetAudioAttributes(/* [annotation][out] _Outptr_result_maybenull_ */ out IMFAttributes ppAttrs);
        
        [PreserveSig]
        HRESULT SetVideoAttributes(/* [annotation][in] _In_opt_ */ IMFAttributes pAttrs);
        
        [PreserveSig]
        HRESULT GetVideoAttributes(/* [annotation][out] _Outptr_result_maybenull_ */ out IMFAttributes ppAttrs);
        
        [PreserveSig]
        HRESULT SetContainerAttributes(/* [annotation][in] _In_opt_ */ IMFAttributes pAttrs);
        
        [PreserveSig]
        HRESULT GetContainerAttributes(/* [annotation][out] _Outptr_result_maybenull_ */ out IMFAttributes ppAttrs);
    }
}
